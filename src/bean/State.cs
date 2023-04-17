using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaroGame
{
    internal class State
    {
        private int[,] _cell;
        private Stack<Cell> _moveSteps;

        public State()
        {
            _cell = new int[Value.SIZE,Value.SIZE];
            _moveSteps= new Stack<Cell>();
            for(int i = 0; i < Value.SIZE; i++)
                for(int j = 0; j < Value.SIZE; j++)
                    _cell[i, j] = 0;
        }

        public State(int[,] cell)
        {
            _cell = new int[Value.SIZE, Value.SIZE];
            _moveSteps = new Stack<Cell>();
            for (int i = 0; i < Value.SIZE; i++)
                for (int j = 0; j < Value.SIZE; j++)
                {
                    _cell[i, j] = cell[i,j];
                    if (_cell[i,j] != 0)
                        _moveSteps.Push(new Cell(i, j, _cell[i,j]));
                }
        }

        public void update(int row, int col, int onwed)
        {
            _cell[row,col] = onwed;

            if(onwed != 0)
                _moveSteps.Push(new Cell(row, col, onwed));
            else // Undo Only
            {
                if(_moveSteps.Count >0)
                    _moveSteps.Pop();
            }
        }

        public bool hasOwned(int row, int col)
        {
            if (row >= 0 && row < Value.SIZE && col >= 0 && col < Value.SIZE)
                if (_cell[row,col] == 0) return false;
            return true;
        }

        public int getCell(int row, int col)
        {
            return _cell[row,col];
        }

        public int[,] getState()
        {
            return _cell;
        }

        // Chưa kết thúc: 2 || (Xét quân đen) Win: 1 | Loss: -1 | Draw: 0
        public int CheckResult()
        {
            if (_moveSteps.Count == Value.SIZE * Value.SIZE)
                return 0;

            int[] lineX = new int[4] { 1, 1, 0, 1 };
            int[] lineY = new int[4] { 0, 1, 1, -1 };

            foreach (Cell cell in _moveSteps)
            {
                for (int i = 0; i < 4; i++)
                {
                    int count = 1;
                    for (int j = 1; j <= 4; j++)
                    {
                        int posRow = cell.row + lineX[i] * j;
                        int posCol = cell.col + lineY[i] * j;

                        if (posRow < 0 || posCol < 0 || posRow >= Value.SIZE || posCol >= Value.SIZE)
                            break;

                        if (_cell[posRow, posCol] == cell.owned) count++;
                        else break;
                    }
                    if (count == 5)
                    {
                        int block = 0;
                        for (int j = 0; j < 2; j++)
                        {
                            int posRow = cell.row + lineX[i] * (j == 0 ? -1 : 5);
                            int posCol = cell.col + lineY[i] * (j == 0 ? -1 : 5);
                            if (posRow < 0 || posCol < 0 || posRow >= Value.SIZE || posCol >= Value.SIZE)
                                continue;
                            if (_cell[posRow, posCol] == 3 - cell.owned) block++;
                        }
                        if (block < 2)
                        {
                            return (cell.owned==Value.BLACK_MOVE)?1:-1;
                        }
                    }
                }
            }

            return 2;
        }
    }
}
