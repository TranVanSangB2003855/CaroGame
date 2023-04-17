using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaroGame
{
    public partial class FormPlayerVsCom : Form
    {
        private Form formMenu;
        private CaroChess caroChess;
        private Graphics grs;
        private int MAX_DEPTH;
        private int MAX_NUM_OF_HIGHEST_CELL_LIST;
        private bool preComFirst;
        private float[] score; // 3 phần tử đâu 0, 1, 2 là điểm của Player; 3 phần tử cuối là điểm của Com
        private bool[] level; // easy medium hard
        private const int SC_CLOSE = 0xF060;
        private const int WM_SYSCOMMAND = 0x0112;
        public FormPlayerVsCom(Form formMenu, string namePlayer1)
        {
            InitializeComponent();
            caroChess = new CaroChess();
            grs = pnlChessBoard.CreateGraphics();
            this.formMenu = formMenu;
            this.preComFirst = this.radioBtnComFirst.Checked;
            this.txtBoxPlayer.Text = namePlayer1;
            updateLevel();
            score = new float[6] { 0, 0, 0, 0, 0, 0 };
            //caroChess.StartPlayervsComputer(grs, this.MAX_DEPTH, this.MAX_NUM_OF_HIGHEST_CELL_LIST, radioBtnComFirst.Checked);
            //this.txtUndoCounter.Text = ("(" + caroChess.UndoCounter + ")").ToString();
        }

        public FormPlayerVsCom(Form formMenu, String namePlayer1, String namePlayer2, bool player1First, int mode,
            string[] scores, int[,] moveStepsArr, int numSteps)
        {
            InitializeComponent();
            caroChess = new CaroChess();
            this.formMenu = formMenu;
            grs = pnlChessBoard.CreateGraphics();
            //caroChess.StartPlayervsPlayer(grs, moveStepsArr, numSteps);
            this.txtBoxPlayer.Text = namePlayer1;
            this.txtBoxCom.Text = namePlayer2;
            this.txtBoxEasyScore1.Text = scores[0].ToString();
            this.txtBoxMediumScore1.Text = scores[1].ToString();
            this.txtBoxHardScore1.Text = scores[2].ToString();
            this.txtBoxEasyScore2.Text = scores[3].ToString();
            this.txtBoxMediumScore2.Text = scores[4].ToString();
            this.txtBoxHardScore2.Text = scores[5].ToString();
            this.score = new float[6];
            for (int i = 0; i < 6; i++)
            {
                this.score[i] = float.Parse(scores[i]);
            }
            this.preComFirst = player1First;
            this.radioBtnComFirst.Checked = player1First;
            this.radioBtnPlayerFirst.Checked = !player1First;
            this.level = new bool[3];
            for(int i=0; i<level.Length; i++)
            {
                if (i == mode)
                {
                    level[i] = true;

                }
                else
                {
                    level[i] = false;
                }
            }
            this.radioBtnEasy.Checked = level[0];
            this.radioBtnMedium.Checked = level[1];
            this.radioBtnHard.Checked = level[2];
            updateLevel();
            caroChess.StartPlayervsComputer(grs, moveStepsArr, numSteps, MAX_DEPTH, MAX_NUM_OF_HIGHEST_CELL_LIST, this.radioBtnComFirst.Checked);
            this.txtUndoCounter.Text = ("(" + caroChess.UndoCounter + ")").ToString();
        }

        private void updateLevel()
        {
            if (this.radioBtnEasy.Checked)
            {
                level = new bool[3] { true, false, false };
                this.MAX_DEPTH = Value.MAX_DEPTH_EASY;
                this.MAX_NUM_OF_HIGHEST_CELL_LIST = Value.MAX_NUM_OF_HIGHEST_CELL_LIST_EASY;
            }
            else if (this.radioBtnMedium.Checked)
            {
                level = new bool[3] { false, true, false };
                this.MAX_DEPTH = Value.MAX_DEPTH_MEDIUM;
                this.MAX_NUM_OF_HIGHEST_CELL_LIST = Value.MAX_NUM_OF_HIGHEST_CELL_LIST_MEDIUM;
            }
            else
            {
                level = new bool[3] { false, false, true };
                this.MAX_DEPTH = Value.MAX_DEPTH_HARD;
                this.MAX_NUM_OF_HIGHEST_CELL_LIST = Value.MAX_NUM_OF_HIGHEST_CELL_LIST_HARD;
            }
            Console.WriteLine("MAX_DEPTH :" + this.MAX_DEPTH);
        }

        private void btnBackMenu_Click(object sender, EventArgs e)
        {
            if (caroChess.Ready && caroChess.lastMove()[0] != -1)
            {
                DialogResult confirmResult = MessageBox.Show("Bạn muốn trở về Menu chính (ván đấu chưa được lưu) ?", "Xác nhận", MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    this.formMenu.Visible = true;
                    this.Close();
                }
            }
            else
            {
                this.formMenu.Visible = true;
                this.Close();
            }
        }

        protected override void WndProc(ref Message msg)
        {
            if (msg.Msg == WM_SYSCOMMAND && msg.WParam.ToInt32() == SC_CLOSE)
            {
                DialogResult confirmResult = MessageBox.Show("Bạn muốn thoát trò chơi Caro ?", "Xác nhận", MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            else
            {
                base.WndProc(ref msg);
            }
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {

            this.NewGame();
        }

        private bool NewGame()
        {
            if (caroChess.Ready && caroChess.lastMove()[0] != -1)
            {
                DialogResult confirmResult = MessageBox.Show("Bạn muốn chơi một ván mới ?", "Xác nhận", MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    grs.Clear(pnlChessBoard.BackColor);
                    updateLevel();
                    
                    caroChess.StartPlayervsComputer(grs, this.MAX_DEPTH, this.MAX_NUM_OF_HIGHEST_CELL_LIST, radioBtnComFirst.Checked);
                    this.txtUndoCounter.Text = ("(" + caroChess.UndoCounter + ")").ToString();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                grs.Clear(pnlChessBoard.BackColor);
                updateLevel();
                caroChess.StartPlayervsComputer(grs, this.MAX_DEPTH, this.MAX_NUM_OF_HIGHEST_CELL_LIST, radioBtnComFirst.Checked);
                this.txtUndoCounter.Text = ("(" + caroChess.UndoCounter + ")").ToString();
                return true;
            }
        }

        private void pnlChessBoard_Paint(object sender, PaintEventArgs e)
        {
            caroChess.DrawChessBoard(grs);
            caroChess.RepaintChessMan(grs);
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            caroChess.Undo(grs);
            this.txtUndoCounter.Text = ("(" + caroChess.UndoCounter + ")").ToString();
        }

        private void btnRedo_Click(object sender, EventArgs e)
        {
            caroChess.Redo(grs);
            this.txtUndoCounter.Text = ("(" + caroChess.UndoCounter + ")").ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult confirmResult = MessageBox.Show("Bạn muốn thoát trò chơi Caro ?", "Xác nhận", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void updateScore(bool com, int result)
        {
            if(result==1 && com)
            {
                if(this.MAX_DEPTH == Value.MAX_DEPTH_EASY)
                {
                    this.score[3] += 1;
                    this.txtBoxEasyScore2.Text = this.score[3].ToString();
                }
                if (this.MAX_DEPTH == Value.MAX_DEPTH_MEDIUM)
                {
                    this.score[4] += 1;
                    this.txtBoxMediumScore2.Text = this.score[4].ToString();
                }
                if (this.MAX_DEPTH == Value.MAX_DEPTH_HARD)
                {
                    this.score[5] += 1;
                    this.txtBoxHardScore2.Text = this.score[5].ToString();
                }
            }
            if (result == 1 && !com)
            {
                if (this.MAX_DEPTH == Value.MAX_DEPTH_EASY)
                {
                    this.score[0] += 1;
                    this.txtBoxEasyScore1.Text = this.score[0].ToString();
                }
                if (this.MAX_DEPTH == Value.MAX_DEPTH_MEDIUM)
                {
                    this.score[1] += 1;
                    this.txtBoxMediumScore1.Text = this.score[1].ToString();
                }
                if (this.MAX_DEPTH == Value.MAX_DEPTH_HARD)
                {
                    this.score[2] += 1;
                    this.txtBoxHardScore1.Text = this.score[2].ToString();
                }
            }
            if(result == 0)
            {
                if (this.MAX_DEPTH == Value.MAX_DEPTH_EASY)
                {
                    this.score[0] += 0.5f; this.score[3] += 0.5f;
                    this.txtBoxEasyScore1.Text = this.score[0].ToString();
                    this.txtBoxEasyScore2.Text = this.score[3].ToString();
                }
                if (this.MAX_DEPTH == Value.MAX_DEPTH_MEDIUM)
                {
                    this.score[1] += 0.5f; this.score[4] += 0.5f;
                    this.txtBoxMediumScore1.Text = this.score[1].ToString();
                    this.txtBoxMediumScore2.Text = this.score[4].ToString();
                }
                if (this.MAX_DEPTH == Value.MAX_DEPTH_HARD)
                {
                    this.score[2] += 0.5f; this.score[5] += 0.5f;
                    this.txtBoxHardScore1.Text = this.score[2].ToString();
                    this.txtBoxHardScore2.Text = this.score[5].ToString();
                }
            }
        }

        private int computeScore(int result)
        {
            int lv = 0;
            for (int i = 0; i < 3; i++)
            {
                if (level[i])
                    lv = i;
            }
            if (result == 0) return lv;
            else if (result == 1) return 2*lv +1;
            else if (result == -1) return -1;
            return lv;
        }

        private void updateRankingFile(string namePlayer, int score)
        {
            string rankingFilePath = "Ranking.txt";

            if (File.Exists(rankingFilePath))
            {
                string[] data = MyFile.ReadFile(rankingFilePath);
                int i, length = data.Length;
                for (i = 0; i < length; i++)
                {
                    if (data[i] == "") continue;
                    if (data[i].Contains(namePlayer))
                    {
                        string name = data[i].Substring(0, data[i].LastIndexOf(' '));
                        int preScore = int.Parse(data[i].Substring(data[i].LastIndexOf(' ')));
                        data[i] = name + " " + (preScore + score).ToString();
                        break;
                    }
                }

                File.WriteAllLines(rankingFilePath, data);
            }
            else
            {
                MessageBox.Show("Lỗi khi đọc tập tin Ranking.txt !");
                return;
            }
        }

        private void ShowResult(int result)
        {
            if (this.radioBtnComFirst.Checked)
            {
                caroChess.ShowResult("Máy", this.txtBoxPlayer.Text);
                if(result == 1)
                {
                    updateScore(true, 1);
                    updateRankingFile(this.txtBoxPlayer.Text, computeScore(-1));
                } else if(result == -1)
                {
                    updateScore(false, 1);
                    updateRankingFile(this.txtBoxPlayer.Text, computeScore(1));
                }
            } else
            {
                caroChess.ShowResult(this.txtBoxPlayer.Text, "Máy");
                if (result == 1)
                {
                    updateScore(false, 1);
                    updateRankingFile(this.txtBoxPlayer.Text, computeScore(1));
                }
                else if (result == -1)
                {
                    updateScore(true, 1);
                    updateRankingFile(this.txtBoxPlayer.Text, computeScore(-1));
                }
            }
            if(result == 0)
            {
                updateScore(false, 0);
                updateRankingFile(this.txtBoxPlayer.Text, computeScore(0));
            }
        }

        private void pnlChessBoard_MouseClick(object sender, MouseEventArgs e)
        {
            if (!caroChess.Ready)
                return;
            if (caroChess.PlayChess(e.X, e.Y, grs))
            {
                int result = caroChess.CheckResult();
                if (result != 2) { this.ShowResult(result); this.txtUndoCounter.Text = ("(" + caroChess.UndoCounter + ")").ToString(); }

                if (caroChess.Ready)
                {
                    caroChess.PlayNextMove(grs);
                    result = caroChess.CheckResult();
                    if (result != 2) { this.ShowResult(result); this.txtUndoCounter.Text = ("(" + caroChess.UndoCounter + ")").ToString(); }
                }
            }
        }

        private void radioBtnComFirst_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.radioBtnComFirst.Checked == this.preComFirst) return;
            if (!this.NewGame())
            {
                this.radioBtnComFirst.Checked = this.preComFirst;
                this.radioBtnPlayerFirst.Checked = !this.preComFirst;
            }
            else
            {
                this.preComFirst = this.radioBtnComFirst.Checked;
            }
        }

        private void radioBtnPlayerFirst_Click(object sender, EventArgs e)
        {
            if (!this.radioBtnPlayerFirst.Checked == this.preComFirst) return;
            if (!this.NewGame())
            {
                this.radioBtnComFirst.Checked = this.preComFirst;
                this.radioBtnPlayerFirst.Checked = !this.preComFirst;
            }
            else
            {
                this.preComFirst = this.radioBtnComFirst.Checked;
            }
        }

        private void radioBtnComFirst_CheckedChanged(object sender, EventArgs e)
        {
            //this.comFirst = radioBtnComFirst.Checked;
        }

        private void radioBtnEasy_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.radioBtnEasy.Checked == this.level[0]) return;
            if (!this.NewGame())
            {
                this.radioBtnEasy.Checked = this.level[0];
                this.radioBtnMedium.Checked = this.level[1];
                this.radioBtnHard.Checked = this.level[2];
            }
        }

        private void radioBtnMedium_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.radioBtnMedium.Checked == this.level[1]) return;
            if (!this.NewGame())
            {
                this.radioBtnEasy.Checked = this.level[0];
                this.radioBtnMedium.Checked = this.level[1];
                this.radioBtnHard.Checked = this.level[2];
            }
        }

        private void radioBtnHard_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.radioBtnHard.Checked == this.level[2]) return;
            if (!this.NewGame())
            {
                this.radioBtnEasy.Checked = this.level[0];
                this.radioBtnMedium.Checked = this.level[1];
                this.radioBtnHard.Checked = this.level[2];
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (caroChess.lastMove()[0] == -1)
            {
                MessageBox.Show("Lưu không thành công do chưa có nước đi nào được đánh !", "Thông báo");
                return;
            }
            string[] scores = { this.txtBoxEasyScore1.Text,     this.txtBoxMediumScore1.Text,
                                this.txtBoxHardScore1.Text,     this.txtBoxEasyScore2.Text,
                                this.txtBoxMediumScore2.Text,   this.txtBoxHardScore2.Text};
            string[] names = { this.txtBoxPlayer.Text, "Máy" };
            int[] options = { (this.radioBtnComFirst.Checked ? 1 : 2) ,
                        (level[0]?0:(level[1]?1:2))};
            //MyFile.WriteFile(Value.PvsP, options, scores, names
            //            , caroChess.Root.getState(), caroChess.lastMove());
            MyFile.WriteFile(Value.PvsC, options, scores, names
                       , caroChess.MoveSteps);
        }

        private void btnRanking_Click(object sender, EventArgs e)
        {
            Form form = new FormRanking();
            form.ShowDialog();
        }

        private void btnRule_Click(object sender, EventArgs e)
        {
            Form form = new FormRule();
            form.ShowDialog();
        }
    }
}
