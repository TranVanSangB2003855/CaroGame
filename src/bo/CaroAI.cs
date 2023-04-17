using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.AxHost;

namespace CaroGame
{
    internal class CaroAI
    {
        private int _nextX;
        private int _nextY;
        private State _root;
        private Heuristic _heuristic;
        private int MAX_DEPTH;
        private bool _comFirst;

        public CaroAI(State root, int MAX_DEPTH, int MAX_NUM_OF_HIGHEST_CELL_LIST, bool comFirst)
        {
            _root = root;
            this.MAX_DEPTH = MAX_DEPTH;
            _heuristic = new Heuristic(MAX_NUM_OF_HIGHEST_CELL_LIST);
            this._comFirst = comFirst;
        }

        public bool comFirst { get => _comFirst; }
        public int nextX { get => _nextX; }
        public int nextY { get => _nextY; }

        public void update(int x, int y, int value)
        {
            _root.update(x, y, value);
        }

        public void reset()
        {
            _root = new State();
        }

        public int CheckResult()
        {
            return _root.CheckResult();
        }
        public void nextStep()
        {
            int COM_MOVE = (this._comFirst ? Value.BLACK_MOVE : Value.WHITE_MOVE);
            int PLAYER_MOVE = (Value.WHITE_MOVE + Value.BLACK_MOVE) - COM_MOVE;
            EvalCell choice = new EvalCell();
            long currentValue = this._comFirst ? Int16.MinValue : Int16.MaxValue;
            State remState = new State(_root.getState());
            _heuristic.evaluateEachCell(remState, COM_MOVE);
            List<EvalCell> cells = _heuristic.getOptimalCellList();
            Console.WriteLine("MAX_DEPTH: {0} || Length_List: {1}", MAX_DEPTH, cells.Count);
            if (MAX_DEPTH == Value.MAX_DEPTH_EASY)
            {
                Random random = new Random();
                int cellRandom = random.Next(0, cells.Count);
                _nextX = cells[cellRandom].getRow();
                _nextY = cells[cellRandom].getCol();
                return;
            }
            EvalCell preventiveCell = new EvalCell(cells[0]);
            foreach (EvalCell cell in cells)
            {
                remState.update(cell.getRow(), cell.getCol(), COM_MOVE);
                long temt = alphaBeta(remState, currentValue, PLAYER_MOVE, 1);
                remState.update(cell.getRow(), cell.getCol(), 0);
                if ((temt > currentValue && this._comFirst) || (temt < currentValue && !this._comFirst))
                {
                    currentValue = temt;
                    choice = new EvalCell(cell);
                }
            }
            if ((currentValue == Int16.MinValue && this._comFirst) || (currentValue == Int16.MaxValue && !this._comFirst))
            {
                Console.WriteLine("Sử dụng nút dự phòng");
                _nextX = preventiveCell.getRow();
                _nextY = preventiveCell.getCol();
            }
            else
            {
                Console.WriteLine(currentValue);
                _nextX = choice.getRow();
                _nextY = choice.getCol();
            }
        }

        public long alphaBeta(State state, long V_p, int turn, int dept)
        {
            State remState = new State(state.getState());
            if (remState.CheckResult() != 2 || dept >= MAX_DEPTH)
                return _heuristic.evaluateState(remState);

            long V_q;
            if (turn == Value.BLACK_MOVE) V_q = Int16.MinValue;
            else V_q = Int16.MaxValue;

            _heuristic.evaluateEachCell(remState, turn);
            List<EvalCell> cells = _heuristic.getOptimalCellList();
            foreach (EvalCell cell in cells)
            {
                int row = cell.getRow();
                int col = cell.getCol();

                if (turn == Value.BLACK_MOVE)
                {
                    remState.update(row, col, Value.BLACK_MOVE);
                    V_q = max(alphaBeta(remState, V_q, 3 - turn, dept + 1), V_q);
                    remState.update(row, col, 0);
                    if (V_p <= V_q) return V_q;
                }
                else
                {
                    remState.update(row, col, Value.WHITE_MOVE);
                    V_q = min(alphaBeta(remState, V_q, 3 - turn, dept + 1), V_q);
                    remState.update(row, col, 0);
                    if (V_p >= V_q) return V_q;
                }
            }
            return V_q;
        }

        public long max(long a, long b)
        {
            return (a > b) ? a : b;
        }

        public long min(long a, long b)
        {
            return (a < b) ? a : b;
        }

        public void printChessBoard(State state, int dept)
        {
            int[,] x = state.getState();
            Console.WriteLine();
            for (int k = 0; k < dept; k++) Console.Write("\t");
            Console.WriteLine("ChessBoard [dept = " + dept + "]: ");
            for (int i = 0; i < Value.SIZE; i++)
            {
                for (int k = 0; k < dept; k++) Console.Write("\t");
                for (int j = 0; j < Value.SIZE; j++)
                {
                    Console.Write(x[i, j] + " ");
                }
                Console.WriteLine();
            }
        }


    }
}
