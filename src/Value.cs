using System.Drawing;

namespace CaroGame
{
    public class Value
    {
        public static readonly Pen PEN = new Pen(Color.DarkOliveGreen);

        public static readonly SolidBrush SB_WHITE = new SolidBrush(Color.White);
        public static readonly SolidBrush SB_BLACK = new SolidBrush(Color.Black);
        public static readonly SolidBrush SB_GREEN = new SolidBrush(Color.LimeGreen);
        public static readonly SolidBrush SB_ORANGE = new SolidBrush(Color.Orange);

        public const int SIZE = 20;

        public const int CELL_WIDTH = 35;
        public const int CELL_HEIGHT = 35;

        // MAX UNDO 
        public const int MAX_UNDO = 5;

        // BLACK_MOVE = BLACK_CHESS & WHITE_MOVE = WHITE_CHESS
        public const int BLACK_MOVE = 1;
        public const int WHITE_MOVE = 2;

        // PvsP: PLAYER vs PLAYER & PvsC: PLAYER vs COMPUTER
        public const int PvsP = 1;
        public const int PvsC = 2;

        // EASY: 1/10 || MEDIUM: 6/10 || HARD: 9/15

        // Update: Mode EASY will random a cell in list cells
        public const int MAX_DEPTH_EASY = 1;
        public const int MAX_NUM_OF_HIGHEST_CELL_LIST_EASY = 9;

        // Note(importance): MAX_NUM_OF_HIGHEST_CELL_LIST_EASY != MAX_NUM_OF_HIGHEST_CELL_LIST_MEDIUM
        public const int MAX_DEPTH_MEDIUM = 6;
        public const int MAX_NUM_OF_HIGHEST_CELL_LIST_MEDIUM = 10;

        public const int MAX_DEPTH_HARD = 9;
        public const int MAX_NUM_OF_HIGHEST_CELL_LIST_HARD = 15;
    }
}
