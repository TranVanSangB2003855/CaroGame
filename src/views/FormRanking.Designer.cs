namespace CaroGame
{
    partial class FormRanking
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewRanking = new System.Windows.Forms.DataGridView();
            this.namePlayers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scorePlayers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRanking)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bảng xếp hạng";
            // 
            // dataGridViewRanking
            // 
            this.dataGridViewRanking.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRanking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRanking.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.namePlayers,
            this.scorePlayers});
            this.dataGridViewRanking.Location = new System.Drawing.Point(21, 60);
            this.dataGridViewRanking.Name = "dataGridViewRanking";
            this.dataGridViewRanking.ReadOnly = true;
            this.dataGridViewRanking.Size = new System.Drawing.Size(375, 378);
            this.dataGridViewRanking.TabIndex = 1;
            // 
            // namePlayers
            // 
            this.namePlayers.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.namePlayers.FillWeight = 150F;
            this.namePlayers.HeaderText = "Tên người chơi";
            this.namePlayers.Name = "namePlayers";
            this.namePlayers.ReadOnly = true;
            // 
            // scorePlayers
            // 
            this.scorePlayers.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.scorePlayers.FillWeight = 50F;
            this.scorePlayers.HeaderText = "Điểm";
            this.scorePlayers.Name = "scorePlayers";
            this.scorePlayers.ReadOnly = true;
            // 
            // FormRanking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(416, 450);
            this.Controls.Add(this.dataGridViewRanking);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormRanking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cờ Caro";
            this.Load += new System.EventHandler(this.FormRanking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRanking)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewRanking;
        private System.Windows.Forms.DataGridViewTextBoxColumn namePlayers;
        private System.Windows.Forms.DataGridViewTextBoxColumn scorePlayers;
    }
}