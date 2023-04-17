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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace CaroGame
{
    public partial class FormEnterName : Form
    {
        private List<string> playersList;
        private string playersFilePath;
        private Form formMenu;
        private string selectedPlayer;

        public FormEnterName(Form formMenu)
        {
            InitializeComponent();
            this.formMenu = formMenu;
        }

        private void FormEnterName_Load(object sender, EventArgs e)
        {
            playersList = new List<string>();

            playersFilePath = "Players.txt";

            if (File.Exists(playersFilePath))
            {
                string[] data = MyFile.ReadFile(playersFilePath);
                foreach (string item in data)
                {
                    if(item != null)
                    {
                        playersList.Add(item);
                        this.cbBoxSelectPlayer.Items.Add(item);
                    }
                }
            } else
            {
                MessageBox.Show("Lỗi khi đọc tập tin Players.txt !");
                return;
            }
        }

        private void txtBoxNameNewPlayer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                string str = this.txtBoxNameNewPlayer.Text;
                if (this.cbBoxSelectPlayer.Items.Contains(str))
                {
                    MessageBox.Show("Tên này đã tồn tại !", "Thông báo");
                    return;
                }
                else
                {
                    selectedPlayer = str;
                    File.AppendAllLines(playersFilePath, new string[] {str});
                    Form form = new FormPlayerVsCom(this.formMenu, str);
                    form.Show();
                    updateNewNamePlayer();
                    this.Close();
                }
            }
        }

        private void updateNewNamePlayer()
        {
            string rankingFilePath = "Ranking.txt";

            if (File.Exists(rankingFilePath))
            {
                string str = this.txtBoxNameNewPlayer.Text.Trim() + " " + "0";

                File.AppendAllText(rankingFilePath, str);
            }
            else
            {
                MessageBox.Show("Lỗi khi đọc tập tin Ranking.txt !");
                return;
            }
        }

        private void btnBackMenu_Click(object sender, EventArgs e)
        {
            if(this.txtBoxNameNewPlayer.Text != "")
            {
                DialogResult confirmResult = MessageBox.Show("Bạn muốn trở về Menu chính ?", "Xác nhận", MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    this.formMenu.Visible = true;
                    this.Close();
                }
            } else
            {
                this.formMenu.Visible = true;
                this.Close();
            }
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            if (selectedPlayer == null && this.txtBoxNameNewPlayer.Text == "")
            {
                MessageBox.Show("Vui lòng nhập hoặc chọn tên người chơi !", "Thông báo");
                return;
            } else if(this.txtBoxNameNewPlayer.Text != "")
            {
                File.AppendAllLines(playersFilePath, new string[] { this.txtBoxNameNewPlayer.Text.Trim() });
                updateNewNamePlayer();
            }
            Form form = new FormPlayerVsCom(this.formMenu, (selectedPlayer!=null)?selectedPlayer: this.txtBoxNameNewPlayer.Text);
            form.Show();
            this.Close();
        }

        private void cbBoxSelectPlayer_SelectedValueChanged(object sender, EventArgs e)
        {
            selectedPlayer = this.cbBoxSelectPlayer.SelectedItem.ToString();
        }
    }
}
