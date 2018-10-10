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
        Board board = new Board(20);
        Brush farbeLebend = Brushes.Black;
        Brush farbeTot = Brushes.White;
        int _cellSize;
        



        public Form1()
        {
            InitializeComponent();
            this.GridPanel.Size = new Size(400, 400);
            this.GridPanel.Location = new Point(14, 14);
            this.GridPanel.Visible = true;



            _cellSize = GridPanel.Width / board.Dimension;
        }

        
        

        public void Form1_Shown(object sender, EventArgs e)
        {
            
            createBoard();

        }


        private void button1_Click(object sender, EventArgs e) => MessageBox.Show("Anzahl Nachbarn zum Überleben: 2-3\nAnzahl Nachbarn bei Vereinsamung(Tod): > 2\nAnzahl Nachbarn bei Überbevölkerung(Tod): < 3\nAnzahl Nachbarn für Zellenentstehung: 3", "Regeln");

        public void farbeBtn_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                farbeBtn.BackColor = colorDialog1.Color;
            }
                farbeLebend = new SolidBrush(colorDialog1.Color);
        }

        private void farbeBtn2_Click(object sender, EventArgs e)
        {

        }

        public void button1_Click_1(object sender, EventArgs e)
        {
            if (colorDialog2.ShowDialog() == DialogResult.OK)
            {
                button1.BackColor = colorDialog2.Color;
            }
                farbeTot = new SolidBrush(colorDialog2.Color);
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            createBoard();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        

       

        private void PanelGrid_MouseDown(object sender, MouseEventArgs e)
        {
            
            
        }

        public void createBoard()
        {
            

            var graph = GridPanel.CreateGraphics();

                for (int y = 0; y < board.Dimension; ++y)
                {
                    graph.DrawLine(Pens.Black, 0, y * _cellSize, board.Dimension * _cellSize, y * _cellSize);
                }

                for (int x = 0; x < board.Dimension; ++x)
                {
                    graph.DrawLine(Pens.Black, x * _cellSize, 0, x * _cellSize, board.Dimension * _cellSize);
                }

                board.Reset();
                anzLebendeLbl.Text = "Anzahl lebende Zellen: " + 0;
                anzGenLbl.Text = "Anzahl Generationen: " + 0;
                ShowCells();
        }

        private void randomBtn_Click(object sender, EventArgs e)
        {

        }
        

        private void schrittBtn_Click(object sender, EventArgs e)
        {

            board.CalcNextGen();
            ShowCells();
            anzLebende();
            anzGen();
        }

        public void ShowCell(int row, int column)
        {
            var graph = GridPanel.CreateGraphics();

            
            if (board.GetValue(row, column) == true)
            {
           
                graph.FillRectangle(farbeLebend, new Rectangle(row*_cellSize+1, column*_cellSize+1, _cellSize-1, _cellSize-1));
                
            }
            else if (board.GetValue(row,column)== false)
            {
              
                graph.FillRectangle(farbeTot, new Rectangle(row*_cellSize+1, column*_cellSize+1, _cellSize-1, _cellSize-1));
                
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
            startBtn.Enabled = false;
            stopBtn.Enabled = true;
            schrittBtn.Enabled = false;
            clearBtn.Enabled = false;

            
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            stopBtn.Enabled = false;
            startBtn.Enabled = true;
            schrittBtn.Enabled = true;
            clearBtn.Enabled = true;
            Bw.CancelAsync();
            anzLebende();
            anzGen();
          
            
        }

        private void anzLebendeLbl_Click(object sender, EventArgs e)
        {
            
        }

        public void anzLebende()
        {
            anzLebendeLbl.Text = "Anzahl lebende Zellen: " + board.CountAlive().ToString();
        }
        public void anzGen()
        {
            anzGenLbl.Text = "Anzahl Generationen: " + board.GetGen().ToString();
        }

        private void GridPanel_MouseClick(object sender, MouseEventArgs e)
        {
            this.Cursor = new Cursor(Cursor.Current.Handle);
            int posX = e.Location.X;
            int posY = e.Location.Y;

            int posXcell = posX / _cellSize;
            int posYcell = posY / _cellSize;


            if (board.GetValue(posXcell, posYcell) == true)
            {
                board.SetValue(posXcell, posYcell, false);
                var graph = GridPanel.CreateGraphics();
                graph.FillRectangle(farbeTot, new Rectangle(posXcell * _cellSize + 1, posYcell * _cellSize + 1, _cellSize - 1, _cellSize - 1));
            }
            else
            {
                board.SetValue(posXcell, posYcell, true);
                var graph = GridPanel.CreateGraphics();
                graph.FillRectangle(farbeLebend, new Rectangle(posXcell * _cellSize + 1, posYcell * _cellSize + 1, _cellSize - 1, _cellSize - 1));
            }




            anzLebende();
        }
    }
}
