
namespace WindowsFormsApp3
{
    partial class Form1
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
            this.textBoxCalc = new System.Windows.Forms.TextBox();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.buttonPercent = new System.Windows.Forms.Button();
            this.buttonClearAll = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonDivision = new System.Windows.Forms.Button();
            this.buttonMult = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonEquals = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonNegative = new System.Windows.Forms.Button();
            this.buttonPeriod = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxCalc
            // 
            this.textBoxCalc.Enabled = false;
            this.textBoxCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCalc.Location = new System.Drawing.Point(0, 0);
            this.textBoxCalc.Name = "textBoxCalc";
            this.textBoxCalc.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxCalc.Size = new System.Drawing.Size(294, 20);
            this.textBoxCalc.TabIndex = 0;
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Enabled = false;
            this.textBoxTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTotal.Location = new System.Drawing.Point(0, 19);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxTotal.Size = new System.Drawing.Size(294, 32);
            this.textBoxTotal.TabIndex = 1;
            // 
            // buttonPercent
            // 
            this.buttonPercent.Enabled = false;
            this.buttonPercent.Location = new System.Drawing.Point(0, 50);
            this.buttonPercent.Name = "buttonPercent";
            this.buttonPercent.Size = new System.Drawing.Size(75, 23);
            this.buttonPercent.TabIndex = 2;
            this.buttonPercent.Text = "%";
            this.buttonPercent.UseVisualStyleBackColor = true;
            // 
            // buttonClearAll
            // 
            this.buttonClearAll.Location = new System.Drawing.Point(73, 50);
            this.buttonClearAll.Name = "buttonClearAll";
            this.buttonClearAll.Size = new System.Drawing.Size(75, 23);
            this.buttonClearAll.TabIndex = 3;
            this.buttonClearAll.Text = "CE";
            this.buttonClearAll.UseVisualStyleBackColor = true;
            this.buttonClearAll.Click += new System.EventHandler(this.buttonClearAll_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Enabled = false;
            this.buttonClear.Location = new System.Drawing.Point(146, 50);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 4;
            this.buttonClear.Text = "<--";
            this.buttonClear.UseVisualStyleBackColor = true;
            // 
            // buttonDivision
            // 
            this.buttonDivision.Location = new System.Drawing.Point(219, 50);
            this.buttonDivision.Name = "buttonDivision";
            this.buttonDivision.Size = new System.Drawing.Size(75, 23);
            this.buttonDivision.TabIndex = 5;
            this.buttonDivision.Text = "/";
            this.buttonDivision.UseVisualStyleBackColor = true;
            this.buttonDivision.Click += new System.EventHandler(this.buttonCalc_Click);
            // 
            // buttonMult
            // 
            this.buttonMult.Location = new System.Drawing.Point(219, 71);
            this.buttonMult.Name = "buttonMult";
            this.buttonMult.Size = new System.Drawing.Size(75, 23);
            this.buttonMult.TabIndex = 6;
            this.buttonMult.Text = "*";
            this.buttonMult.UseVisualStyleBackColor = true;
            this.buttonMult.Click += new System.EventHandler(this.buttonCalc_Click);
            // 
            // buttonMinus
            // 
            this.buttonMinus.Location = new System.Drawing.Point(219, 92);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(75, 23);
            this.buttonMinus.TabIndex = 7;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = true;
            this.buttonMinus.Click += new System.EventHandler(this.buttonCalc_Click);
            // 
            // buttonPlus
            // 
            this.buttonPlus.Location = new System.Drawing.Point(219, 112);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(75, 23);
            this.buttonPlus.TabIndex = 8;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.buttonCalc_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.numericButton_Click);
            // 
            // buttonEquals
            // 
            this.buttonEquals.Location = new System.Drawing.Point(219, 133);
            this.buttonEquals.Name = "buttonEquals";
            this.buttonEquals.Size = new System.Drawing.Size(75, 23);
            this.buttonEquals.TabIndex = 10;
            this.buttonEquals.Text = "=";
            this.buttonEquals.UseVisualStyleBackColor = true;
            this.buttonEquals.Click += new System.EventHandler(this.buttonEquals_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(73, 112);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.numericButton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(146, 112);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.numericButton_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(0, 92);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 15;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.numericButton_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(73, 92);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 14;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.numericButton_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(146, 92);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 13;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.numericButton_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(0, 71);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 18;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.numericButton_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(73, 71);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 17;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.numericButton_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(146, 71);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 16;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.numericButton_Click);
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(73, 133);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(75, 23);
            this.button0.TabIndex = 19;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.numericButton_Click);
            // 
            // buttonNegative
            // 
            this.buttonNegative.Enabled = false;
            this.buttonNegative.Location = new System.Drawing.Point(0, 133);
            this.buttonNegative.Name = "buttonNegative";
            this.buttonNegative.Size = new System.Drawing.Size(75, 23);
            this.buttonNegative.TabIndex = 20;
            this.buttonNegative.Text = "+/-";
            this.buttonNegative.UseVisualStyleBackColor = true;
            this.buttonNegative.Click += new System.EventHandler(this.buttonNegative_Click);
            // 
            // buttonPeriod
            // 
            this.buttonPeriod.Enabled = false;
            this.buttonPeriod.Location = new System.Drawing.Point(146, 133);
            this.buttonPeriod.Name = "buttonPeriod";
            this.buttonPeriod.Size = new System.Drawing.Size(75, 23);
            this.buttonPeriod.TabIndex = 21;
            this.buttonPeriod.Text = ",";
            this.buttonPeriod.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 155);
            this.Controls.Add(this.buttonPeriod);
            this.Controls.Add(this.buttonNegative);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonEquals);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.buttonMinus);
            this.Controls.Add(this.buttonMult);
            this.Controls.Add(this.buttonDivision);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonClearAll);
            this.Controls.Add(this.buttonPercent);
            this.Controls.Add(this.textBoxTotal);
            this.Controls.Add(this.textBoxCalc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCalc;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.Button buttonPercent;
        private System.Windows.Forms.Button buttonClearAll;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonDivision;
        private System.Windows.Forms.Button buttonMult;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonEquals;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button buttonNegative;
        private System.Windows.Forms.Button buttonPeriod;
    }
}

