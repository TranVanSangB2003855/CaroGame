namespace CaroGame
{
    partial class FormEnterName
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
            this.btnBackMenu = new System.Windows.Forms.Button();
            this.btnContinue = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxNameNewPlayer = new System.Windows.Forms.TextBox();
            this.lblSelectPlayer = new System.Windows.Forms.Label();
            this.lblNewPlayer = new System.Windows.Forms.Label();
            this.cbBoxSelectPlayer = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnBackMenu
            // 
            this.btnBackMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackMenu.Location = new System.Drawing.Point(61, 244);
            this.btnBackMenu.Name = "btnBackMenu";
            this.btnBackMenu.Size = new System.Drawing.Size(152, 37);
            this.btnBackMenu.TabIndex = 9;
            this.btnBackMenu.Text = "Trở lại Menu";
            this.btnBackMenu.UseVisualStyleBackColor = true;
            this.btnBackMenu.Click += new System.EventHandler(this.btnBackMenu_Click);
            // 
            // btnContinue
            // 
            this.btnContinue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinue.Location = new System.Drawing.Point(355, 244);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(152, 37);
            this.btnContinue.TabIndex = 10;
            this.btnContinue.Text = "Tiếp tục";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(91, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(379, 37);
            this.label2.TabIndex = 8;
            this.label2.Text = "Cờ Caro: Người với Máy";
            // 
            // txtBoxNameNewPlayer
            // 
            this.txtBoxNameNewPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNameNewPlayer.Location = new System.Drawing.Point(251, 127);
            this.txtBoxNameNewPlayer.Name = "txtBoxNameNewPlayer";
            this.txtBoxNameNewPlayer.Size = new System.Drawing.Size(257, 31);
            this.txtBoxNameNewPlayer.TabIndex = 7;
            this.txtBoxNameNewPlayer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxNameNewPlayer_KeyPress);
            // 
            // lblSelectPlayer
            // 
            this.lblSelectPlayer.AutoSize = true;
            this.lblSelectPlayer.BackColor = System.Drawing.Color.LimeGreen;
            this.lblSelectPlayer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSelectPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectPlayer.Location = new System.Drawing.Point(61, 171);
            this.lblSelectPlayer.Name = "lblSelectPlayer";
            this.lblSelectPlayer.Size = new System.Drawing.Size(171, 27);
            this.lblSelectPlayer.TabIndex = 4;
            this.lblSelectPlayer.Text = "Chọn tên sẵn có";
            // 
            // lblNewPlayer
            // 
            this.lblNewPlayer.AutoSize = true;
            this.lblNewPlayer.BackColor = System.Drawing.Color.LimeGreen;
            this.lblNewPlayer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNewPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPlayer.Location = new System.Drawing.Point(61, 129);
            this.lblNewPlayer.Name = "lblNewPlayer";
            this.lblNewPlayer.Size = new System.Drawing.Size(141, 27);
            this.lblNewPlayer.TabIndex = 5;
            this.lblNewPlayer.Text = "Nhập tên mới";
            // 
            // cbBoxSelectPlayer
            // 
            this.cbBoxSelectPlayer.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBoxSelectPlayer.FormattingEnabled = true;
            this.cbBoxSelectPlayer.Location = new System.Drawing.Point(251, 170);
            this.cbBoxSelectPlayer.Name = "cbBoxSelectPlayer";
            this.cbBoxSelectPlayer.Size = new System.Drawing.Size(257, 31);
            this.cbBoxSelectPlayer.TabIndex = 11;
            this.cbBoxSelectPlayer.SelectedValueChanged += new System.EventHandler(this.cbBoxSelectPlayer_SelectedValueChanged);
            // 
            // FormEnterName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(569, 323);
            this.Controls.Add(this.cbBoxSelectPlayer);
            this.Controls.Add(this.btnBackMenu);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxNameNewPlayer);
            this.Controls.Add(this.lblSelectPlayer);
            this.Controls.Add(this.lblNewPlayer);
            this.MaximizeBox = false;
            this.Name = "FormEnterName";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cờ Caro";
            this.Load += new System.EventHandler(this.FormEnterName_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBackMenu;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxNameNewPlayer;
        private System.Windows.Forms.Label lblSelectPlayer;
        private System.Windows.Forms.Label lblNewPlayer;
        private System.Windows.Forms.ComboBox cbBoxSelectPlayer;
    }
}