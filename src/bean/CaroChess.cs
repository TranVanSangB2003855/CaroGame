using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CaroGame
{
    public enum RESULT
    {
        Draw,
        Black,
        White
    }
    internal class CaroChess
    {
        private int _modeGame;
        private int _turnMove;
        private bool _ready;
        private RESULT _result;
        private State _root;
        private Stack<Cell> _moveSteps;
        private int _undoCounter;
        private Stack<Cell> _undoMoveSteps;
        private CaroAI ai;

        public CaroChess()
        {
            //_arrCell = new Cell[Value.SIZE, Value.SIZE];
            //_root = new State();
            _moveSteps = new Stack<Cell>();
            _modeGame = 0;
            _undoCounter = Value.MAX_UNDO;
            //_undoMoveSteps = new Stack<Cell>();
            //_turnMove = Value.BLACK_MOVE;
        }

        public int ModeGame { get { return _modeGame; } }

        public int UndoCounter { get { return _undoCounter; } }

        public Stack<Cell> MoveSteps { get { return _moveSteps; } }

        public bool Ready { get { return _ready; } }
        public State Root { get { return _root; } }

        public int[] lastMove()
        {
            int[] x;
            if (_moveSteps.Count == 0)
                x = new int[2] { -1, -1 };
            else
            {
                Cell cell = _moveSteps.Peek();
                x = new int[2] { cell.row, cell.col };
            }
            return x;
        }

        public void DrawChessBoard(Graphics g)
        {
            ChessBoard.DrawChessBoard(g);
        }

        public void RepaintChessMan(Graphics g)
        {
            foreach (Cell cell in _moveSteps)
                ChessBoard.DrawChessMan(g, cell.row, cell.col, (cell.owned == Value.BLACK_MOVE) ? Value.SB_BLACK : Value.SB_WHITE);

            if (_moveSteps.Count > 0)
            {
                Cell cell = new Cell(_moveSteps.Peek());
                ChessBoard.markLastSelectedCell(g, cell.row, cell.col, (cell.owned == Value.BLACK_MOVE) ? Value.SB_BLACK : Value.SB_WHITE);
            }
        }

        public bool PlayChess(int MouseX, int MouseY, Graphics g)
        {
            if (MouseX % Value.CELL_WIDTH == 0 || MouseY % Value.CELL_HEIGHT == 0 || !_ready)
                return false;

            int row = MouseY / Value.CELL_HEIGHT;
            int col = MouseX / Value.CELL_WIDTH;

            Console.WriteLine("PlayChess ["+_modeGame+"]: [" + row + ", " + col + "], hasOwned: " + _root.hasOwned(row, col));

            if (_root.hasOwned(row,col))
                return false;

            _root.update(row, col, _turnMove);
            if(_moveSteps.Count > 0)
            {
                Cell cell = new Cell(_moveSteps.Peek());
                ChessBoard.removeMarkedCell(g, cell.row, cell.col, (cell.owned == Value.BLACK_MOVE) ? Value.SB_BLACK : Value.SB_WHITE);
            }
            ChessBoard.markLastSelectedCell(g, row, col, (_turnMove == Value.BLACK_MOVE) ? Value.SB_BLACK : Value.SB_WHITE);

            _undoMoveSteps = new Stack<Cell>();
            _moveSteps.Push(new Cell(row,col,_turnMove));

            if(_modeGame == Value.PvsC)
            {
                ai.update(row, col, _turnMove);
            }

            _turnMove = (Value.WHITE_MOVE + Value.BLACK_MOVE) - _turnMove;

            return true;
        }



        public void StartPlayervsPlayer(Graphics g)
        {
            _moveSteps = new Stack<Cell>();
            _undoMoveSteps = new Stack<Cell>();
            _modeGame = Value.PvsP;
            _turnMove = Value.BLACK_MOVE;
            _root = new State();
            DrawChessBoard(g);
            _ready = true;
            _undoCounter = Value.MAX_UNDO;
        }

        public void StartPlayervsPlayer(Graphics g, int[,] moveStepsArr, int numSteps) //data from file
        {
            _moveSteps = new Stack<Cell>();
            _root = new State();
            for (int i = 0; i < numSteps; i++)
            {
                _moveSteps.Push(new Cell(moveStepsArr[i, 0], moveStepsArr[i, 1], moveStepsArr[i, 2]));
                _root.update(moveStepsArr[i, 0], moveStepsArr[i, 1], moveStepsArr[i, 2]);
            }
            _undoMoveSteps = new Stack<Cell>();
            _undoCounter = Value.MAX_UNDO;
            _modeGame = Value.PvsP;
            _turnMove = (Value.BLACK_MOVE + Value.WHITE_MOVE) - moveStepsArr[numSteps-1,2];
            DrawChessBoard(g);
            RepaintChessMan(g);
            _ready = true;
            CheckResult();
        }
        public void StartPlayervsComputer(Graphics g, int MAX_DEPTH, int MAX_NUM_OF_HIGHEST_CELL_LIST, bool comFirst)
        {
            _moveSteps = new Stack<Cell>();
            _undoMoveSteps = new Stack<Cell>();
            _modeGame = Value.PvsC;
            _turnMove = Value.BLACK_MOVE;
            _root = new State();
            ai = new CaroAI(_root, MAX_DEPTH, MAX_NUM_OF_HIGHEST_CELL_LIST, comFirst);
            DrawChessBoard(g);
            _ready = true;
            _undoCounter = Value.MAX_UNDO;
            if (comFirst)
            {
                PlayNextMove(g);
            }
        }

        public void StartPlayervsComputer(Graphics g, int[,] moveStepsArr, int numSteps, int MAX_DEPTH, int MAX_NUM_OF_HIGHEST_CELL_LIST, bool comFirst) //data from file
        {
            _moveSteps = new Stack<Cell>();
            _root = new State();
            for (int i = 0; i < numSteps; i++)
            {
                _moveSteps.Push(new Cell(moveStepsArr[i, 0], moveStepsArr[i, 1], moveStepsArr[i, 2]));
                _root.update(moveStepsArr[i, 0], moveStepsArr[i, 1], moveStepsArr[i, 2]);
            }
            ai = new CaroAI(_root, MAX_DEPTH, MAX_NUM_OF_HIGHEST_CELL_LIST, comFirst);
            _undoMoveSteps = new Stack<Cell>();
            _undoCounter = Value.MAX_UNDO;
            _modeGame = Value.PvsC;
            _turnMove = (Value.BLACK_MOVE + Value.WHITE_MOVE) - moveStepsArr[numSteps - 1, 2];
            DrawChessBoard(g);
            RepaintChessMan(g);
            _ready = true;
            CheckResult();
            if(_turnMove == (comFirst ? Value.BLACK_MOVE : Value.WHITE_MOVE))
                PlayNextMove(g);
        }

        public void NewGame(Graphics g)
        {
            _moveSteps = new Stack<Cell>();
            _undoMoveSteps = new Stack<Cell>();
            _root = new State();
            _turnMove = Value.BLACK_MOVE;
            _undoCounter = Value.MAX_UNDO;
            DrawChessBoard(g);
            if(_modeGame == Value.PvsC)
            {
                ai.reset();
                PlayNextMove(g);
            }
            _ready = true;
        }

        #region Undo__Redo
        public void Undo(Graphics g)
        {
            if (this._undoCounter <= 0 && this._ready)
                return;
            if(_moveSteps.Count == 0)
                return;
            if(this._ready && !(this._modeGame==Value.PvsC&&ai.comFirst&&_moveSteps.Count == 1))
                this._undoCounter--;
            for(int i=0; i < 2; i++)
            {
                if(_modeGame == Value.PvsP || (_moveSteps.Count > (2-i) && _modeGame == Value.PvsC)){
                    Cell cell = _moveSteps.Pop();
                    _undoMoveSteps.Push(new Cell(cell));
                    _root.update(cell.row, cell.col, 0);
                    ChessBoard.RemoveChessMan(g, cell.row, cell.col, Value.SB_GREEN);
                    if (_moveSteps.Count > 0)
                    {
                        Cell cellTop = new Cell(_moveSteps.Peek());
                        ChessBoard.markLastSelectedCell(g, cellTop.row, cellTop.col, (cellTop.owned == Value.BLACK_MOVE) ? Value.SB_BLACK : Value.SB_WHITE);
                    }
                    if (_modeGame == Value.PvsC)
                        ai.update(cell.row, cell.col, 0);

                    _turnMove = (Value.BLACK_MOVE + Value.WHITE_MOVE) - _turnMove;

                    if (_modeGame == Value.PvsP) break;
                }
            }
        }

        public void Redo(Graphics g)
        {
            if (_undoMoveSteps.Count == 0)
                return;
            if(this._ready)
                this._undoCounter++;
            for (int i=0; i < 2; i++)
            {
                if (_modeGame == Value.PvsP || (_undoMoveSteps.Count > 0 && _modeGame == Value.PvsC))
                {
                    Cell cell = _undoMoveSteps.Pop();
                    if (_moveSteps.Count > 0)
                    {
                        Cell preMarkedCell = _moveSteps.Peek();
                        ChessBoard.removeMarkedCell(g, preMarkedCell.row, preMarkedCell.col, preMarkedCell.owned == Value.BLACK_MOVE ? Value.SB_BLACK : Value.SB_WHITE);
                    }
                    _moveSteps.Push(new Cell(cell));
                    _root.update(cell.row, cell.col, cell.owned);
                    if (_modeGame == Value.PvsC)
                    {
                        ai.update(cell.row, cell.col, cell.owned);
                    }
                    ChessBoard.markLastSelectedCell(g, cell.row, cell.col, cell.owned == Value.BLACK_MOVE ? Value.SB_BLACK : Value.SB_WHITE);
                    _turnMove = (Value.BLACK_MOVE + Value.WHITE_MOVE) - _turnMove;

                    if (_modeGame == Value.PvsP) break;
                }
            }
        }

        #endregion

        #region Kiểm tra Chiến thắng

        public void ShowResult(String player1, String player2)
        {
            switch (_result)
            {
                case RESULT.Draw:
                    MessageBox.Show("Hoà cờ !","Kết quả");
                    break;
                case RESULT.Black:
                    MessageBox.Show(player1+" (quân đen) chiến thắng !", "Kết quả");
                    break;
                case RESULT.White:
                    MessageBox.Show(player2+" (quân trắng) chiến thắng !", "Kết quả");
                    break;
                default:
                    MessageBox.Show("Lỗi !");
                    break;
            }
            _ready = false;
        }

        public int CheckResult()
        {
            switch (_root.CheckResult())
            {
                case 2:
                    return 2;
                case 1:
                    _result = RESULT.Black;
                    _ready = false;
                    return 1;
                case 0:
                    _result = RESULT.Draw;
                    _ready = false;
                    return 0;
                case -1:
                    _result= RESULT.White;
                    _ready = false;
                    return -1;
                default:
                    return 2;
            }
        }
        #endregion

        #region AI
        public void PlayNextMove(Graphics g)
        {
            if (_moveSteps.Count == 0 && ai.comFirst)
            {
                PlayChess(Value.SIZE / 2 * Value.CELL_HEIGHT + 1, Value.SIZE / 2 * Value.CELL_WIDTH + 1, g);
            }
            else
            {
                ai.nextStep();
                //Console.WriteLine("["+ai.nextX+", "+ai.nextY+"]");
                PlayChess(ai.nextY * Value.CELL_WIDTH + 1, ai.nextX * Value.CELL_HEIGHT + 1, g);
            }
        }
        #endregion
    }
}
