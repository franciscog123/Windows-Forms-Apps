namespace Hangman
{
    partial class hangmanFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(hangmanFrm));
            this.GuessBtn = new System.Windows.Forms.Button();
            this.resultLbl = new System.Windows.Forms.Label();
            this.hangmanPicBox = new System.Windows.Forms.PictureBox();
            this.inputTxtBox = new System.Windows.Forms.TextBox();
            this.directionsLbl = new System.Windows.Forms.Label();
            this.yesRadBtn = new System.Windows.Forms.RadioButton();
            this.noRadBtn = new System.Windows.Forms.RadioButton();
            this.newGameGrpBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.hangmanPicBox)).BeginInit();
            this.newGameGrpBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // GuessBtn
            // 
            this.GuessBtn.Font = new System.Drawing.Font("Chiller", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuessBtn.ForeColor = System.Drawing.Color.Red;
            this.GuessBtn.Location = new System.Drawing.Point(39, 240);
            this.GuessBtn.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.GuessBtn.Name = "GuessBtn";
            this.GuessBtn.Size = new System.Drawing.Size(100, 35);
            this.GuessBtn.TabIndex = 1;
            this.GuessBtn.TabStop = false;
            this.GuessBtn.Text = "Guess number";
            this.GuessBtn.UseVisualStyleBackColor = true;
            this.GuessBtn.Click += new System.EventHandler(this.GuessBtn_Click);
            // 
            // resultLbl
            // 
            this.resultLbl.Font = new System.Drawing.Font("Chiller", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLbl.ForeColor = System.Drawing.Color.Red;
            this.resultLbl.Location = new System.Drawing.Point(11, 112);
            this.resultLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.resultLbl.Name = "resultLbl";
            this.resultLbl.Size = new System.Drawing.Size(201, 70);
            this.resultLbl.TabIndex = 2;
            this.resultLbl.Text = "Enter your guess below";
            this.resultLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hangmanPicBox
            // 
            this.hangmanPicBox.Image = global::Hangman.Properties.Resources.Hangman_Game_red;
            this.hangmanPicBox.Location = new System.Drawing.Point(216, 117);
            this.hangmanPicBox.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.hangmanPicBox.Name = "hangmanPicBox";
            this.hangmanPicBox.Size = new System.Drawing.Size(309, 273);
            this.hangmanPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hangmanPicBox.TabIndex = 2;
            this.hangmanPicBox.TabStop = false;
            // 
            // inputTxtBox
            // 
            this.inputTxtBox.Location = new System.Drawing.Point(39, 194);
            this.inputTxtBox.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.inputTxtBox.Name = "inputTxtBox";
            this.inputTxtBox.Size = new System.Drawing.Size(100, 26);
            this.inputTxtBox.TabIndex = 0;
            // 
            // directionsLbl
            // 
            this.directionsLbl.Font = new System.Drawing.Font("Chiller", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.directionsLbl.ForeColor = System.Drawing.Color.Red;
            this.directionsLbl.Location = new System.Drawing.Point(12, 14);
            this.directionsLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.directionsLbl.Name = "directionsLbl";
            this.directionsLbl.Size = new System.Drawing.Size(531, 98);
            this.directionsLbl.TabIndex = 3;
            this.directionsLbl.Text = resources.GetString("directionsLbl.Text");
            this.directionsLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yesRadBtn
            // 
            this.yesRadBtn.AutoSize = true;
            this.yesRadBtn.ForeColor = System.Drawing.Color.White;
            this.yesRadBtn.Location = new System.Drawing.Point(6, 25);
            this.yesRadBtn.Name = "yesRadBtn";
            this.yesRadBtn.Size = new System.Drawing.Size(42, 24);
            this.yesRadBtn.TabIndex = 0;
            this.yesRadBtn.TabStop = true;
            this.yesRadBtn.Text = "Yes";
            this.yesRadBtn.UseVisualStyleBackColor = true;
            this.yesRadBtn.Visible = false;
            this.yesRadBtn.CheckedChanged += new System.EventHandler(this.yesRadBtn_CheckedChanged);
            // 
            // noRadBtn
            // 
            this.noRadBtn.AutoSize = true;
            this.noRadBtn.ForeColor = System.Drawing.Color.White;
            this.noRadBtn.Location = new System.Drawing.Point(6, 55);
            this.noRadBtn.Name = "noRadBtn";
            this.noRadBtn.Size = new System.Drawing.Size(40, 24);
            this.noRadBtn.TabIndex = 1;
            this.noRadBtn.TabStop = true;
            this.noRadBtn.Text = "No";
            this.noRadBtn.UseVisualStyleBackColor = true;
            this.noRadBtn.Visible = false;
            this.noRadBtn.CheckedChanged += new System.EventHandler(this.noRadBtn_CheckedChanged);
            // 
            // newGameGrpBox
            // 
            this.newGameGrpBox.Controls.Add(this.yesRadBtn);
            this.newGameGrpBox.Controls.Add(this.noRadBtn);
            this.newGameGrpBox.ForeColor = System.Drawing.Color.White;
            this.newGameGrpBox.Location = new System.Drawing.Point(39, 297);
            this.newGameGrpBox.Name = "newGameGrpBox";
            this.newGameGrpBox.Size = new System.Drawing.Size(104, 84);
            this.newGameGrpBox.TabIndex = 0;
            this.newGameGrpBox.TabStop = false;
            this.newGameGrpBox.Text = "Try Again?";
            this.newGameGrpBox.Visible = false;
            // 
            // hangmanFrm
            // 
            this.AcceptButton = this.GuessBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(554, 399);
            this.Controls.Add(this.newGameGrpBox);
            this.Controls.Add(this.directionsLbl);
            this.Controls.Add(this.inputTxtBox);
            this.Controls.Add(this.hangmanPicBox);
            this.Controls.Add(this.resultLbl);
            this.Controls.Add(this.GuessBtn);
            this.Font = new System.Drawing.Font("Chiller", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.Name = "hangmanFrm";
            this.Text = "Hangman";
            ((System.ComponentModel.ISupportInitialize)(this.hangmanPicBox)).EndInit();
            this.newGameGrpBox.ResumeLayout(false);
            this.newGameGrpBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GuessBtn;
        private System.Windows.Forms.Label resultLbl;
        private System.Windows.Forms.PictureBox hangmanPicBox;
        private System.Windows.Forms.TextBox inputTxtBox;
        private System.Windows.Forms.Label directionsLbl;
        private System.Windows.Forms.RadioButton yesRadBtn;
        private System.Windows.Forms.RadioButton noRadBtn;
        private System.Windows.Forms.GroupBox newGameGrpBox;
    }
}

