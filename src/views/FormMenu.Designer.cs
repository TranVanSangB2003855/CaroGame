namespace CaroGame
{
    partial class FormMenu
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
            this.btnPvsP = new System.Windows.Forms.Button();
            this.btnPvsC = new System.Windows.Forms.Button();
            this.btnRule = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPvsP
            // 
            this.btnPvsP.BackColor = System.Drawing.Color.LimeGreen;
            this.btnPvsP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPvsP.Location = new System.Drawing.Point(95, 151);
            this.btnPvsP.Name = "btnPvsP";
            this.btnPvsP.Size = new System.Drawing.Size(216, 53);
            this.btnPvsP.TabIndex = 1;
            this.btnPvsP.Text = "Người với Người";
            this.btnPvsP.UseVisualStyleBackColor = false;
            this.btnPvsP.Click += new System.EventHandler(this.btnPvsP_Click);
            // 
            // btnPvsC
            // 
            this.btnPvsC.BackColor = System.Drawing.Color.LimeGreen;
            this.btnPvsC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPvsC.Location = new System.Drawing.Point(95, 210);
            this.btnPvsC.Name = "btnPvsC";
            this.btnPvsC.Size = new System.Drawing.Size(216, 53);
            this.btnPvsC.TabIndex = 1;
            this.btnPvsC.Text = "Người với Máy";
            this.btnPvsC.UseVisualStyleBackColor = false;
            this.btnPvsC.Click += new System.EventHandler(this.btnPvsC_Click);
            // 
            // btnRule
            // 
            this.btnRule.BackColor = System.Drawing.Color.LimeGreen;
            this.btnRule.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRule.Location = new System.Drawing.Point(95, 326);
            this.btnRule.Name = "btnRule";
            this.btnRule.Size = new System.Drawing.Size(216, 53);
            this.btnRule.TabIndex = 1;
            this.btnRule.Text = "Luật chơi";
            this.btnRule.UseVisualStyleBackColor = false;
            this.btnRule.Click += new System.EventHandler(this.btnRule_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.BackColor = System.Drawing.Color.LimeGreen;
            this.btnInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfo.Location = new System.Drawing.Point(95, 385);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(216, 53);
            this.btnInfo.TabIndex = 1;
            this.btnInfo.Text = "Thông tin thêm";
            this.btnInfo.UseVisualStyleBackColor = false;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.LimeGreen;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(95, 444);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(216, 53);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.BackColor = System.Drawing.Color.LimeGreen;
            this.btnOpenFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenFile.Location = new System.Drawing.Point(95, 267);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(216, 53);
            this.btnOpenFile.TabIndex = 1;
            this.btnOpenFile.Text = "Chơi tiếp";
            this.btnOpenFile.UseVisualStyleBackColor = false;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CaroGame.Properties.Resources.caro_thumbnail;
            this.pictureBox2.Location = new System.Drawing.Point(12, 24);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(116, 98);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CaroGame.Properties.Resources.caro_game_thumnail1;
            this.pictureBox1.Location = new System.Drawing.Point(134, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(265, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(413, 514);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnRule);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.btnPvsC);
            this.Controls.Add(this.btnPvsP);
            this.MaximizeBox = false;
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cờ Caro";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnPvsP;
        private System.Windows.Forms.Button btnPvsC;
        private System.Windows.Forms.Button btnRule;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnOpenFile;
    }
}