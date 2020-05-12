namespace Calculator
{
    partial class calculatorForm
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
            this.displayTxtBox = new System.Windows.Forms.TextBox();
            this.backspaceBtn = new Calculator.RoundButton();
            this.clearBtn = new Calculator.RoundButton();
            this.equalBtn = new Calculator.RoundButton();
            this.divideBtn = new Calculator.RoundButton();
            this.multiplyBtn = new Calculator.RoundButton();
            this.minusBtn = new Calculator.RoundButton();
            this.plusBtn = new Calculator.RoundButton();
            this.nineBtn = new Calculator.RoundButton();
            this.sixBtn = new Calculator.RoundButton();
            this.threeBtn = new Calculator.RoundButton();
            this.eightBtn = new Calculator.RoundButton();
            this.zeroBtn = new Calculator.RoundButton();
            this.oneBtn = new Calculator.RoundButton();
            this.sevenBtn = new Calculator.RoundButton();
            this.fourBtn = new Calculator.RoundButton();
            this.decimalBtn = new Calculator.RoundButton();
            this.fiveBtn = new Calculator.RoundButton();
            this.twoBtn = new Calculator.RoundButton();
            this.SuspendLayout();
            // 
            // displayTxtBox
            // 
            this.displayTxtBox.Font = new System.Drawing.Font("Perpetua Titling MT", 33F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayTxtBox.ForeColor = System.Drawing.Color.DarkBlue;
            this.displayTxtBox.HideSelection = false;
            this.displayTxtBox.Location = new System.Drawing.Point(28, 22);
            this.displayTxtBox.MaxLength = 10;
            this.displayTxtBox.Multiline = true;
            this.displayTxtBox.Name = "displayTxtBox";
            this.displayTxtBox.ReadOnly = true;
            this.displayTxtBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.displayTxtBox.Size = new System.Drawing.Size(419, 55);
            this.displayTxtBox.TabIndex = 19;
            this.displayTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // backspaceBtn
            // 
            this.backspaceBtn.BackColor = System.Drawing.SystemColors.Control;
            this.backspaceBtn.Font = new System.Drawing.Font("Snap ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backspaceBtn.ForeColor = System.Drawing.Color.DarkBlue;
            this.backspaceBtn.Image = global::Calculator.Properties.Resources.backspace_arrow_1_;
            this.backspaceBtn.Location = new System.Drawing.Point(368, 97);
            this.backspaceBtn.Name = "backspaceBtn";
            this.backspaceBtn.Size = new System.Drawing.Size(79, 56);
            this.backspaceBtn.TabIndex = 37;
            this.backspaceBtn.UseVisualStyleBackColor = false;
            this.backspaceBtn.Click += new System.EventHandler(this.backspaceBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.SystemColors.Control;
            this.clearBtn.Font = new System.Drawing.Font("Perpetua Titling MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.ForeColor = System.Drawing.Color.DarkBlue;
            this.clearBtn.Location = new System.Drawing.Point(368, 153);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(79, 56);
            this.clearBtn.TabIndex = 36;
            this.clearBtn.Text = "C";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // equalBtn
            // 
            this.equalBtn.BackColor = System.Drawing.SystemColors.Control;
            this.equalBtn.Font = new System.Drawing.Font("Perpetua Titling MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equalBtn.ForeColor = System.Drawing.Color.DarkBlue;
            this.equalBtn.Location = new System.Drawing.Point(368, 208);
            this.equalBtn.Name = "equalBtn";
            this.equalBtn.Size = new System.Drawing.Size(79, 115);
            this.equalBtn.TabIndex = 35;
            this.equalBtn.TabStop = false;
            this.equalBtn.Text = "=";
            this.equalBtn.UseVisualStyleBackColor = false;
            this.equalBtn.Click += new System.EventHandler(this.equalBtn_Click);
            // 
            // divideBtn
            // 
            this.divideBtn.BackColor = System.Drawing.SystemColors.Control;
            this.divideBtn.Font = new System.Drawing.Font("Perpetua Titling MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divideBtn.ForeColor = System.Drawing.Color.DarkBlue;
            this.divideBtn.Location = new System.Drawing.Point(283, 97);
            this.divideBtn.Name = "divideBtn";
            this.divideBtn.Size = new System.Drawing.Size(79, 56);
            this.divideBtn.TabIndex = 34;
            this.divideBtn.Text = "/";
            this.divideBtn.UseVisualStyleBackColor = false;
            this.divideBtn.Click += new System.EventHandler(this.divideBtn_Click);
            // 
            // multiplyBtn
            // 
            this.multiplyBtn.BackColor = System.Drawing.SystemColors.Control;
            this.multiplyBtn.Font = new System.Drawing.Font("Perpetua Titling MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplyBtn.ForeColor = System.Drawing.Color.DarkBlue;
            this.multiplyBtn.Location = new System.Drawing.Point(283, 153);
            this.multiplyBtn.Name = "multiplyBtn";
            this.multiplyBtn.Size = new System.Drawing.Size(79, 56);
            this.multiplyBtn.TabIndex = 33;
            this.multiplyBtn.Text = "X";
            this.multiplyBtn.UseVisualStyleBackColor = false;
            this.multiplyBtn.Click += new System.EventHandler(this.multiplyBtn_Click);
            // 
            // minusBtn
            // 
            this.minusBtn.BackColor = System.Drawing.SystemColors.Control;
            this.minusBtn.Font = new System.Drawing.Font("Perpetua Titling MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusBtn.ForeColor = System.Drawing.Color.DarkBlue;
            this.minusBtn.Location = new System.Drawing.Point(283, 208);
            this.minusBtn.Name = "minusBtn";
            this.minusBtn.Size = new System.Drawing.Size(79, 56);
            this.minusBtn.TabIndex = 32;
            this.minusBtn.Text = "-";
            this.minusBtn.UseVisualStyleBackColor = false;
            this.minusBtn.Click += new System.EventHandler(this.minusBtn_Click);
            // 
            // plusBtn
            // 
            this.plusBtn.BackColor = System.Drawing.SystemColors.Control;
            this.plusBtn.Font = new System.Drawing.Font("Perpetua Titling MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusBtn.ForeColor = System.Drawing.Color.DarkBlue;
            this.plusBtn.Location = new System.Drawing.Point(283, 267);
            this.plusBtn.Name = "plusBtn";
            this.plusBtn.Size = new System.Drawing.Size(79, 56);
            this.plusBtn.TabIndex = 31;
            this.plusBtn.TabStop = false;
            this.plusBtn.Text = "+";
            this.plusBtn.UseVisualStyleBackColor = false;
            this.plusBtn.Click += new System.EventHandler(this.plusBtn_Click);
            // 
            // nineBtn
            // 
            this.nineBtn.BackColor = System.Drawing.SystemColors.Control;
            this.nineBtn.Font = new System.Drawing.Font("Perpetua Titling MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nineBtn.ForeColor = System.Drawing.Color.DarkBlue;
            this.nineBtn.Location = new System.Drawing.Point(198, 97);
            this.nineBtn.Name = "nineBtn";
            this.nineBtn.Size = new System.Drawing.Size(79, 56);
            this.nineBtn.TabIndex = 30;
            this.nineBtn.Text = "9";
            this.nineBtn.UseVisualStyleBackColor = false;
            this.nineBtn.Click += new System.EventHandler(this.nineBtn_Click);
            // 
            // sixBtn
            // 
            this.sixBtn.BackColor = System.Drawing.SystemColors.Control;
            this.sixBtn.Font = new System.Drawing.Font("Perpetua Titling MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sixBtn.ForeColor = System.Drawing.Color.DarkBlue;
            this.sixBtn.Location = new System.Drawing.Point(198, 153);
            this.sixBtn.Name = "sixBtn";
            this.sixBtn.Size = new System.Drawing.Size(79, 56);
            this.sixBtn.TabIndex = 29;
            this.sixBtn.Text = "6";
            this.sixBtn.UseVisualStyleBackColor = false;
            this.sixBtn.Click += new System.EventHandler(this.sixBtn_Click);
            // 
            // threeBtn
            // 
            this.threeBtn.BackColor = System.Drawing.SystemColors.Control;
            this.threeBtn.Font = new System.Drawing.Font("Perpetua Titling MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.threeBtn.ForeColor = System.Drawing.Color.DarkBlue;
            this.threeBtn.Location = new System.Drawing.Point(198, 208);
            this.threeBtn.Name = "threeBtn";
            this.threeBtn.Size = new System.Drawing.Size(79, 56);
            this.threeBtn.TabIndex = 28;
            this.threeBtn.Text = "3";
            this.threeBtn.UseVisualStyleBackColor = false;
            this.threeBtn.Click += new System.EventHandler(this.threeBtn_Click);
            // 
            // eightBtn
            // 
            this.eightBtn.BackColor = System.Drawing.SystemColors.Control;
            this.eightBtn.Font = new System.Drawing.Font("Perpetua Titling MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eightBtn.ForeColor = System.Drawing.Color.DarkBlue;
            this.eightBtn.Location = new System.Drawing.Point(113, 97);
            this.eightBtn.Name = "eightBtn";
            this.eightBtn.Size = new System.Drawing.Size(79, 56);
            this.eightBtn.TabIndex = 27;
            this.eightBtn.Text = "8";
            this.eightBtn.UseVisualStyleBackColor = false;
            this.eightBtn.Click += new System.EventHandler(this.eightBtn_Click);
            // 
            // zeroBtn
            // 
            this.zeroBtn.BackColor = System.Drawing.SystemColors.Control;
            this.zeroBtn.Font = new System.Drawing.Font("Perpetua Titling MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zeroBtn.ForeColor = System.Drawing.Color.DarkBlue;
            this.zeroBtn.Location = new System.Drawing.Point(28, 267);
            this.zeroBtn.Name = "zeroBtn";
            this.zeroBtn.Size = new System.Drawing.Size(164, 56);
            this.zeroBtn.TabIndex = 26;
            this.zeroBtn.Text = "0";
            this.zeroBtn.UseVisualStyleBackColor = false;
            this.zeroBtn.Click += new System.EventHandler(this.zeroBtn_Click);
            // 
            // oneBtn
            // 
            this.oneBtn.BackColor = System.Drawing.SystemColors.Control;
            this.oneBtn.Font = new System.Drawing.Font("Perpetua Titling MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oneBtn.ForeColor = System.Drawing.Color.DarkBlue;
            this.oneBtn.Location = new System.Drawing.Point(28, 208);
            this.oneBtn.Name = "oneBtn";
            this.oneBtn.Size = new System.Drawing.Size(79, 56);
            this.oneBtn.TabIndex = 25;
            this.oneBtn.TabStop = false;
            this.oneBtn.Text = "1";
            this.oneBtn.UseVisualStyleBackColor = false;
            this.oneBtn.Click += new System.EventHandler(this.oneBtn_Click);
            // 
            // sevenBtn
            // 
            this.sevenBtn.BackColor = System.Drawing.SystemColors.Control;
            this.sevenBtn.Font = new System.Drawing.Font("Perpetua Titling MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sevenBtn.ForeColor = System.Drawing.Color.DarkBlue;
            this.sevenBtn.Location = new System.Drawing.Point(28, 97);
            this.sevenBtn.Name = "sevenBtn";
            this.sevenBtn.Size = new System.Drawing.Size(79, 56);
            this.sevenBtn.TabIndex = 24;
            this.sevenBtn.Text = "7";
            this.sevenBtn.UseVisualStyleBackColor = false;
            this.sevenBtn.Click += new System.EventHandler(this.sevenBtn_Click);
            // 
            // fourBtn
            // 
            this.fourBtn.BackColor = System.Drawing.SystemColors.Control;
            this.fourBtn.Font = new System.Drawing.Font("Perpetua Titling MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fourBtn.ForeColor = System.Drawing.Color.DarkBlue;
            this.fourBtn.Location = new System.Drawing.Point(28, 153);
            this.fourBtn.Name = "fourBtn";
            this.fourBtn.Size = new System.Drawing.Size(79, 56);
            this.fourBtn.TabIndex = 23;
            this.fourBtn.Text = "4";
            this.fourBtn.UseVisualStyleBackColor = false;
            this.fourBtn.Click += new System.EventHandler(this.fourBtn_Click);
            // 
            // decimalBtn
            // 
            this.decimalBtn.BackColor = System.Drawing.SystemColors.Control;
            this.decimalBtn.Font = new System.Drawing.Font("Perpetua Titling MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decimalBtn.ForeColor = System.Drawing.Color.DarkBlue;
            this.decimalBtn.Location = new System.Drawing.Point(198, 267);
            this.decimalBtn.Name = "decimalBtn";
            this.decimalBtn.Size = new System.Drawing.Size(79, 56);
            this.decimalBtn.TabIndex = 22;
            this.decimalBtn.Text = ".";
            this.decimalBtn.UseVisualStyleBackColor = false;
            this.decimalBtn.Click += new System.EventHandler(this.decimalBtn_Click);
            // 
            // fiveBtn
            // 
            this.fiveBtn.BackColor = System.Drawing.SystemColors.Control;
            this.fiveBtn.Font = new System.Drawing.Font("Perpetua Titling MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fiveBtn.ForeColor = System.Drawing.Color.DarkBlue;
            this.fiveBtn.Location = new System.Drawing.Point(113, 153);
            this.fiveBtn.Name = "fiveBtn";
            this.fiveBtn.Size = new System.Drawing.Size(79, 56);
            this.fiveBtn.TabIndex = 21;
            this.fiveBtn.Text = "5";
            this.fiveBtn.UseVisualStyleBackColor = false;
            this.fiveBtn.Click += new System.EventHandler(this.fiveBtn_Click);
            // 
            // twoBtn
            // 
            this.twoBtn.BackColor = System.Drawing.SystemColors.Control;
            this.twoBtn.Font = new System.Drawing.Font("Perpetua Titling MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.twoBtn.ForeColor = System.Drawing.Color.DarkBlue;
            this.twoBtn.Location = new System.Drawing.Point(113, 208);
            this.twoBtn.Name = "twoBtn";
            this.twoBtn.Size = new System.Drawing.Size(79, 56);
            this.twoBtn.TabIndex = 20;
            this.twoBtn.Text = "2";
            this.twoBtn.UseVisualStyleBackColor = false;
            this.twoBtn.Click += new System.EventHandler(this.twoBtn_Click);
            // 
            // calculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BackgroundImage = global::Calculator.Properties.Resources.background11;
            this.ClientSize = new System.Drawing.Size(474, 335);
            this.Controls.Add(this.backspaceBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.equalBtn);
            this.Controls.Add(this.divideBtn);
            this.Controls.Add(this.multiplyBtn);
            this.Controls.Add(this.minusBtn);
            this.Controls.Add(this.plusBtn);
            this.Controls.Add(this.nineBtn);
            this.Controls.Add(this.sixBtn);
            this.Controls.Add(this.threeBtn);
            this.Controls.Add(this.eightBtn);
            this.Controls.Add(this.zeroBtn);
            this.Controls.Add(this.oneBtn);
            this.Controls.Add(this.sevenBtn);
            this.Controls.Add(this.fourBtn);
            this.Controls.Add(this.decimalBtn);
            this.Controls.Add(this.fiveBtn);
            this.Controls.Add(this.twoBtn);
            this.Controls.Add(this.displayTxtBox);
            this.KeyPreview = true;
            this.Name = "calculatorForm";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.calculatorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox displayTxtBox;
        private RoundButton decimalBtn;
        private RoundButton fiveBtn;
        private RoundButton twoBtn;
        private RoundButton sevenBtn;
        private RoundButton fourBtn;
        private RoundButton oneBtn;
        private RoundButton zeroBtn;
        private RoundButton eightBtn;
        private RoundButton threeBtn;
        private RoundButton sixBtn;
        private RoundButton nineBtn;
        private RoundButton plusBtn;
        private RoundButton minusBtn;
        private RoundButton multiplyBtn;
        private RoundButton divideBtn;
        private RoundButton equalBtn;
        private RoundButton clearBtn;
        private RoundButton backspaceBtn;
    }
}

