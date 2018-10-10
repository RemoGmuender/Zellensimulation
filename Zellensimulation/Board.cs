using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zellensimulation
{
    public class Board
    {
        

        int Gen = 0;
        public int GetGen()
        {
            return Gen;
        }
        public void SetGen()
        {
            Gen = 0;
        }


        private bool[,] Zustand = null;
        private int _dimension;

        public Board(int dimension)
        {
            _dimension = 20;
            Zustand = new bool[_dimension, _dimension];
        }
        
        public int Dimension
        {
            get
            {
                return _dimension;
            }
        }
        

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
            if (row >= 0 && row < _dimension && column >= 0 && column < _dimension)
            {
                if (row <= 0 || column >= _dimension -1)
                {
                }
                else
                {
                    if (Zustand[row - 1, column + 1] == true)
                    {
                        neighbors++;
                    }
                }

                if (column >=_dimension -1)
                {

                }
                else
                {
                    if (Zustand[row, column + 1] == true)
                    {
                        neighbors++;
                    }
                }

                if (row >= _dimension -1 || column >=_dimension -1)
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

                if (row >= _dimension -1)
                {
                }
                else
                {
                    if (Zustand[row + 1, column] == true)
                    {
                        neighbors++;
                    }
                }

                if (row <= 0 || column <= 0)
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
                if (row >= _dimension -1 || column <=0)
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


        public void Rules(int row, int column, bool[,] zustandNextGen)
        {
            var neighbors = GetNeighbors(row, column);
            

            if (neighbors == 2)
            {
                if (Zustand[row, column] == true)
                {
                    zustandNextGen[row, column] = true;
                }
                else
                {
                    zustandNextGen[row, column] = false;
                }
            }

            else if(neighbors == 3)
            {
                zustandNextGen[row, column] = true;

            }
            
            else if(neighbors <=1 || neighbors >= 4)
            {
                zustandNextGen[row, column] = false;
            }
            
        }

        public void CalcNextGen()
        {
            Gen++;
           
            bool[,] zustandNextGen = new bool[_dimension, _dimension];
            for (int i = 0; i < _dimension; i++)
            {
                for (int j = 0; j < _dimension; j++)
                {
                    Rules(i, j, zustandNextGen);
                    
                }
            }
            Zustand = zustandNextGen;
        }
        
        public void Reset()
        {
            for (int i = 0; i < _dimension; i++)
            {
                for (int j = 0; j < _dimension; j++)
                {
                    SetValue(i, j, false);
                }
            }

            SetGen();
            
        }

        public int CountAlive()
        {
            int summeAlive= 0;
            for (int i = 0; i < _dimension; i++)
            {
                for (int j = 0; j < _dimension; j++)
                {
                    if (GetValue(i,j)==true)
                    {
                        summeAlive++;
                    }
                }
            }
            return summeAlive;
        }

        
    }
}
