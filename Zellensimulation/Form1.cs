using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zellensimulation
{
    public partial class Form1 : Form
    {
        Board board = new Board(15);
        Brush _farbeLebend = Brushes.Orange;
        Brush _farbeTot = Brushes.White;

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
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                _farbeLebBtn.BackColor = colorDialog1.Color;
            }
            _farbeLebend = new SolidBrush(colorDialog1.Color);
        }

        public void button1_Click_1(object sender, EventArgs e)
        {
            if (colorDialog2.ShowDialog() == DialogResult.OK)
            {
                _farbeTotBtn.BackColor = colorDialog2.Color;
            }
                _farbeTot = new SolidBrush(colorDialog2.Color);
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
                    board = new Board(Convert.ToInt32(_textBoxDimension.Text));
                    CreateBoard();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bitte gültige Zahl eingeben.", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            _textBoxDimension.Clear();
        }

        public void CreateBoard()
        {
            var cellSize = GridPanel.Width / board.Dimension;
            var graph = GridPanel.CreateGraphics();
            graph.Clear(Color.White);
                for (int y = 0; y < board.Dimension +1; ++y)
                {
                    graph.DrawLine(Pens.Black, 0, y * cellSize, board.Dimension * cellSize, y * cellSize);
                }

                for (int x = 0; x < board.Dimension +1; ++x)
                {
                    graph.DrawLine(Pens.Black, x * cellSize, 0, x * cellSize, board.Dimension * cellSize);
                }
                board.Reset();
                _anzLebendeLbl.Text = "Anzahl lebende Zellen: " + 0;
                _anzGenLbl.Text = "Anzahl Generationen: " + 0;
                ShowCells();
        }

        private void schrittBtn_Click(object sender, EventArgs e)
        {
            board.CalcNextGen();
            ShowCells();
            AnzLebende();
            AnzGen();
        }

        public void ShowCell(int row, int column)
        {
            var graph = GridPanel.CreateGraphics();
            var cellSize = GridPanel.Width / board.Dimension;
            if (board.GetValue(row, column) == true)
            {
                graph.FillRectangle(_farbeLebend, new Rectangle(row*cellSize+1, column*cellSize+1, cellSize-1, cellSize-1));
            }
            else if (board.GetValue(row,column)== false)
            {
                graph.FillRectangle(_farbeTot, new Rectangle(row*cellSize+1, column*cellSize+1, cellSize-1, cellSize-1));
            }
        }

        public void ShowCells()
        {
            for (int i = 0; i < board.Dimension; i++)
            {
                for (int j = 0; j < board.Dimension; j++)
                {
                    ShowCell(i, j);
                }
            }
        }

        private BackgroundWorker Bw = null;
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

                    board.CalcNextGen();
                    ShowCells();
                    Thread.Sleep(250);
                } while (true);
            });
            Bw.RunWorkerAsync();
            _startBtn.Enabled = false;
            _stopBtn.Enabled = true;
            _weiterBtn.Enabled = false;
            _resetBtn.Enabled = false;
            _textBoxDimension.Enabled = false;
        }
        private async void UpdateLabel()
        {
            while (true)
            {
                await Task.Delay(250);
                AnzGen();
                AnzLebende();
            }
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            _stopBtn.Enabled = false;
            _startBtn.Enabled = true;
            _weiterBtn.Enabled = true;
            _resetBtn.Enabled = true;
            _textBoxDimension.Enabled = true;
            Bw.CancelAsync();
            AnzLebende();
            AnzGen();
        }

        public void AnzLebende()
        {
                _anzLebendeLbl.Text = "Anzahl lebende Zellen: " + board.CountAlive().ToString();
        }
        public void AnzGen()
        {
            _anzGenLbl.Text = "Anzahl Generationen: " + board.GetGen().ToString();
        }

        private void GridPanel_MouseClick(object sender, MouseEventArgs e)
        {
            var cellSize = GridPanel.Width / board.Dimension;
            this.Cursor = new Cursor(Cursor.Current.Handle);
            int posX = e.Location.X;
            int posY = e.Location.Y;
            int posXcell = posX / cellSize;
            int posYcell = posY / cellSize;

            if (board.GetValue(posXcell, posYcell) == true)
            {
                board.SetValue(posXcell, posYcell, false);
                var graph = GridPanel.CreateGraphics();
                graph.FillRectangle(_farbeTot, new Rectangle(posXcell * cellSize + 1, posYcell * cellSize + 1, cellSize - 1, cellSize - 1));
            }
            else
            {
                board.SetValue(posXcell, posYcell, true);
                var graph = GridPanel.CreateGraphics();
                graph.FillRectangle(_farbeLebend, new Rectangle(posXcell * cellSize + 1, posYcell * cellSize + 1, cellSize - 1, cellSize - 1));
            }
            AnzLebende();
        }

        private void _saveBtn_Click(object sender, EventArgs e)
        {
            SaveTrue();
        }

        private void _deleteBtn_Click(object sender, EventArgs e)
        {

        }

        public void SaveTrue()
        {
            StringBuilder stb = new StringBuilder();
            for (int i = 0; i < board.Dimension; i++)
            {
                for (int j = 0; j < board.Dimension; j++)
                {
                    if (board.GetValue(i, j) == true)
                    {
                        string cellrow = Convert.ToString(i);
                        string cellcolumn = Convert.ToString(j);

                        //stb.Append(i).Append(",").Append(j).Append(";");
                        //string version2 = cellrow + "," + cellcolumn + ";";
                        //string version3 = string.Format("{0},{1};", i, j);
                        stb.AppendFormat("{0},{1};", i, j);
                    }
                }
            }
            System.IO.File.WriteAllText("C:\\Users\\remog\\source\\repos\\Zellensimulation\\TextfilesPatterns\\" + _comboBox.Text + ".txt", stb.ToString());
        }
    }
}
