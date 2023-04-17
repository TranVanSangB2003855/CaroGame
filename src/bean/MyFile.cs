using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Shapes;

namespace CaroGame
{
    internal class MyFile
    {
        public static void WriteFile(int modeGame, int[] options ,int[] scores, String[] names, int[,] cells, int[] lastMove)
        {
            String str = "";
            if (modeGame == Value.PvsC)
                str += "PvsC|";
            else if (modeGame == Value.PvsP)
                str += "PvsP|";

            foreach (int option in options)
            {
                str += option.ToString() + " ";
            }
            str += "|";

            foreach (int score in scores)
            {
                str += score.ToString() + " ";
            }
            str += "|";

            foreach (string name in names)
            {
                str += name + "|";
            }

            for(int i=0; i<Value.SIZE; i++)
            {
                for(int j=0; j<Value.SIZE; j++)
                {
                    if (i == lastMove[0] && j == lastMove[1])
                        cells[i, j] = cells[i, j] * (-1);
                    str += cells[i, j].ToString() + " ";
                }
                str += "|";
            }

            string[] contentFile = str.Split('|');

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.DefaultExt = ".txt";
            saveFileDialog1.Title = "Lưu ván cờ";

            //saveFileDialog1.InitialDirectory = "./bin/Debug/";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllLines(saveFileDialog1.FileName, contentFile);
                MessageBox.Show("Lưu file: " + saveFileDialog1.FileName+" thành công !", "Thông báo");
            }
            saveFileDialog1.Dispose();
            saveFileDialog1 = null;
        }

        public static string[] ReadFile(string path)
        {
            Console.WriteLine("File Name: "+path+"\n");
            return File.ReadAllLines(path);
        }

        public static void WriteFile(int modeGame, int[] options, String[] scores, String[] names, Stack<Cell> moveSteps)
        {
            String str = "";
            if (modeGame == Value.PvsC)
                str += "PvsC|";
            else if (modeGame == Value.PvsP)
                str += "PvsP|";

            foreach (int option in options)
            {
                str += option.ToString() + " ";
            }
            str += "|";

            foreach (string score in scores)
            {
                str += score.ToString() + " ";
            }
            str += "|";

            foreach (string name in names)
            {
                str += name + "|";
            }
            Stack<Cell> moveStepsCp = new Stack<Cell>(moveSteps);
            //Stack<Cell> moveStepsRev = new Stack<Cell>();

            //while (moveStepsCp.Count != 0)
            //{
            //    moveStepsRev.Push(moveStepsCp.Pop());
            //}

            while (moveStepsCp.Count > 0)
            {
                Cell c = moveStepsCp.Pop();
                str += c.row.ToString() + " " + c.col.ToString() + " " + c.owned.ToString();
                if (moveStepsCp.Count != 0)
                    str += '|';
            }

            string[] contentFile = str.Split('|');

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.DefaultExt = ".txt";
            saveFileDialog1.Title = "Lưu ván cờ";

            //saveFileDialog1.InitialDirectory = "./bin/Debug/";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllLines(saveFileDialog1.FileName, contentFile);
                MessageBox.Show("Lưu file: " + saveFileDialog1.FileName + " thành công !", "Thông báo");
            }
            saveFileDialog1.Dispose();
            saveFileDialog1 = null;
        }
    }
}
