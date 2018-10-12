using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace Zellensimulation
{
    public partial class Form1 : Form
    {
        private Board _board = new Board(15);
        private Brush _farbeLebend = Brushes.Orange;
        private Brush _farbeTot = Brushes.White;
        private string _sourcePath = Application.StartupPath;
        

        public Form1()
        {
            InitializeComponent();
            
            this.GridPanel.Size = new Size(401, 401);
            this.GridPanel.Location = new Point(14, 14);
            this.GridPanel.Visible = true;
        }

        public void Form1_Shown(object sender, EventArgs e)
        {
            CreateBoard();
            UpdateLabel();
        }

        private void button1_Click(object sender, EventArgs e) => MessageBox.Show("Anzahl Nachbarn zum Überleben: 2-3\nAnzahl Nachbarn bei Vereinsamung(Tod): > 2\nAnzahl Nachbarn bei Überbevölkerung(Tod): < 3\nAnzahl Nachbarn für Zellenentstehung: 3", "Regeln");
        public void farbeBtn_Click(object sender, EventArgs e)
        {
            if (_colorDialog1.ShowDialog() == DialogResult.OK)
            {
                _colorAliveBtn.BackColor = _colorDialog1.Color;
            }
            _farbeLebend = new SolidBrush(_colorDialog1.Color);
            ShowCells();
        }

        public void button1_Click_1(object sender, EventArgs e)
        {
            if (_colorDialog2.ShowDialog() == DialogResult.OK)
            {
                _colorDeadBtn.BackColor = _colorDialog2.Color;
            }
            _farbeTot = new SolidBrush(_colorDialog2.Color);
            ShowCells();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(_textBoxDimension.Text))
                {
                    CreateBoard();
                }
                else
                {
                    _board = new Board(Convert.ToInt32(_textBoxDimension.Text));
                    CreateBoard();
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("Bitte gültige Zahl eingeben.", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

        public void CreateBoard()
        {
            var cellSize = GridPanel.Width / _board.Dimension;
            var graph = GridPanel.CreateGraphics();
            graph.Clear(Color.White);
                for (int y = 0; y < _board.Dimension +1; ++y)
                {
                    graph.DrawLine(Pens.Black, 0, y * cellSize, _board.Dimension * cellSize, y * cellSize);
                }

                for (int x = 0; x < _board.Dimension +1; ++x)
                {
                    graph.DrawLine(Pens.Black, x * cellSize, 0, x * cellSize, _board.Dimension * cellSize);
                }
                _board.Reset();
                _amountAliveLbl.Text = "Anzahl lebende Zellen: " + 0;
                _amountGenLbl.Text = "Anzahl Generationen: " + 0;
                ShowCells();
        }        

        private void schrittBtn_Click(object sender, EventArgs e)
        {
            _board.CalcNextGen();
            ShowCells();
            AnzLebende();
            AnzGen();
        }

        public void ShowCell(int row, int column)
        {
            var graph = GridPanel.CreateGraphics();
            var cellSize = GridPanel.Width / _board.Dimension;
            if (_board.GetValue(row, column) == true)
            {
                graph.FillRectangle(_farbeLebend, new Rectangle(row*cellSize+1, column*cellSize+1, cellSize-1, cellSize-1));
            }
            else if (_board.GetValue(row,column)== false)
            {
                graph.FillRectangle(_farbeTot, new Rectangle(row*cellSize+1, column*cellSize+1, cellSize-1, cellSize-1));
            }
        }

        public void ShowCells()
        {
            for (int i = 0; i < _board.Dimension; i++)
            {
                for (int j = 0; j < _board.Dimension; j++)
                {
                    ShowCell(i, j);
                }
            }
        }

        private BackgroundWorker Bw = null;
        public int delay = 250;
        private void startBtn_Click(object sender, EventArgs e)
        {
            Bw = new BackgroundWorker();
            Bw.WorkerSupportsCancellation = true;
            Bw.DoWork += new DoWorkEventHandler((state, args) =>
            {
                do
                {
                    if (Bw.CancellationPending)
                        break;

                    if (_board.CountAlive() == 0)
                    {
                        Bw.CancelAsync();
                        MessageBox.Show("Alle Zellen sind tot. Drücken Sie Stop um den Vorgang zu stoppen.", "Alle Zellen tot", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if (_board.CountAlive() > 0)
                        {
                            _board.CalcNextGen();
                            ShowCells();
                            Thread.Sleep(delay);
                        }
                        else
                        {
                            Bw.CancelAsync();
                        }
                    }
                    
                } while (true);
            });

            Bw.RunWorkerAsync();
            _startBtn.Enabled = false;
            _stopBtn.Enabled = true;
            _nextBtn.Enabled = false;
            _resetBtn.Enabled = false;
            _textBoxDimension.Enabled = false;
        }
        private async void UpdateLabel()
        {
            while (true)
            {
                await Task.Delay(delay);
                AnzGen();
                AnzLebende();
            }
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            Stop();
        }

        private void Stop()
        {
            _stopBtn.Enabled = false;
            _startBtn.Enabled = true;
            _nextBtn.Enabled = true;
            _resetBtn.Enabled = true;
            _textBoxDimension.Enabled = true;
            Bw.CancelAsync();
            AnzLebende();
            AnzGen();
        }

        public void AnzLebende()
        {
                _amountAliveLbl.Text = "Anzahl lebende Zellen: " + _board.CountAlive().ToString();
        }
        public void AnzGen()
        {
            _amountGenLbl.Text = "Anzahl Generationen: " + _board.GetGen().ToString();
        }

        private void GridPanel_MouseClick(object sender, MouseEventArgs e)
        {
            var cellSize = GridPanel.Width / _board.Dimension;
            this.Cursor = new Cursor(Cursor.Current.Handle);
            int posX = e.Location.X;
            int posY = e.Location.Y;
            int posXcell = posX / cellSize;
            int posYcell = posY / cellSize;

            if (_board.GetValue(posXcell, posYcell) == true)
            {
                _board.SetValue(posXcell, posYcell, false);
                var graph = GridPanel.CreateGraphics();
                graph.FillRectangle(_farbeTot, new Rectangle(posXcell * cellSize + 1, posYcell * cellSize + 1, cellSize - 1, cellSize - 1));
            }
            else
            {
                _board.SetValue(posXcell, posYcell, true);
                var graph = GridPanel.CreateGraphics();
                graph.FillRectangle(_farbeLebend, new Rectangle(posXcell * cellSize + 1, posYcell * cellSize + 1, cellSize - 1, cellSize - 1));
            }
            AnzLebende();
        }

        private void _saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (_comboBox.Text == "")
                {
                    MessageBox.Show("Bitte Name für das Muster eingeben.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    System.IO.File.WriteAllText(_sourcePath +"\\"+ _comboBox.Text + "_" +_board.Dimension +"x"+_board.Dimension + ".txt", _board.SaveTrue());
                    MessageBox.Show("Muster erfolgreich gespeichert.", "Gespeichert", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    UpdateCombobox();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bitte gültiger Name für das Muster eingeben.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            _comboBox.Text = "";
            _comboBox.Refresh();
        }

        private void _deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                System.IO.File.Delete(_sourcePath + "\\" + _comboBox.Text);
                _comboBox.Text = "";
                _comboBox.Items.RemoveAt(_comboBox.SelectedIndex);
                MessageBox.Show("Muster erfolgreich gelöscht.", "Muster gelöscht", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception)
            {
                MessageBox.Show("Muster existiert nicht.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateCombobox();
        }

        private void _loadBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string fileValue = System.IO.File.ReadAllText(_sourcePath + "\\" + _comboBox.Text);
                string[] coords = fileValue.Split(';');
                CreateBoard();
                for (int i = 0; i < coords.Length - 1; i++)
                {
                    var x = coords[i];
                    string[] singleValue = x.Split(',');

                    _board.SetValue(Convert.ToInt32(singleValue[0]), Convert.ToInt32(singleValue[1]), true);
                }
                ShowCells();
            }
            catch (Exception)
            {
                MessageBox.Show("Bitte gültiges Muster auswählen oder Dimension prüfen.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            _comboBox.Text = "";
        }

        public void UpdateCombobox()
        {
            _comboBox.Items.Clear();
            string[] files = new DirectoryInfo(_sourcePath).GetFiles().Where(o => o.Name.EndsWith(".txt")).Select(o => o.Name).ToArray();
            this._comboBox.Items.AddRange(files);
        }

        private void _speedTrackbar_Scroll(object sender, EventArgs e)
        {
            delay = _speedTrackbar.Value;
        }
    }
}
