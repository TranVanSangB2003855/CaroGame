namespace CaroGame
{
    partial class FormPlayerVsPlayer
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
            this.btnRedo = new System.Windows.Forms.Button();
            this.pnlChessBoard = new System.Windows.Forms.Panel();
            this.btnUndo = new System.Windows.Forms.Button();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtBoxPlayer1 = new System.Windows.Forms.TextBox();
            this.txtBoxScore1 = new System.Windows.Forms.TextBox();
            this.txtBoxScore2 = new System.Windows.Forms.TextBox();
            this.txtBoxPlayer2 = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRule = new System.Windows.Forms.Button();
            this.btnBackMenu = new System.Windows.Forms.Button();
            this.groupBoxMode = new System.Windows.Forms.GroupBox();
            this.radioBtnPlayer1First = new System.Windows.Forms.RadioButton();
            this.radioBtnPlayer2First = new System.Windows.Forms.RadioButton();
            this.txtUndoCounter = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBoxMode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRedo
            // 
            this.btnRedo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnRedo.Location = new System.Drawing.Point(152, 696);
            this.btnRedo.Name = "btnRedo";
            this.btnRedo.Size = new System.Drawing.Size(65, 28);
            this.btnRedo.TabIndex = 18;
            this.btnRedo.Text = "Tiến tới";
            this.btnRedo.UseVisualStyleBackColor = true;
            this.btnRedo.Click += new System.EventHandler(this.btnRedo_Click);
            // 
            // pnlChessBoard
            // 
            this.pnlChessBoard.BackColor = System.Drawing.Color.LimeGreen;
            this.pnlChessBoard.Location = new System.Drawing.Point(222, 23);
            this.pnlChessBoard.Margin = new System.Windows.Forms.Padding(2);
            this.pnlChessBoard.Name = "pnlChessBoard";
            this.pnlChessBoard.Size = new System.Drawing.Size(701, 701);
            this.pnlChessBoard.TabIndex = 16;
            this.pnlChessBoard.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlChessBoard_Paint);
            this.pnlChessBoard.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlChessBoard_MouseClick);
            // 
            // btnUndo
            // 
            this.btnUndo.BackColor = System.Drawing.Color.White;
            this.btnUndo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnUndo.Location = new System.Drawing.Point(152, 663);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(65, 28);
            this.btnUndo.TabIndex = 17;
            this.btnUndo.Text = "Lùi lại";
            this.btnUndo.UseVisualStyleBackColor = false;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // btnNewGame
            // 
            this.btnNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnNewGame.Location = new System.Drawing.Point(23, 442);
            this.btnNewGame.Margin = new System.Windows.Forms.Padding(2);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(175, 41);
            this.btnNewGame.TabIndex = 15;
            this.btnNewGame.Text = "Chơi mới";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnExit.Location = new System.Drawing.Point(23, 575);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(175, 41);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtBoxPlayer1
            // 
            this.txtBoxPlayer1.BackColor = System.Drawing.Color.LimeGreen;
            this.txtBoxPlayer1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxPlayer1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPlayer1.Location = new System.Drawing.Point(20, 130);
            this.txtBoxPlayer1.Name = "txtBoxPlayer1";
            this.txtBoxPlayer1.ReadOnly = true;
            this.txtBoxPlayer1.Size = new System.Drawing.Size(182, 32);
            this.txtBoxPlayer1.TabIndex = 20;
            this.txtBoxPlayer1.Text = "Player 1";
            this.txtBoxPlayer1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBoxScore1
            // 
            this.txtBoxScore1.BackColor = System.Drawing.Color.LimeGreen;
            this.txtBoxScore1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxScore1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxScore1.Location = new System.Drawing.Point(66, 63);
            this.txtBoxScore1.Name = "txtBoxScore1";
            this.txtBoxScore1.ReadOnly = true;
            this.txtBoxScore1.Size = new System.Drawing.Size(51, 32);
            this.txtBoxScore1.TabIndex = 21;
            this.txtBoxScore1.Text = "0";
            this.txtBoxScore1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBoxScore2
            // 
            this.txtBoxScore2.BackColor = System.Drawing.Color.LimeGreen;
            this.txtBoxScore2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxScore2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxScore2.Location = new System.Drawing.Point(66, 101);
            this.txtBoxScore2.Name = "txtBoxScore2";
            this.txtBoxScore2.ReadOnly = true;
            this.txtBoxScore2.Size = new System.Drawing.Size(51, 32);
            this.txtBoxScore2.TabIndex = 21;
            this.txtBoxScore2.Text = "0";
            this.txtBoxScore2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBoxPlayer2
            // 
            this.txtBoxPlayer2.BackColor = System.Drawing.Color.LimeGreen;
            this.txtBoxPlayer2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxPlayer2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPlayer2.Location = new System.Drawing.Point(20, 253);
            this.txtBoxPlayer2.Name = "txtBoxPlayer2";
            this.txtBoxPlayer2.ReadOnly = true;
            this.txtBoxPlayer2.Size = new System.Drawing.Size(182, 32);
            this.txtBoxPlayer2.TabIndex = 20;
            this.txtBoxPlayer2.Text = "Player 2";
            this.txtBoxPlayer2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSave.Location = new System.Drawing.Point(23, 487);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(175, 41);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Lưu ván cờ";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRule
            // 
            this.btnRule.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnRule.Location = new System.Drawing.Point(23, 531);
            this.btnRule.Margin = new System.Windows.Forms.Padding(2);
            this.btnRule.Name = "btnRule";
            this.btnRule.Size = new System.Drawing.Size(175, 41);
            this.btnRule.TabIndex = 15;
            this.btnRule.Text = "Luật chơi";
            this.btnRule.UseVisualStyleBackColor = true;
            this.btnRule.Click += new System.EventHandler(this.btnRule_Click);
            // 
            // btnBackMenu
            // 
            this.btnBackMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnBackMenu.Location = new System.Drawing.Point(23, 683);
            this.btnBackMenu.Margin = new System.Windows.Forms.Padding(2);
            this.btnBackMenu.Name = "btnBackMenu";
            this.btnBackMenu.Size = new System.Drawing.Size(95, 41);
            this.btnBackMenu.TabIndex = 15;
            this.btnBackMenu.Text = "Trở lại Menu";
            this.btnBackMenu.UseVisualStyleBackColor = true;
            this.btnBackMenu.Click += new System.EventHandler(this.btnBackMenu_Click);
            // 
            // groupBoxMode
            // 
            this.groupBoxMode.Controls.Add(this.radioBtnPlayer1First);
            this.groupBoxMode.Controls.Add(this.radioBtnPlayer2First);
            this.groupBoxMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxMode.Location = new System.Drawing.Point(28, 335);
            this.groupBoxMode.Name = "groupBoxMode";
            this.groupBoxMode.Size = new System.Drawing.Size(174, 75);
            this.groupBoxMode.TabIndex = 36;
            this.groupBoxMode.TabStop = false;
            this.groupBoxMode.Text = "Chế độ";
            // 
            // radioBtnPlayer1First
            // 
            this.radioBtnPlayer1First.AutoSize = true;
            this.radioBtnPlayer1First.Checked = true;
            this.radioBtnPlayer1First.Location = new System.Drawing.Point(6, 22);
            this.radioBtnPlayer1First.Name = "radioBtnPlayer1First";
            this.radioBtnPlayer1First.Size = new System.Drawing.Size(145, 24);
            this.radioBtnPlayer1First.TabIndex = 1;
            this.radioBtnPlayer1First.TabStop = true;
            this.radioBtnPlayer1First.Text = "Người 1 đi trước";
            this.radioBtnPlayer1First.UseVisualStyleBackColor = true;
            this.radioBtnPlayer1First.MouseClick += new System.Windows.Forms.MouseEventHandler(this.radioBtnPlayer1First_MouseClick);
            // 
            // radioBtnPlayer2First
            // 
            this.radioBtnPlayer2First.AutoSize = true;
            this.radioBtnPlayer2First.Location = new System.Drawing.Point(6, 46);
            this.radioBtnPlayer2First.Name = "radioBtnPlayer2First";
            this.radioBtnPlayer2First.Size = new System.Drawing.Size(145, 24);
            this.radioBtnPlayer2First.TabIndex = 0;
            this.radioBtnPlayer2First.Text = "Người 2 đi trước";
            this.radioBtnPlayer2First.UseVisualStyleBackColor = true;
            this.radioBtnPlayer2First.MouseClick += new System.Windows.Forms.MouseEventHandler(this.radioBtnPlayer2First_MouseClick);
            // 
            // txtUndoCounter
            // 
            this.txtUndoCounter.BackColor = System.Drawing.Color.Orange;
            this.txtUndoCounter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUndoCounter.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUndoCounter.Location = new System.Drawing.Point(129, 667);
            this.txtUndoCounter.Name = "txtUndoCounter";
            this.txtUndoCounter.ReadOnly = true;
            this.txtUndoCounter.Size = new System.Drawing.Size(22, 20);
            this.txtUndoCounter.TabIndex = 37;
            this.txtUndoCounter.Text = "(5)";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CaroGame.Properties.Resources.caro_game_thumnail1;
            this.pictureBox1.Location = new System.Drawing.Point(16, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LimeGreen;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtBoxScore2);
            this.panel1.Controls.Add(this.txtBoxScore1);
            this.panel1.Location = new System.Drawing.Point(17, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(187, 193);
            this.panel1.TabIndex = 38;
            // 
            // FormPlayerVsPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(944, 746);
            this.Controls.Add(this.txtUndoCounter);
            this.Controls.Add(this.groupBoxMode);
            this.Controls.Add(this.txtBoxPlayer2);
            this.Controls.Add(this.txtBoxPlayer1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRedo);
            this.Controls.Add(this.pnlChessBoard);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.btnBackMenu);
            this.Controls.Add(this.btnRule);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "FormPlayerVsPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cờ Caro";
            this.groupBoxMode.ResumeLayout(false);
            this.groupBoxMode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRedo;
        private System.Windows.Forms.Panel pnlChessBoard;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtBoxPlayer1;
        private System.Windows.Forms.TextBox txtBoxScore1;
        private System.Windows.Forms.TextBox txtBoxScore2;
        private System.Windows.Forms.TextBox txtBoxPlayer2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRule;
        private System.Windows.Forms.Button btnBackMenu;
        private System.Windows.Forms.GroupBox groupBoxMode;
        private System.Windows.Forms.RadioButton radioBtnPlayer1First;
        private System.Windows.Forms.RadioButton radioBtnPlayer2First;
        private System.Windows.Forms.TextBox txtUndoCounter;
        private System.Windows.Forms.Panel panel1;
    }
}