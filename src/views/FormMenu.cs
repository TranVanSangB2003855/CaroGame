using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaroGame
{
    public partial class FormMenu : Form
    {
        private const int SC_CLOSE = 0xF060;
        private const int WM_SYSCOMMAND = 0x0112;

        public FormMenu()
        {
            InitializeComponent();
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

        private void btnPvsP_Click(object sender, EventArgs e)
        {
            Form formEnterNames = new FormEnterNames(this);
            formEnterNames.Show();
            this.Visible = false;
        }

        private void btnPvsC_Click(object sender, EventArgs e)
        {
            //Form formPlayerVsCom = new FormPlayerVsCom(this);
            //formPlayerVsCom.Show();
            Form formEnterName = new FormEnterName(this);
            formEnterName.Show();
            this.Visible = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult confirmResult = MessageBox.Show("Bạn muốn thoát trò chơi Caro ?", "Xác nhận", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.OpenFileDialog openFileDialog1 = new System.Windows.Forms.OpenFileDialog()
            {
                Filter = "Text files (*.txt)|*.txt",
                Title = "Chọn một tập tin đã lưu ván cờ trước đó"
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string[] data = MyFile.ReadFile(openFileDialog1.FileName);
                    Console.WriteLine(data.Length);
                    if(data.Length > 5)
                    {
                        string[] scores = data[2].Split(' ');
                        int length = data.Length;
                        int[,] moveStep = new int[data.Length-5, 3];

                        for(int i = 5; i< length; i++)
                        {
                            string[] temp = data[i].Split(' ');
                            if(temp.Length < 3)
                            {
                                MessageBox.Show("Tập tin không hợp lệ [1]!", "Thông báo");
                                return;
                            }
                            for (int j = 0; j < 3; j++)
                            {
                                moveStep[i - 5, j] = int.Parse(temp[j]);
                            }
                        }

                        if (data[0] == "PvsP")
                        {
                            Form form = new FormPlayerVsPlayer(this, data[3], data[4], (data[1]=="1")?true:false,
                                scores, moveStep, length-5);
                            
                            form.Show();
                            this.Visible = false;
                        }
                        else if (data[0] == "PvsC")
                        {
                            string[] option = data[1].Split(' ');
                            if(option.Length < 2)
                            {
                                MessageBox.Show("Tập tin không hợp lệ [2]!", "Thông báo");
                                return;
                            }
                            bool comFirst = (int.Parse(option[0]) == 1);
                            int mode = int.Parse(option[1]);
                            Form form = new FormPlayerVsCom(this, data[3], data[4], comFirst, mode,
                                scores, moveStep, length - 5);

                            form.Show();
                            this.Visible = false;
                        }
                    } else
                    {
                        MessageBox.Show("Tập tin không hợp lệ [3]!", "Thông báo");
                        return;
                    }

                } catch(Exception error) {
                    MessageBox.Show("Tập tin không hợp lệ !\nLỗi: "+ error);
                }
            }
        }

        private void btnRule_Click(object sender, EventArgs e)
        {
            Form form = new FormRule();
            form.ShowDialog();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            Form form = new FormAbout();
            form.ShowDialog();
        }
    }
}
