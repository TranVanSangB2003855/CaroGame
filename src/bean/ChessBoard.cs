using System.Drawing;

namespace CaroGame
{
    internal class ChessBoard
    {
        public static void DrawChessBoard(Graphics g)
        {
            for (int i = 0; i <= Value.SIZE; i++)
            {
                g.DrawLine(Value.PEN, i * Value.CELL_WIDTH, 0, i * Value.CELL_WIDTH, Value.SIZE * Value.CELL_HEIGHT);
            }

            for (int j = 0; j <= Value.SIZE; j++)
            {
                g.DrawLine(Value.PEN, 0, j * Value.CELL_HEIGHT, Value.SIZE * Value.CELL_WIDTH, j * Value.CELL_HEIGHT);
            }
        }

        public static void DrawChessMan(Graphics g, int row, int col, SolidBrush sb)
        {
            g.FillEllipse(sb, col * Value.CELL_WIDTH + 2, row * Value.CELL_HEIGHT + 2, Value.CELL_WIDTH - 4, Value.CELL_HEIGHT - 4);
        }

        public static void RemoveChessMan(Graphics g, int row, int col, SolidBrush sb)
        {
            g.FillRectangle(sb, col * Value.CELL_WIDTH + 1, row * Value.CELL_HEIGHT + 1, Value.CELL_WIDTH - 1, Value.CELL_HEIGHT - 1);
        }

        public static void markLastSelectedCell(Graphics g, int row, int col, SolidBrush sb)
        {
            g.FillRectangle(Value.SB_ORANGE, col * Value.CELL_WIDTH + 1, row * Value.CELL_HEIGHT + 1, Value.CELL_WIDTH - 1, Value.CELL_HEIGHT - 1);
            g.FillEllipse(sb, col * Value.CELL_WIDTH + 2, row * Value.CELL_HEIGHT + 2, Value.CELL_WIDTH - 4, Value.CELL_HEIGHT - 4);
        }

        public static void removeMarkedCell(Graphics g, int row, int col, SolidBrush sb)
        {
            g.FillRectangle(Value.SB_GREEN, col * Value.CELL_WIDTH + 1, row * Value.CELL_HEIGHT + 1, Value.CELL_WIDTH - 1, Value.CELL_HEIGHT - 1);
            g.FillEllipse(sb, col * Value.CELL_WIDTH + 2, row * Value.CELL_HEIGHT + 2, Value.CELL_WIDTH - 4, Value.CELL_HEIGHT - 4);
        }
    }
}
