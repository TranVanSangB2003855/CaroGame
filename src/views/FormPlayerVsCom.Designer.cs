namespace CaroGame
{
    partial class FormPlayerVsCom
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
            this.txtBoxMediumScore2 = new System.Windows.Forms.TextBox();
            this.txtBoxMediumScore1 = new System.Windows.Forms.TextBox();
            this.txtBoxCom = new System.Windows.Forms.TextBox();
            this.txtBoxPlayer = new System.Windows.Forms.TextBox();
            this.btnRedo = new System.Windows.Forms.Button();
            this.pnlChessBoard = new System.Windows.Forms.Panel();
            this.btnUndo = new System.Windows.Forms.Button();
            this.btnBackMenu = new System.Windows.Forms.Button();
            this.btnRule = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBoxMode = new System.Windows.Forms.GroupBox();
            this.radioBtnComFirst = new System.Windows.Forms.RadioButton();
            this.radioBtnPlayerFirst = new System.Windows.Forms.RadioButton();
            this.groupBoxLevel = new System.Windows.Forms.GroupBox();
            this.radioBtnHard = new System.Windows.Forms.RadioButton();
            this.radioBtnMedium = new System.Windows.Forms.RadioButton();
            this.radioBtnEasy = new System.Windows.Forms.RadioButton();
            this.btnRanking = new System.Windows.Forms.Button();
            this.txtBoxHardScore1 = new System.Windows.Forms.TextBox();
            this.txtBoxHardScore2 = new System.Windows.Forms.TextBox();
            this.txtBoxEasyScore1 = new System.Windows.Forms.TextBox();
            this.txtBoxEasyScore2 = new System.Windows.Forms.TextBox();
            this.txtUndoCounter = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBoxMode.SuspendLayout();
            this.groupBoxLevel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBoxMediumScore2
            // 
            this.txtBoxMediumScore2.BackColor = System.Drawing.Color.LimeGreen;
            this.txtBoxMediumScore2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxMediumScore2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxMediumScore2.Location = new System.Drawing.Point(64, 81);
            this.txtBoxMediumScore2.Name = "txtBoxMediumScore2";
            this.txtBoxMediumScore2.ReadOnly = true;
            this.txtBoxMediumScore2.Size = new System.Drawing.Size(51, 32);
            this.txtBoxMediumScore2.TabIndex = 33;
            this.txtBoxMediumScore2.Text = "0";
            this.txtBoxMediumScore2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBoxMediumScore1
            // 
            this.txtBoxMediumScore1.BackColor = System.Drawing.Color.LimeGreen;
            this.txtBoxMediumScore1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxMediumScore1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxMediumScore1.Location = new System.Drawing.Point(64, 43);
            this.txtBoxMediumScore1.Name = "txtBoxMediumScore1";
            this.txtBoxMediumScore1.ReadOnly = true;
            this.txtBoxMediumScore1.Size = new System.Drawing.Size(51, 32);
            this.txtBoxMediumScore1.TabIndex = 34;
            this.txtBoxMediumScore1.Text = "0";
            this.txtBoxMediumScore1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBoxCom
            // 
            this.txtBoxCom.BackColor = System.Drawing.Color.LimeGreen;
            this.txtBoxCom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxCom.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCom.Location = new System.Drawing.Point(22, 214);
            this.txtBoxCom.Name = "txtBoxCom";
            this.txtBoxCom.ReadOnly = true;
            this.txtBoxCom.Size = new System.Drawing.Size(184, 32);
            this.txtBoxCom.TabIndex = 31;
            this.txtBoxCom.Text = "Máy";
            this.txtBoxCom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBoxPlayer
            // 
            this.txtBoxPlayer.BackColor = System.Drawing.Color.LimeGreen;
            this.txtBoxPlayer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxPlayer.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPlayer.Location = new System.Drawing.Point(21, 98);
            this.txtBoxPlayer.Name = "txtBoxPlayer";
            this.txtBoxPlayer.ReadOnly = true;
            this.txtBoxPlayer.Size = new System.Drawing.Size(184, 32);
            this.txtBoxPlayer.TabIndex = 32;
            this.txtBoxPlayer.Text = "Player ";
            this.txtBoxPlayer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnRedo
            // 
            this.btnRedo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnRedo.Location = new System.Drawing.Point(155, 696);
            this.btnRedo.Name = "btnRedo";
            this.btnRedo.Size = new System.Drawing.Size(65, 28);
            this.btnRedo.TabIndex = 29;
            this.btnRedo.Text = "Tiến tới";
            this.btnRedo.UseVisualStyleBackColor = true;
            this.btnRedo.Click += new System.EventHandler(this.btnRedo_Click);
            // 
            // pnlChessBoard
            // 
            this.pnlChessBoard.BackColor = System.Drawing.Color.LimeGreen;
            this.pnlChessBoard.Location = new System.Drawing.Point(225, 23);
            this.pnlChessBoard.Margin = new System.Windows.Forms.Padding(2);
            this.pnlChessBoard.Name = "pnlChessBoard";
            this.pnlChessBoard.Size = new System.Drawing.Size(701, 701);
            this.pnlChessBoard.TabIndex = 27;
            this.pnlChessBoard.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlChessBoard_Paint);
            this.pnlChessBoard.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlChessBoard_MouseClick);
            // 
            // btnUndo
            // 
            this.btnUndo.BackColor = System.Drawing.Color.White;
            this.btnUndo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnUndo.Location = new System.Drawing.Point(155, 663);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(65, 28);
            this.btnUndo.TabIndex = 28;
            this.btnUndo.Text = "Lùi lại";
            this.btnUndo.UseVisualStyleBackColor = false;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // btnBackMenu
            // 
            this.btnBackMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnBackMenu.Location = new System.Drawing.Point(27, 683);
            this.btnBackMenu.Margin = new System.Windows.Forms.Padding(2);
            this.btnBackMenu.Name = "btnBackMenu";
            this.btnBackMenu.Size = new System.Drawing.Size(101, 41);
            this.btnBackMenu.TabIndex = 23;
            this.btnBackMenu.Text = "Trở lại Menu";
            this.btnBackMenu.UseVisualStyleBackColor = true;
            this.btnBackMenu.Click += new System.EventHandler(this.btnBackMenu_Click);
            // 
            // btnRule
            // 
            this.btnRule.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnRule.Location = new System.Drawing.Point(27, 564);
            this.btnRule.Margin = new System.Windows.Forms.Padding(2);
            this.btnRule.Name = "btnRule";
            this.btnRule.Size = new System.Drawing.Size(175, 41);
            this.btnRule.TabIndex = 24;
            this.btnRule.Text = "Luật chơi";
            this.btnRule.UseVisualStyleBackColor = true;
            this.btnRule.Click += new System.EventHandler(this.btnRule_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSave.Location = new System.Drawing.Point(27, 520);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(175, 41);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "Lưu ván cờ";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNewGame
            // 
            this.btnNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnNewGame.Location = new System.Drawing.Point(27, 475);
            this.btnNewGame.Margin = new System.Windows.Forms.Padding(2);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(175, 41);
            this.btnNewGame.TabIndex = 26;
            this.btnNewGame.Text = "Chơi mới";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnExit.Location = new System.Drawing.Point(27, 609);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(55, 41);
            this.btnExit.TabIndex = 22;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBoxMode
            // 
            this.groupBoxMode.Controls.Add(this.radioBtnComFirst);
            this.groupBoxMode.Controls.Add(this.radioBtnPlayerFirst);
            this.groupBoxMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxMode.Location = new System.Drawing.Point(27, 264);
            this.groupBoxMode.Name = "groupBoxMode";
            this.groupBoxMode.Size = new System.Drawing.Size(174, 75);
            this.groupBoxMode.TabIndex = 35;
            this.groupBoxMode.TabStop = false;
            this.groupBoxMode.Text = "Chế độ";
            // 
            // radioBtnComFirst
            // 
            this.radioBtnComFirst.AutoSize = true;
            this.radioBtnComFirst.Checked = true;
            this.radioBtnComFirst.Location = new System.Drawing.Point(6, 22);
            this.radioBtnComFirst.Name = "radioBtnComFirst";
            this.radioBtnComFirst.Size = new System.Drawing.Size(119, 24);
            this.radioBtnComFirst.TabIndex = 1;
            this.radioBtnComFirst.TabStop = true;
            this.radioBtnComFirst.Text = "Máy đi trước";
            this.radioBtnComFirst.UseVisualStyleBackColor = true;
            this.radioBtnComFirst.CheckedChanged += new System.EventHandler(this.radioBtnComFirst_CheckedChanged);
            this.radioBtnComFirst.MouseClick += new System.Windows.Forms.MouseEventHandler(this.radioBtnComFirst_MouseClick);
            // 
            // radioBtnPlayerFirst
            // 
            this.radioBtnPlayerFirst.AutoSize = true;
            this.radioBtnPlayerFirst.Location = new System.Drawing.Point(6, 46);
            this.radioBtnPlayerFirst.Name = "radioBtnPlayerFirst";
            this.radioBtnPlayerFirst.Size = new System.Drawing.Size(131, 24);
            this.radioBtnPlayerFirst.TabIndex = 0;
            this.radioBtnPlayerFirst.Text = "Người đi trước";
            this.radioBtnPlayerFirst.UseVisualStyleBackColor = true;
            this.radioBtnPlayerFirst.Click += new System.EventHandler(this.radioBtnPlayerFirst_Click);
            // 
            // groupBoxLevel
            // 
            this.groupBoxLevel.Controls.Add(this.radioBtnHard);
            this.groupBoxLevel.Controls.Add(this.radioBtnMedium);
            this.groupBoxLevel.Controls.Add(this.radioBtnEasy);
            this.groupBoxLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxLevel.Location = new System.Drawing.Point(27, 352);
            this.groupBoxLevel.Name = "groupBoxLevel";
            this.groupBoxLevel.Size = new System.Drawing.Size(174, 105);
            this.groupBoxLevel.TabIndex = 35;
            this.groupBoxLevel.TabStop = false;
            this.groupBoxLevel.Text = "Độ khó";
            // 
            // radioBtnHard
            // 
            this.radioBtnHard.AutoSize = true;
            this.radioBtnHard.Location = new System.Drawing.Point(6, 75);
            this.radioBtnHard.Name = "radioBtnHard";
            this.radioBtnHard.Size = new System.Drawing.Size(56, 24);
            this.radioBtnHard.TabIndex = 1;
            this.radioBtnHard.Text = "Khó";
            this.radioBtnHard.UseVisualStyleBackColor = true;
            this.radioBtnHard.MouseClick += new System.Windows.Forms.MouseEventHandler(this.radioBtnHard_MouseClick);
            // 
            // radioBtnMedium
            // 
            this.radioBtnMedium.AutoSize = true;
            this.radioBtnMedium.Location = new System.Drawing.Point(6, 51);
            this.radioBtnMedium.Name = "radioBtnMedium";
            this.radioBtnMedium.Size = new System.Drawing.Size(106, 24);
            this.radioBtnMedium.TabIndex = 1;
            this.radioBtnMedium.Text = "Trung bình";
            this.radioBtnMedium.UseVisualStyleBackColor = true;
            this.radioBtnMedium.MouseClick += new System.Windows.Forms.MouseEventHandler(this.radioBtnMedium_MouseClick);
            // 
            // radioBtnEasy
            // 
            this.radioBtnEasy.AutoSize = true;
            this.radioBtnEasy.Checked = true;
            this.radioBtnEasy.Location = new System.Drawing.Point(6, 26);
            this.radioBtnEasy.Name = "radioBtnEasy";
            this.radioBtnEasy.Size = new System.Drawing.Size(49, 24);
            this.radioBtnEasy.TabIndex = 0;
            this.radioBtnEasy.TabStop = true;
            this.radioBtnEasy.Text = "Dễ";
            this.radioBtnEasy.UseVisualStyleBackColor = true;
            this.radioBtnEasy.MouseClick += new System.Windows.Forms.MouseEventHandler(this.radioBtnEasy_MouseClick);
            // 
            // btnRanking
            // 
            this.btnRanking.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnRanking.Location = new System.Drawing.Point(86, 609);
            this.btnRanking.Margin = new System.Windows.Forms.Padding(2);
            this.btnRanking.Name = "btnRanking";
            this.btnRanking.Size = new System.Drawing.Size(115, 41);
            this.btnRanking.TabIndex = 23;
            this.btnRanking.Text = "Bảng xếp hạng";
            this.btnRanking.UseVisualStyleBackColor = true;
            this.btnRanking.Click += new System.EventHandler(this.btnRanking_Click);
            // 
            // txtBoxHardScore1
            // 
            this.txtBoxHardScore1.BackColor = System.Drawing.Color.LimeGreen;
            this.txtBoxHardScore1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxHardScore1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxHardScore1.Location = new System.Drawing.Point(110, 43);
            this.txtBoxHardScore1.Name = "txtBoxHardScore1";
            this.txtBoxHardScore1.ReadOnly = true;
            this.txtBoxHardScore1.Size = new System.Drawing.Size(51, 32);
            this.txtBoxHardScore1.TabIndex = 34;
            this.txtBoxHardScore1.Text = "0";
            this.txtBoxHardScore1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBoxHardScore2
            // 
            this.txtBoxHardScore2.BackColor = System.Drawing.Color.LimeGreen;
            this.txtBoxHardScore2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxHardScore2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxHardScore2.Location = new System.Drawing.Point(110, 81);
            this.txtBoxHardScore2.Name = "txtBoxHardScore2";
            this.txtBoxHardScore2.ReadOnly = true;
            this.txtBoxHardScore2.Size = new System.Drawing.Size(51, 32);
            this.txtBoxHardScore2.TabIndex = 33;
            this.txtBoxHardScore2.Text = "0";
            this.txtBoxHardScore2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBoxEasyScore1
            // 
            this.txtBoxEasyScore1.BackColor = System.Drawing.Color.LimeGreen;
            this.txtBoxEasyScore1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxEasyScore1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxEasyScore1.Location = new System.Drawing.Point(20, 43);
            this.txtBoxEasyScore1.Name = "txtBoxEasyScore1";
            this.txtBoxEasyScore1.ReadOnly = true;
            this.txtBoxEasyScore1.Size = new System.Drawing.Size(51, 32);
            this.txtBoxEasyScore1.TabIndex = 34;
            this.txtBoxEasyScore1.Text = "0";
            this.txtBoxEasyScore1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBoxEasyScore2
            // 
            this.txtBoxEasyScore2.BackColor = System.Drawing.Color.LimeGreen;
            this.txtBoxEasyScore2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxEasyScore2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxEasyScore2.Location = new System.Drawing.Point(20, 81);
            this.txtBoxEasyScore2.Name = "txtBoxEasyScore2";
            this.txtBoxEasyScore2.ReadOnly = true;
            this.txtBoxEasyScore2.Size = new System.Drawing.Size(51, 32);
            this.txtBoxEasyScore2.TabIndex = 33;
            this.txtBoxEasyScore2.Text = "0";
            this.txtBoxEasyScore2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtUndoCounter
            // 
            this.txtUndoCounter.BackColor = System.Drawing.Color.Orange;
            this.txtUndoCounter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUndoCounter.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUndoCounter.Location = new System.Drawing.Point(132, 667);
            this.txtUndoCounter.Name = "txtUndoCounter";
            this.txtUndoCounter.ReadOnly = true;
            this.txtUndoCounter.Size = new System.Drawing.Size(24, 20);
            this.txtUndoCounter.TabIndex = 36;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CaroGame.Properties.Resources.caro_game_thumnail1;
            this.pictureBox1.Location = new System.Drawing.Point(19, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LimeGreen;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtBoxEasyScore2);
            this.panel1.Controls.Add(this.txtBoxHardScore2);
            this.panel1.Controls.Add(this.txtBoxMediumScore2);
            this.panel1.Controls.Add(this.txtBoxEasyScore1);
            this.panel1.Controls.Add(this.txtBoxHardScore1);
            this.panel1.Controls.Add(this.txtBoxMediumScore1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.No;
            this.panel1.Location = new System.Drawing.Point(19, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(189, 158);
            this.panel1.TabIndex = 37;
            // 
            // FormPlayerVsCom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(944, 746);
            this.Controls.Add(this.txtUndoCounter);
            this.Controls.Add(this.groupBoxLevel);
            this.Controls.Add(this.groupBoxMode);
            this.Controls.Add(this.txtBoxCom);
            this.Controls.Add(this.txtBoxPlayer);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRedo);
            this.Controls.Add(this.pnlChessBoard);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.btnRanking);
            this.Controls.Add(this.btnBackMenu);
            this.Controls.Add(this.btnRule);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "FormPlayerVsCom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cờ Caro";
            this.groupBoxMode.ResumeLayout(false);
            this.groupBoxMode.PerformLayout();
            this.groupBoxLevel.ResumeLayout(false);
            this.groupBoxLevel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxMediumScore2;
        private System.Windows.Forms.TextBox txtBoxMediumScore1;
        private System.Windows.Forms.TextBox txtBoxCom;
        private System.Windows.Forms.TextBox txtBoxPlayer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRedo;
        private System.Windows.Forms.Panel pnlChessBoard;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Button btnBackMenu;
        private System.Windows.Forms.Button btnRule;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBoxMode;
        private System.Windows.Forms.RadioButton radioBtnComFirst;
        private System.Windows.Forms.RadioButton radioBtnPlayerFirst;
        private System.Windows.Forms.GroupBox groupBoxLevel;
        private System.Windows.Forms.RadioButton radioBtnHard;
        private System.Windows.Forms.RadioButton radioBtnMedium;
        private System.Windows.Forms.RadioButton radioBtnEasy;
        private System.Windows.Forms.Button btnRanking;
        private System.Windows.Forms.TextBox txtBoxHardScore1;
        private System.Windows.Forms.TextBox txtBoxHardScore2;
        private System.Windows.Forms.TextBox txtBoxEasyScore1;
        private System.Windows.Forms.TextBox txtBoxEasyScore2;
        private System.Windows.Forms.TextBox txtUndoCounter;
        private System.Windows.Forms.Panel panel1;
    }
}