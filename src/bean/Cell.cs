namespace CaroGame
{
    internal class Cell
    {
        private int _row;
        private int _col;
        private int _owned;

        public int row { get => _row; }
        public int col { get => _col; }
        public int owned { get => _owned; set => _owned = value; }

        public Cell() { }
        
        public Cell(int row, int col, int owned)
        {
            _row = row;
            _col = col;
            _owned = owned;
        }

        public Cell(Cell cell)
        {
            _row = cell.row;
            _col = cell.col;
            _owned = cell.owned;
        }

        public void setLocation(int x, int y)
        {
            _row = x;
            _col = y;
        }
    }
}
