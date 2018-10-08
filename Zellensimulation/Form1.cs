using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zellensimulation
{
    public partial class Form1 : Form
    {
        Board board = new Board();
        Brush farbeLebend = Brushes.Black;
        Brush farbeTot = Brushes.White;

        public Form1()
        {
            InitializeComponent();
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

        public void Form1_Shown(object sender, EventArgs e)
        {
            createBoard();
        }

       

        private void PanelGrid_MouseDown(object sender, MouseEventArgs e)
        {
            this.Cursor = new Cursor(Cursor.Current.Handle);
            int posX = e.Location.X;
            int posY = e.Location.Y;

            int posXcell = posX / 20 ;
            int posYcell = posY / 20 ;


            if (board.GetValue(posXcell,posYcell)==true)
            {
                board.SetValue(posXcell, posYcell, false);
                var graph = panelGrid.CreateGraphics();
                graph.FillRectangle(farbeTot, new Rectangle(posXcell * 20+1, posYcell * 20+1, 19, 19));
            }
            else
            {
                board.SetValue(posXcell, posYcell, true);
                var graph = panelGrid.CreateGraphics();
                graph.FillRectangle(farbeLebend, new Rectangle(posXcell * 20+1, posYcell * 20+1, 19, 19));
            }

            
            
           
            
        }

        public void createBoard()
        {
            var bitmap = new Bitmap(600, 600);
            try
            {
                var graph = panelGrid.CreateGraphics();
                graph.FillRectangle(farbeTot, new Rectangle(new Point(0, 0), bitmap.Size));
                for (int col = 0; col < bitmap.Width; col += 20)
                {
                    graph.DrawLine(Pens.Black, new Point(col, 0), new Point(col, bitmap.Height));
                }
                for (int row = 0; row < bitmap.Height; row += 20)
                {
                    graph.DrawLine(Pens.Black, new Point(0, row), new Point(bitmap.Width, row));
                }
                graph.DrawRectangle(Pens.Black, new Rectangle(0, 0, bitmap.Width - 1, bitmap.Height - 1));



            }
            finally
            {
                bitmap.Dispose();
            }
        }

        private void randomBtn_Click(object sender, EventArgs e)
        {

        }

        private void schrittBtn_Click(object sender, EventArgs e)
        {
            
            board.CalcNextGen();
            
        }

       
    }
}
