using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zellensimulation
{
    class Board
    {
        private bool[,] Zustand = new bool[20, 20];
        

        public void SetValue(int row, int column, Boolean value)
        {
            Zustand[row, column] = value;
        }

        public bool GetValue(int row, int column)
        {
            return Zustand[row, column];
        }

        public int GetNeighbors(int row, int column)
        {
            int neighbors = 0;
            if (row >= 0 && row < 20 && column >= 0 && column < 20)
            {
                if (row <= 0 || column >=19)
                {
                }
                else
                {
                    if (Zustand[row - 1, column + 1] == true)
                    {
                        neighbors++;
                    }
                }

                if (column >=19)
                {
                }
                else
                {
                    if (Zustand[row, column + 1] == true)
                    {
                        neighbors++;
                    }
                }

                if (row >= 19 || column >=19)
                {
                }
                else
                {
                    if (Zustand[row + 1, column + 1] == true)
                    {
                        neighbors++;
                    }
                }


                if (row <= 0)
                {
                }
                else
                {
                    if (Zustand[row - 1, column] == true)
                    {
                        neighbors++;
                    }
                }

                if (row >= 19)
                {
                }
                else
                {
                    if (Zustand[row + 1, column] == true)
                    {
                        neighbors++;
                    }
                }

                if (row >= 0 || column >= 0)
                {
                }
                else
                {
                    if (Zustand[row - 1, column - 1] == true)
                    {
                        neighbors++;
                    }
                }

                if (column <=0)
                {
                }
                else
                {
                    if (Zustand[row, column - 1] == true)
                    {
                        neighbors++;
                    }
                }
                if (row >=19 || column <=0)
                {
                }
                else
                {
                    if (Zustand[row + 1, column - 1] == true)
                    {
                        neighbors++;
                    }
                }
                
                
            }
            return neighbors;


        }


        public void Rules(int row, int column)
        {
            var neighbors = GetNeighbors(row, column);

            if (neighbors == 2)
            {
            }

            else if(neighbors == 3)
            {
                SetValue(row, column, true);

            }
            
            else if(neighbors <=1 || neighbors >= 4)
            {
                SetValue(row, column, false);
            }
        }

        public void CalcNextGen()
        {
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    Rules(i, j);

                }
            }
        }

        //public void UpdateGrid(int row, int column)
        //{
            
        //    GetValue(row, column);

            
        //}



    }
}
