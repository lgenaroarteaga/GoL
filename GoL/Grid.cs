using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoL
{
    public class Grid
    {

        int heigth;
        int width;
        bool[,] cells;
        int count;

        public Grid(int height, int width)
        {
            this.heigth = height;
            this.width = width;
            this.cells = new bool[width, height];
        }

        public void SetCell(int row, int column, bool value) {
            if (this.cells[row, column] != value)
            {
                this.cells[row, column] = value;
                this.count += value ? +1 : -1;
            }
        }
                
        public int CountCells()
        {
            return count;
        }

        public bool IsAlive(int row, int column) {
            return this.cells[row, column];
        }
        public int CountNeighbours(int row, int column) {
            int result = 0;
            if ( row>0 && column>0 && cells[row-1 , column-1]) {
                result++;
            }
            if (row > 0 && column > 0 && cells[row, column - 1]) {
                result++;
            }
            if (row > 0 && column > 0 && cells[row +1, column - 1])
            {
                result++;
            }
            if (row > 0 && column > 0 && cells[row, column - 1])
            {
                result++;
            }
            if (row > 0 && column > 0 && cells[row, column + 1])
            {
                result++;
            }
            if (row > 0 && column > 0 && cells[row + 1, column + 1])
            {
                result++;
            }
            if (row > 0 && column > 0 && cells[row + 1, column])
            {
                result++;
            }
            if (row > 0 && column > 0 && cells[row + 1 , column + 1 ])
            {
                result++;
            }
            return result;
        }

    }

}

