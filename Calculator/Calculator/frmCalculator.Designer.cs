namespace MyCalculator
{
    partial class CalculatorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculatorForm));
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCopyA = new System.Windows.Forms.Button();
            this.btnSeven = new System.Windows.Forms.Button();
            this.btnEight = new System.Windows.Forms.Button();
            this.btnNine = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnSqrt = new System.Windows.Forms.Button();
            this.btnOneOverX = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btnSubstract = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnOne = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnMPlus = new System.Windows.Forms.Button();
            this.btnMS = new System.Windows.Forms.Button();
            this.btnMR = new System.Windows.Forms.Button();
            this.btnMC = new System.Windows.Forms.Button();
            this.grpMemory = new System.Windows.Forms.GroupBox();
            this.lblMemory = new System.Windows.Forms.Label();
            this.btnAboutMe = new System.Windows.Forms.Button();
            this.grpMemory.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDisplay
            // 
            this.txtDisplay.Location = new System.Drawing.Point(10, 12);
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(397, 22);
            this.txtDisplay.TabIndex = 0;
            this.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 1;
            // 
            // btnBack
            // 
            this.btnBack.ForeColor = System.Drawing.Color.Red;
            this.btnBack.Location = new System.Drawing.Point(82, 60);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(101, 36);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.ForeColor = System.Drawing.Color.Red;
            this.btnClear.Location = new System.Drawing.Point(192, 60);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(109, 36);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCopyA
            // 
            this.btnCopyA.ForeColor = System.Drawing.Color.Red;
            this.btnCopyA.Location = new System.Drawing.Point(311, 60);
            this.btnCopyA.Name = "btnCopyA";
            this.btnCopyA.Size = new System.Drawing.Size(99, 36);
            this.btnCopyA.TabIndex = 5;
            this.btnCopyA.Text = "CopyA";
            this.btnCopyA.UseVisualStyleBackColor = true;
            // 
            // btnSeven
            // 
            this.btnSeven.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnSeven.Location = new System.Drawing.Point(80, 112);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(55, 41);
            this.btnSeven.TabIndex = 10;
            this.btnSeven.Text = "7";
            this.btnSeven.UseVisualStyleBackColor = true;
            this.btnSeven.Click += new System.EventHandler(this.numBtn_Click);
            // 
            // btnEight
            // 
            this.btnEight.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnEight.Location = new System.Drawing.Point(146, 112);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(55, 41);
            this.btnEight.TabIndex = 11;
            this.btnEight.Text = "8";
            this.btnEight.UseVisualStyleBackColor = true;
            this.btnEight.Click += new System.EventHandler(this.numBtn_Click);
            // 
            // btnNine
            // 
            this.btnNine.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnNine.Location = new System.Drawing.Point(214, 112);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(55, 41);
            this.btnNine.TabIndex = 12;
            this.btnNine.Text = "9";
            this.btnNine.UseVisualStyleBackColor = true;
            this.btnNine.Click += new System.EventHandler(this.numBtn_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.ForeColor = System.Drawing.Color.Red;
            this.btnDivide.Location = new System.Drawing.Point(285, 112);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(55, 41);
            this.btnDivide.TabIndex = 13;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // btnSqrt
            // 
            this.btnSqrt.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnSqrt.Location = new System.Drawing.Point(355, 112);
            this.btnSqrt.Name = "btnSqrt";
            this.btnSqrt.Size = new System.Drawing.Size(55, 41);
            this.btnSqrt.TabIndex = 14;
            this.btnSqrt.Text = "sqrt";
            this.btnSqrt.UseVisualStyleBackColor = true;
            // 
            // btnOneOverX
            // 
            this.btnOneOverX.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnOneOverX.Location = new System.Drawing.Point(355, 170);
            this.btnOneOverX.Name = "btnOneOverX";
            this.btnOneOverX.Size = new System.Drawing.Size(55, 41);
            this.btnOneOverX.TabIndex = 19;
            this.btnOneOverX.Text = "1/x";
            this.btnOneOverX.UseVisualStyleBackColor = true;
            this.btnOneOverX.Click += new System.EventHandler(this.btnOneOverX_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.ForeColor = System.Drawing.Color.Red;
            this.btnMultiply.Location = new System.Drawing.Point(285, 170);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(55, 41);
            this.btnMultiply.TabIndex = 18;
            this.btnMultiply.Text = "*";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // btnSix
            // 
            this.btnSix.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnSix.Location = new System.Drawing.Point(214, 170);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(55, 41);
            this.btnSix.TabIndex = 17;
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = true;
            this.btnSix.Click += new System.EventHandler(this.numBtn_Click);
            // 
            // btnFive
            // 
            this.btnFive.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnFive.Location = new System.Drawing.Point(146, 170);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(55, 41);
            this.btnFive.TabIndex = 16;
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = true;
            this.btnFive.Click += new System.EventHandler(this.numBtn_Click);
            // 
            // btnFour
            // 
            this.btnFour.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnFour.Location = new System.Drawing.Point(80, 170);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(55, 41);
            this.btnFour.TabIndex = 15;
            this.btnFour.Text = "4";
            this.btnFour.UseVisualStyleBackColor = true;
            this.btnFour.Click += new System.EventHandler(this.numBtn_Click);
            // 
            // button6
            // 
            this.button6.ForeColor = System.Drawing.Color.Red;
            this.button6.Location = new System.Drawing.Point(355, 233);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(55, 100);
            this.button6.TabIndex = 24;
            this.button6.Text = "=";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // btnSubstract
            // 
            this.btnSubstract.ForeColor = System.Drawing.Color.Red;
            this.btnSubstract.Location = new System.Drawing.Point(285, 233);
            this.btnSubstract.Name = "btnSubstract";
            this.btnSubstract.Size = new System.Drawing.Size(55, 41);
            this.btnSubstract.TabIndex = 23;
            this.btnSubstract.Text = "-";
            this.btnSubstract.UseVisualStyleBackColor = true;
            this.btnSubstract.Click += new System.EventHandler(this.btnSubtract_Click);
            // 
            // btnThree
            // 
            this.btnThree.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnThree.Location = new System.Drawing.Point(214, 233);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(55, 41);
            this.btnThree.TabIndex = 22;
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = true;
            this.btnThree.Click += new System.EventHandler(this.numBtn_Click);
            // 
            // btnTwo
            // 
            this.btnTwo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnTwo.Location = new System.Drawing.Point(146, 233);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(55, 41);
            this.btnTwo.TabIndex = 21;
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = true;
            this.btnTwo.Click += new System.EventHandler(this.numBtn_Click);
            // 
            // btnOne
            // 
            this.btnOne.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnOne.Location = new System.Drawing.Point(80, 233);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(55, 41);
            this.btnOne.TabIndex = 20;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = true;
            this.btnOne.Click += new System.EventHandler(this.numBtn_Click);
            // 
            // button11
            // 
            this.button11.ForeColor = System.Drawing.Color.Red;
            this.button11.Location = new System.Drawing.Point(285, 292);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(55, 41);
            this.button11.TabIndex = 28;
            this.button11.Text = "+";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // button12
            // 
            this.button12.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button12.Location = new System.Drawing.Point(214, 292);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(55, 41);
            this.button12.TabIndex = 27;
            this.button12.Text = ".";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button13.Location = new System.Drawing.Point(146, 292);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(55, 41);
            this.button13.TabIndex = 26;
            this.button13.Text = "+/-";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // btnZero
            // 
            this.btnZero.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnZero.Location = new System.Drawing.Point(80, 292);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(55, 41);
            this.btnZero.TabIndex = 25;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = true;
            this.btnZero.Click += new System.EventHandler(this.numBtn_Click);
            // 
            // btnMPlus
            // 
            this.btnMPlus.ForeColor = System.Drawing.Color.Red;
            this.btnMPlus.Location = new System.Drawing.Point(13, 292);
            this.btnMPlus.Name = "btnMPlus";
            this.btnMPlus.Size = new System.Drawing.Size(55, 41);
            this.btnMPlus.TabIndex = 32;
            this.btnMPlus.Text = "M+";
            this.btnMPlus.UseVisualStyleBackColor = true;
            this.btnMPlus.Click += new System.EventHandler(this.btnMA_Click);
            // 
            // btnMS
            // 
            this.btnMS.ForeColor = System.Drawing.Color.Red;
            this.btnMS.Location = new System.Drawing.Point(13, 233);
            this.btnMS.Name = "btnMS";
            this.btnMS.Size = new System.Drawing.Size(55, 41);
            this.btnMS.TabIndex = 31;
            this.btnMS.Text = "MS";
            this.btnMS.UseVisualStyleBackColor = true;
            this.btnMS.Click += new System.EventHandler(this.btnMS_Click);
            // 
            // btnMR
            // 
            this.btnMR.ForeColor = System.Drawing.Color.Red;
            this.btnMR.Location = new System.Drawing.Point(13, 170);
            this.btnMR.Name = "btnMR";
            this.btnMR.Size = new System.Drawing.Size(55, 41);
            this.btnMR.TabIndex = 30;
            this.btnMR.Text = "MR";
            this.btnMR.UseVisualStyleBackColor = true;
            this.btnMR.Click += new System.EventHandler(this.btnMR_Click);
            // 
            // btnMC
            // 
            this.btnMC.ForeColor = System.Drawing.Color.Red;
            this.btnMC.Location = new System.Drawing.Point(13, 112);
            this.btnMC.Name = "btnMC";
            this.btnMC.Size = new System.Drawing.Size(55, 41);
            this.btnMC.TabIndex = 29;
            this.btnMC.Text = "MC";
            this.btnMC.UseVisualStyleBackColor = true;
            this.btnMC.Click += new System.EventHandler(this.btnMC_Click);
            // 
            // grpMemory
            // 
            this.grpMemory.Controls.Add(this.lblMemory);
            this.grpMemory.Location = new System.Drawing.Point(13, 50);
            this.grpMemory.Name = "grpMemory";
            this.grpMemory.Size = new System.Drawing.Size(61, 54);
            this.grpMemory.TabIndex = 33;
            this.grpMemory.TabStop = false;
            // 
            // lblMemory
            // 
            this.lblMemory.Location = new System.Drawing.Point(3, 10);
            this.lblMemory.Name = "lblMemory";
            this.lblMemory.Size = new System.Drawing.Size(58, 35);
            this.lblMemory.TabIndex = 0;
            this.lblMemory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAboutMe
            // 
            this.btnAboutMe.Location = new System.Drawing.Point(13, 365);
            this.btnAboutMe.Name = "btnAboutMe";
            this.btnAboutMe.Size = new System.Drawing.Size(403, 34);
            this.btnAboutMe.TabIndex = 34;
            this.btnAboutMe.Text = "About Me";
            this.btnAboutMe.UseVisualStyleBackColor = true;
            this.btnAboutMe.Click += new System.EventHandler(this.btnAboutMe_Click);
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 411);
            this.Controls.Add(this.btnAboutMe);
            this.Controls.Add(this.grpMemory);
            this.Controls.Add(this.btnMPlus);
            this.Controls.Add(this.btnMS);
            this.Controls.Add(this.btnMR);
            this.Controls.Add(this.btnMC);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btnSubstract);
            this.Controls.Add(this.btnThree);
            this.Controls.Add(this.btnTwo);
            this.Controls.Add(this.btnOne);
            this.Controls.Add(this.btnOneOverX);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnSix);
            this.Controls.Add(this.btnFive);
            this.Controls.Add(this.btnFour);
            this.Controls.Add(this.btnSqrt);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnNine);
            this.Controls.Add(this.btnEight);
            this.Controls.Add(this.btnSeven);
            this.Controls.Add(this.btnCopyA);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDisplay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CalculatorForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Calculator";
            this.grpMemory.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCopyA;
        private System.Windows.Forms.Button btnSeven;
        private System.Windows.Forms.Button btnEight;
        private System.Windows.Forms.Button btnNine;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnSqrt;
        private System.Windows.Forms.Button btnOneOverX;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnSix;
        private System.Windows.Forms.Button btnFive;
        private System.Windows.Forms.Button btnFour;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnSubstract;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnMS;
        private System.Windows.Forms.Button btnMR;
        private System.Windows.Forms.Button btnMC;
        private System.Windows.Forms.Button btnMPlus;
        private System.Windows.Forms.GroupBox grpMemory;
        private System.Windows.Forms.Label lblMemory;
        private System.Windows.Forms.Button btnAboutMe;
    }
}

