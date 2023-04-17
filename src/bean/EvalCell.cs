using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaroGame
{
    internal class EvalCell
    {
        private Cell _cell;
        private int _value;

        public EvalCell()
        {
            _cell = new Cell();
            _value = 0;
        }

        public EvalCell(Cell cell, int value)
        {
            _cell = new Cell(cell);
            _value = value;
        }

        public EvalCell(int x, int y, int value)
        {
            _cell = new Cell(x, y, 0);
            _value = value;
        }

        public EvalCell(EvalCell cell)
        {
            _cell = new Cell(cell.getCell());
            _value = cell.getValue();
        }

        public Cell getCell()
        {
            return _cell;
        }

        public int getRow()
        {
            return _cell.row;
        }

        public int getCol()
        {
            return _cell.col;
        }

        public int getValue()
        {
            return _value;
        }
    }
}
