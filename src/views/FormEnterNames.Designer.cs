namespace CaroGame
{
    partial class FormEnterNames
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
            this.lblNamePlayer1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxNamePlayer1 = new System.Windows.Forms.TextBox();
            this.txtBoxNamePlayer2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnContinue = new System.Windows.Forms.Button();
            this.btnBackMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNamePlayer1
            // 
            this.lblNamePlayer1.AutoSize = true;
            this.lblNamePlayer1.BackColor = System.Drawing.Color.LimeGreen;
            this.lblNamePlayer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNamePlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamePlayer1.Location = new System.Drawing.Point(57, 132);
            this.lblNamePlayer1.Name = "lblNamePlayer1";
            this.lblNamePlayer1.Size = new System.Drawing.Size(174, 27);
            this.lblNamePlayer1.TabIndex = 0;
            this.lblNamePlayer1.Text = "Tên người chơi 1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LimeGreen;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên người chơi 2";
            // 
            // txtBoxNamePlayer1
            // 
            this.txtBoxNamePlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNamePlayer1.Location = new System.Drawing.Point(247, 130);
            this.txtBoxNamePlayer1.Name = "txtBoxNamePlayer1";
            this.txtBoxNamePlayer1.Size = new System.Drawing.Size(257, 31);
            this.txtBoxNamePlayer1.TabIndex = 1;
            this.txtBoxNamePlayer1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxNamePlayer1_KeyPress);
            // 
            // txtBoxNamePlayer2
            // 
            this.txtBoxNamePlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNamePlayer2.Location = new System.Drawing.Point(247, 172);
            this.txtBoxNamePlayer2.Name = "txtBoxNamePlayer2";
            this.txtBoxNamePlayer2.Size = new System.Drawing.Size(257, 31);
            this.txtBoxNamePlayer2.TabIndex = 1;
            this.txtBoxNamePlayer2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxNamePlayer2_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(407, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cờ Caro: Người với Người";
            // 
            // btnContinue
            // 
            this.btnContinue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinue.Location = new System.Drawing.Point(351, 247);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(152, 37);
            this.btnContinue.TabIndex = 3;
            this.btnContinue.Text = "Tiếp tục";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // btnBackMenu
            // 
            this.btnBackMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackMenu.Location = new System.Drawing.Point(57, 247);
            this.btnBackMenu.Name = "btnBackMenu";
            this.btnBackMenu.Size = new System.Drawing.Size(152, 37);
            this.btnBackMenu.TabIndex = 3;
            this.btnBackMenu.Text = "Trở lại Menu";
            this.btnBackMenu.UseVisualStyleBackColor = true;
            this.btnBackMenu.Click += new System.EventHandler(this.btnBackMenu_Click);
            // 
            // FormEnterNames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(569, 323);
            this.Controls.Add(this.btnBackMenu);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxNamePlayer2);
            this.Controls.Add(this.txtBoxNamePlayer1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNamePlayer1);
            this.MaximizeBox = false;
            this.Name = "FormEnterNames";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cờ Caro";
            this.Load += new System.EventHandler(this.FormEnterNames_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNamePlayer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxNamePlayer1;
        private System.Windows.Forms.TextBox txtBoxNamePlayer2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Button btnBackMenu;
    }
}