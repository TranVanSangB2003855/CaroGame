using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaroGame
{
    public partial class FormPlayerVsPlayer : Form
    {
        private Form formMenu;
        private CaroChess caroChess;
        private Graphics grs;
        private bool player1First;
        private const int SC_CLOSE = 0xF060;
        private const int WM_SYSCOMMAND = 0x0112;

        public FormPlayerVsPlayer(Form formMenu, String namePlayer1, String namePlayer2)
        {
            InitializeComponent();
            caroChess = new CaroChess();
            grs = pnlChessBoard.CreateGraphics();
            //caroChess.StartPlayervsPlayer(grs);
            this.txtBoxPlayer1.Text = namePlayer1;
            this.txtBoxPlayer2.Text = namePlayer2;
            this.player1First = this.radioBtnPlayer1First.Checked;
            this.formMenu = formMenu;
            this.txtUndoCounter.Text = ("("+caroChess.UndoCounter+")").ToString();
        }

        public FormPlayerVsPlayer(Form formMenu, String namePlayer1, String namePlayer2, bool player1First,
            string[] scores, int[,] moveStepsArr, int numSteps)
        {
            InitializeComponent();
            caroChess = new CaroChess();
            this.formMenu = formMenu;
            grs = pnlChessBoard.CreateGraphics();
            caroChess.StartPlayervsPlayer(grs, moveStepsArr, numSteps);
            this.txtBoxPlayer1.Text = namePlayer1;
            this.txtBoxPlayer2.Text = namePlayer2;
            this.txtBoxScore1.Text = scores[0].ToString();
            this.txtBoxScore2.Text = scores[1].ToString();
            this.player1First = player1First;
            this.radioBtnPlayer1First.Checked = player1First;
            this.radioBtnPlayer2First.Checked = !player1First;
            this.txtUndoCounter.Text = ("(" + caroChess.UndoCounter + ")").ToString();
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

        private void btnBackMenu_Click(object sender, EventArgs e)
        {
            if (caroChess.Ready || this.txtBoxScore1.Text != "0" || this.txtBoxScore2.Text != "0")
            {
                String option = (caroChess.Ready) ? " (ván đấu đang diễn ra)" : "";
                DialogResult confirmResult = MessageBox.Show("Bạn muốn trở về Menu chính"+option+" ?", "Xác nhận", MessageBoxButtons.YesNo);

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

        private void pnlChessBoard_Paint(object sender, PaintEventArgs e)
        {
            caroChess.DrawChessBoard(grs);
            caroChess.RepaintChessMan(grs);
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            this.NewGame();
        }

        private void pnlChessBoard_MouseClick(object sender, MouseEventArgs e)
        {
            if (!caroChess.Ready)
                return;
            if (caroChess.PlayChess(e.X, e.Y, grs))
            {
                int result = caroChess.CheckResult();
                if (result != 2)
                {
                    int scorePlayer1 = int.Parse(this.txtBoxScore1.Text.ToString());
                    int scorePlayer2 = int.Parse(this.txtBoxScore2.Text.ToString());
                    if (this.radioBtnPlayer1First.Checked)
                    {
                        caroChess.ShowResult(this.txtBoxPlayer1.Text, this.txtBoxPlayer2.Text);
                        if (result == 1) this.txtBoxScore1.Text = (scorePlayer1+1).ToString();
                        else if (result == -1) this.txtBoxScore2.Text = (scorePlayer2 + 1).ToString();
                    } else
                    {
                        caroChess.ShowResult(this.txtBoxPlayer2.Text, this.txtBoxPlayer1.Text);
                        if (result == -1) this.txtBoxScore1.Text = (scorePlayer1 + 1).ToString();
                        else if (result == 1) this.txtBoxScore2.Text = (scorePlayer2 + 1).ToString();
                    }
                    
                    if (result == 0) {
                        this.txtBoxScore1.Text = (scorePlayer1 + 0.5).ToString();
                        this.txtBoxScore2.Text = (scorePlayer2 + 0.5).ToString();
                    }
                    this.txtUndoCounter.Text = ("").ToString();
                }
            }
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

        private bool NewGame()
        {
            if (caroChess.Ready && caroChess.lastMove()[0]!=-1)
            { 
                DialogResult confirmResult = MessageBox.Show("Bạn muốn chơi một ván mới ?", "Xác nhận", MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    grs.Clear(pnlChessBoard.BackColor);
                    caroChess.StartPlayervsPlayer(grs);
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
                caroChess.StartPlayervsPlayer(grs);
                this.txtUndoCounter.Text = ("(" + caroChess.UndoCounter + ")").ToString();
                return true;
            }
        }

        private void radioBtnPlayer1First_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.radioBtnPlayer1First.Checked == this.player1First) return;
            if(!this.NewGame())
            {
                this.radioBtnPlayer1First.Checked = this.player1First;
                this.radioBtnPlayer2First.Checked = !this.player1First;
            }
            else
            {
                this.player1First = this.radioBtnPlayer1First.Checked;
            }
        }

        private void radioBtnPlayer2First_MouseClick(object sender, MouseEventArgs e)
        {
            if (!this.radioBtnPlayer2First.Checked == this.player1First) return;
            if(!this.NewGame())
            {
                this.radioBtnPlayer1First.Checked = this.player1First;
                this.radioBtnPlayer2First.Checked = !this.player1First;
            } else
            {
                this.player1First = this.radioBtnPlayer1First.Checked;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (caroChess.lastMove()[0] == -1)
            {
                MessageBox.Show("Lưu không thành công do chưa có nước đi nào được đánh !", "Thông báo");
                return;
            }
            string[] scores = { this.txtBoxScore1.Text, this.txtBoxScore2.Text };
            string[] names = { this.txtBoxPlayer1.Text, this.txtBoxPlayer2.Text };
            int[] options = { (player1First ? 1 : 2) };
            //MyFile.WriteFile(Value.PvsP, options, scores, names
            //            , caroChess.Root.getState(), caroChess.lastMove());
            MyFile.WriteFile(Value.PvsP, options, scores, names
                       , caroChess.MoveSteps);
        }

        private void btnRule_Click(object sender, EventArgs e)
        {
            Form form = new FormRule();
            form.ShowDialog();
        }
    }
}
