namespace JokeAndPunchLine
{
    partial class JokeForm
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
            this.ResultLbl = new System.Windows.Forms.Label();
            this.setupBtn = new System.Windows.Forms.Button();
            this.PunchlineLbl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ResultLbl
            // 
            this.ResultLbl.AutoSize = true;
            this.ResultLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ResultLbl.Location = new System.Drawing.Point(28, 24);
            this.ResultLbl.MinimumSize = new System.Drawing.Size(230, 25);
            this.ResultLbl.Name = "ResultLbl";
            this.ResultLbl.Size = new System.Drawing.Size(230, 25);
            this.ResultLbl.TabIndex = 0;
            this.ResultLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // setupBtn
            // 
            this.setupBtn.Location = new System.Drawing.Point(109, 63);
            this.setupBtn.Name = "setupBtn";
            this.setupBtn.Size = new System.Drawing.Size(75, 23);
            this.setupBtn.TabIndex = 1;
            this.setupBtn.Text = "Setup";
            this.setupBtn.UseVisualStyleBackColor = true;
            this.setupBtn.Click += new System.EventHandler(this.setupBtn_Click);
            // 
            // PunchlineLbl
            // 
            this.PunchlineLbl.Location = new System.Drawing.Point(109, 101);
            this.PunchlineLbl.Name = "PunchlineLbl";
            this.PunchlineLbl.Size = new System.Drawing.Size(75, 23);
            this.PunchlineLbl.TabIndex = 2;
            this.PunchlineLbl.Text = "Punch Line";
            this.PunchlineLbl.UseVisualStyleBackColor = true;
            this.PunchlineLbl.Click += new System.EventHandler(this.PunchlineLbl_Click);
            // 
            // JokeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 137);
            this.Controls.Add(this.PunchlineLbl);
            this.Controls.Add(this.setupBtn);
            this.Controls.Add(this.ResultLbl);
            this.Name = "JokeForm";
            this.Text = "Joke and Punch Line";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ResultLbl;
        private System.Windows.Forms.Button setupBtn;
        private System.Windows.Forms.Button PunchlineLbl;
    }
}

