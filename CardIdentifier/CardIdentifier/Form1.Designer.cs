namespace CardIdentifier
{
    partial class CardIdForm
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
            this.PromptLbl = new System.Windows.Forms.Label();
            this.KSpdPicBox = new System.Windows.Forms.PictureBox();
            this.JkrPicBox = new System.Windows.Forms.PictureBox();
            this.ASpsPicBox = new System.Windows.Forms.PictureBox();
            this.EightDmdPicBox = new System.Windows.Forms.PictureBox();
            this.TwoClbPicBox = new System.Windows.Forms.PictureBox();
            this.CardNameLbl = new System.Windows.Forms.Label();
            this.ExitBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.KSpdPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JkrPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ASpsPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EightDmdPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TwoClbPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PromptLbl
            // 
            this.PromptLbl.AutoSize = true;
            this.PromptLbl.Location = new System.Drawing.Point(283, 18);
            this.PromptLbl.Name = "PromptLbl";
            this.PromptLbl.Size = new System.Drawing.Size(143, 13);
            this.PromptLbl.TabIndex = 0;
            this.PromptLbl.Text = "Click a Card to See Its Name";
            // 
            // KSpdPicBox
            // 
            this.KSpdPicBox.Image = global::CardIdentifier.Properties.Resources.King_Spades;
            this.KSpdPicBox.Location = new System.Drawing.Point(12, 46);
            this.KSpdPicBox.Name = "KSpdPicBox";
            this.KSpdPicBox.Size = new System.Drawing.Size(92, 115);
            this.KSpdPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.KSpdPicBox.TabIndex = 1;
            this.KSpdPicBox.TabStop = false;
            this.KSpdPicBox.Click += new System.EventHandler(this.KSpdPicBox_Click);
            // 
            // JkrPicBox
            // 
            this.JkrPicBox.Image = global::CardIdentifier.Properties.Resources.Joker_Black;
            this.JkrPicBox.Location = new System.Drawing.Point(154, 46);
            this.JkrPicBox.Name = "JkrPicBox";
            this.JkrPicBox.Size = new System.Drawing.Size(92, 115);
            this.JkrPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.JkrPicBox.TabIndex = 2;
            this.JkrPicBox.TabStop = false;
            this.JkrPicBox.Click += new System.EventHandler(this.JkrPicBox_Click);
            // 
            // ASpsPicBox
            // 
            this.ASpsPicBox.Image = global::CardIdentifier.Properties.Resources.Ace_Spades;
            this.ASpsPicBox.Location = new System.Drawing.Point(306, 46);
            this.ASpsPicBox.Name = "ASpsPicBox";
            this.ASpsPicBox.Size = new System.Drawing.Size(92, 115);
            this.ASpsPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ASpsPicBox.TabIndex = 3;
            this.ASpsPicBox.TabStop = false;
            this.ASpsPicBox.Click += new System.EventHandler(this.ASpsPicBox_Click);
            // 
            // EightDmdPicBox
            // 
            this.EightDmdPicBox.Image = global::CardIdentifier.Properties.Resources._8_Diamonds;
            this.EightDmdPicBox.Location = new System.Drawing.Point(450, 46);
            this.EightDmdPicBox.Name = "EightDmdPicBox";
            this.EightDmdPicBox.Size = new System.Drawing.Size(92, 115);
            this.EightDmdPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.EightDmdPicBox.TabIndex = 4;
            this.EightDmdPicBox.TabStop = false;
            this.EightDmdPicBox.Click += new System.EventHandler(this.EightDmdPicBox_Click);
            // 
            // TwoClbPicBox
            // 
            this.TwoClbPicBox.Image = global::CardIdentifier.Properties.Resources._2_Clubs;
            this.TwoClbPicBox.Location = new System.Drawing.Point(583, 46);
            this.TwoClbPicBox.Name = "TwoClbPicBox";
            this.TwoClbPicBox.Size = new System.Drawing.Size(92, 115);
            this.TwoClbPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.TwoClbPicBox.TabIndex = 5;
            this.TwoClbPicBox.TabStop = false;
            this.TwoClbPicBox.Click += new System.EventHandler(this.TwoClbPicBox_Click);
            // 
            // CardNameLbl
            // 
            this.CardNameLbl.AutoSize = true;
            this.CardNameLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CardNameLbl.Location = new System.Drawing.Point(12, 178);
            this.CardNameLbl.MinimumSize = new System.Drawing.Size(660, 25);
            this.CardNameLbl.Name = "CardNameLbl";
            this.CardNameLbl.Size = new System.Drawing.Size(660, 25);
            this.CardNameLbl.TabIndex = 6;
            this.CardNameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(306, 216);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(75, 23);
            this.ExitBtn.TabIndex = 7;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // CardIdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 251);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.CardNameLbl);
            this.Controls.Add(this.TwoClbPicBox);
            this.Controls.Add(this.EightDmdPicBox);
            this.Controls.Add(this.ASpsPicBox);
            this.Controls.Add(this.JkrPicBox);
            this.Controls.Add(this.KSpdPicBox);
            this.Controls.Add(this.PromptLbl);
            this.Name = "CardIdForm";
            this.Text = "Card Identifier";
            ((System.ComponentModel.ISupportInitialize)(this.KSpdPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JkrPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ASpsPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EightDmdPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TwoClbPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PromptLbl;
        private System.Windows.Forms.PictureBox KSpdPicBox;
        private System.Windows.Forms.PictureBox JkrPicBox;
        private System.Windows.Forms.PictureBox ASpsPicBox;
        private System.Windows.Forms.PictureBox EightDmdPicBox;
        private System.Windows.Forms.PictureBox TwoClbPicBox;
        private System.Windows.Forms.Label CardNameLbl;
        private System.Windows.Forms.Button ExitBtn;
    }
}

