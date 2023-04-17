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
    public partial class FormEnterNames : Form
    {
        Form formMenu;
        private const int SC_CLOSE = 0xF060;
        private const int WM_SYSCOMMAND = 0x0112;

        public FormEnterNames(Form formMenu)
        {
            InitializeComponent();
            this.formMenu = formMenu;
        }

        protected override void WndProc(ref Message msg)
        {
            if (msg.Msg == WM_SYSCOMMAND && msg.WParam.ToInt32() == SC_CLOSE)
            {
                this.btnBackMenu_Click(null,null);
            }
            else
            {
                base.WndProc(ref msg);
            }
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            if(this.txtBoxNamePlayer1.Text != "" && this.txtBoxNamePlayer2.Text != "")
            {
                if (this.txtBoxNamePlayer1.Text == this.txtBoxNamePlayer2.Text)
                    MessageBox.Show("Vui lòng nhập tên 2 người chơi khác nhau !");
                else if (this.txtBoxNamePlayer1.Text.Length >13 || this.txtBoxNamePlayer2.Text.Length > 13)
                    MessageBox.Show("Vui lòng nhập tên không quá 13 ký tự !");
                else
                {
                    Form formPlayerVsPlayer = new FormPlayerVsPlayer(this.formMenu, this.txtBoxNamePlayer1.Text, this.txtBoxNamePlayer2.Text);
                    formPlayerVsPlayer.Show();
                    this.Close();
                }
            } else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên 2 người chơi !");
            }
        }

        private void btnBackMenu_Click(object sender, EventArgs e)
        {
            if (this.txtBoxNamePlayer1.Text != "" || this.txtBoxNamePlayer2.Text != "")
            {
                DialogResult confirmResult = MessageBox.Show("Bạn muốn trở về Menu chính ?", "Xác nhận", MessageBoxButtons.YesNo);

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

        private void FormEnterNames_Load(object sender, EventArgs e)
        {
            this.txtBoxNamePlayer1.Select();
        }

        private void txtBoxNamePlayer2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnContinue_Click(null, null);
            }
        }

        private void txtBoxNamePlayer1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.txtBoxNamePlayer2.Select();
            }
        }
    }
}
