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
    public partial class FormRanking : Form
    {
        private List<string> names;
        private List<string> scores;
        private string rankingFilePath;

        public FormRanking()
        {
            InitializeComponent();
        }

        private void FormRanking_Load(object sender, EventArgs e)
        {
            rankingFilePath = "Ranking.txt";
            names = new List<string>();
            scores = new List<string>();
            if (File.Exists(rankingFilePath))
            {
                string[] data = MyFile.ReadFile(rankingFilePath);
                this.dataGridViewRanking.Controls.Clear();
                foreach (string item in data)
                {
                    if (item == "") continue;
                    string name = item.Substring(0, item.LastIndexOf(' '));
                    string score = item.Substring(item.LastIndexOf(" "));
                    names.Add(name);
                    scores.Add(score);
                }

                this.dataGridViewRanking.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 14);
                this.dataGridViewRanking.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 11);
                
                int length = names.Count;
                for(int i=0; i < length; i++)
                {
                    this.dataGridViewRanking.Rows.Add(names[i], int.Parse(scores[i]));
                }
                this.dataGridViewRanking.Sort(this.dataGridViewRanking.Columns["scorePlayers"], ListSortDirection.Descending);
            }
            else
            {
                MessageBox.Show("Lỗi khi đọc tập tin Ranking.txt !");
                return;
            }
        }

        private void updateRankingFile(string namePlayer, string score)
        {
            rankingFilePath = "Ranking.txt";
            
            if (File.Exists(rankingFilePath))
            {
                string[] data = MyFile.ReadFile(rankingFilePath);
                int i,length = data.Length;
                for (i=0; i<length; i++)
                {
                    if (data[i] == "") continue;
                    if (data[i].Contains(namePlayer))
                    {
                        string name = data[i].Substring(0, data[i].LastIndexOf(' '));
                        int preScore = int.Parse(data[i].Substring(data[i].LastIndexOf(' ')));
                        int addScore = int.Parse(score);
                        data[i] = name + " " + (preScore+addScore).ToString();
                        break;
                    }
                }
                
                if(i == length)
                {
                    string s = namePlayer + " " + score;
                    data.Concat(new string[] { s });
                }

                File.WriteAllLines(rankingFilePath, data);
            }
            else
            {
                MessageBox.Show("Lỗi khi đọc tập tin Ranking.txt !");
                return;
            }
        }
    }
}
