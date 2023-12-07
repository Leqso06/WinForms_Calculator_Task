namespace WindowsForms_Calculator
{
    partial class Calculator
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
            this.numbersTxt = new System.Windows.Forms.TextBox();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_7 = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_0 = new System.Windows.Forms.Button();
            this.btn_decimalPoint = new System.Windows.Forms.Button();
            this.btn_plus = new System.Windows.Forms.Button();
            this.btn_minus = new System.Windows.Forms.Button();
            this.btn_division = new System.Windows.Forms.Button();
            this.btn_equals = new System.Windows.Forms.Button();
            this.btn_multiplication = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_ClearEntry = new System.Windows.Forms.Button();
            this.negativeNum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // numbersTxt
            // 
            this.numbersTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numbersTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numbersTxt.Location = new System.Drawing.Point(30, 20);
            this.numbersTxt.Multiline = true;
            this.numbersTxt.Name = "numbersTxt";
            this.numbersTxt.ReadOnly = true;
            this.numbersTxt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numbersTxt.Size = new System.Drawing.Size(375, 85);
            this.numbersTxt.TabIndex = 0;
            this.numbersTxt.Text = "0";
            this.numbersTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_1
            // 
            this.btn_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_1.Location = new System.Drawing.Point(30, 403);
            this.btn_1.Margin = new System.Windows.Forms.Padding(10);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(90, 90);
            this.btn_1.TabIndex = 17;
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.NumberClick);
            // 
            // btn_2
            // 
            this.btn_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_2.Location = new System.Drawing.Point(125, 403);
            this.btn_2.Margin = new System.Windows.Forms.Padding(10);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(90, 90);
            this.btn_2.TabIndex = 18;
            this.btn_2.Text = "2";
            this.btn_2.UseVisualStyleBackColor = true;
            this.btn_2.Click += new System.EventHandler(this.NumberClick);
            // 
            // btn_3
            // 
            this.btn_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_3.Location = new System.Drawing.Point(220, 403);
            this.btn_3.Margin = new System.Windows.Forms.Padding(10);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(90, 90);
            this.btn_3.TabIndex = 19;
            this.btn_3.Text = "3";
            this.btn_3.UseVisualStyleBackColor = true;
            this.btn_3.Click += new System.EventHandler(this.NumberClick);
            // 
            // btn_4
            // 
            this.btn_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_4.Location = new System.Drawing.Point(30, 308);
            this.btn_4.Margin = new System.Windows.Forms.Padding(10);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(90, 90);
            this.btn_4.TabIndex = 10;
            this.btn_4.Text = "4";
            this.btn_4.UseVisualStyleBackColor = true;
            this.btn_4.Click += new System.EventHandler(this.NumberClick);
            // 
            // btn_5
            // 
            this.btn_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_5.Location = new System.Drawing.Point(125, 308);
            this.btn_5.Margin = new System.Windows.Forms.Padding(10);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(90, 90);
            this.btn_5.TabIndex = 11;
            this.btn_5.Text = "5";
            this.btn_5.UseVisualStyleBackColor = true;
            this.btn_5.Click += new System.EventHandler(this.NumberClick);
            // 
            // btn_6
            // 
            this.btn_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_6.Location = new System.Drawing.Point(220, 308);
            this.btn_6.Margin = new System.Windows.Forms.Padding(10);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(90, 90);
            this.btn_6.TabIndex = 12;
            this.btn_6.Text = "6";
            this.btn_6.UseVisualStyleBackColor = true;
            this.btn_6.Click += new System.EventHandler(this.NumberClick);
            // 
            // btn_7
            // 
            this.btn_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_7.Location = new System.Drawing.Point(30, 213);
            this.btn_7.Margin = new System.Windows.Forms.Padding(10);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(90, 90);
            this.btn_7.TabIndex = 6;
            this.btn_7.Text = "7";
            this.btn_7.UseVisualStyleBackColor = true;
            this.btn_7.Click += new System.EventHandler(this.NumberClick);
            // 
            // btn_8
            // 
            this.btn_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_8.Location = new System.Drawing.Point(125, 213);
            this.btn_8.Margin = new System.Windows.Forms.Padding(10);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(90, 90);
            this.btn_8.TabIndex = 7;
            this.btn_8.Text = "8";
            this.btn_8.UseVisualStyleBackColor = true;
            this.btn_8.Click += new System.EventHandler(this.NumberClick);
            // 
            // btn_9
            // 
            this.btn_9.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_9.Location = new System.Drawing.Point(220, 213);
            this.btn_9.Margin = new System.Windows.Forms.Padding(10);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(90, 90);
            this.btn_9.TabIndex = 8;
            this.btn_9.Text = "9";
            this.btn_9.UseVisualStyleBackColor = true;
            this.btn_9.Click += new System.EventHandler(this.NumberClick);
            // 
            // btn_0
            // 
            this.btn_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_0.Location = new System.Drawing.Point(30, 498);
            this.btn_0.Margin = new System.Windows.Forms.Padding(10);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(90, 90);
            this.btn_0.TabIndex = 21;
            this.btn_0.Text = "0";
            this.btn_0.UseVisualStyleBackColor = true;
            this.btn_0.Click += new System.EventHandler(this.NumberClick);
            // 
            // btn_decimalPoint
            // 
            this.btn_decimalPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_decimalPoint.Location = new System.Drawing.Point(125, 498);
            this.btn_decimalPoint.Margin = new System.Windows.Forms.Padding(10);
            this.btn_decimalPoint.Name = "btn_decimalPoint";
            this.btn_decimalPoint.Size = new System.Drawing.Size(90, 90);
            this.btn_decimalPoint.TabIndex = 22;
            this.btn_decimalPoint.Text = ".";
            this.btn_decimalPoint.UseVisualStyleBackColor = true;
            this.btn_decimalPoint.Click += new System.EventHandler(this.NumberClick);
            // 
            // btn_plus
            // 
            this.btn_plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_plus.Location = new System.Drawing.Point(315, 213);
            this.btn_plus.Margin = new System.Windows.Forms.Padding(10);
            this.btn_plus.Name = "btn_plus";
            this.btn_plus.Size = new System.Drawing.Size(90, 90);
            this.btn_plus.TabIndex = 9;
            this.btn_plus.Text = "+";
            this.btn_plus.UseVisualStyleBackColor = true;
            this.btn_plus.Click += new System.EventHandler(this.Operation);
            // 
            // btn_minus
            // 
            this.btn_minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_minus.Location = new System.Drawing.Point(315, 308);
            this.btn_minus.Margin = new System.Windows.Forms.Padding(10);
            this.btn_minus.Name = "btn_minus";
            this.btn_minus.Size = new System.Drawing.Size(90, 90);
            this.btn_minus.TabIndex = 13;
            this.btn_minus.Text = "-";
            this.btn_minus.UseVisualStyleBackColor = true;
            this.btn_minus.Click += new System.EventHandler(this.Operation);
            // 
            // btn_division
            // 
            this.btn_division.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_division.Location = new System.Drawing.Point(315, 498);
            this.btn_division.Margin = new System.Windows.Forms.Padding(10);
            this.btn_division.Name = "btn_division";
            this.btn_division.Size = new System.Drawing.Size(90, 90);
            this.btn_division.TabIndex = 24;
            this.btn_division.Text = "÷";
            this.btn_division.UseVisualStyleBackColor = true;
            this.btn_division.Click += new System.EventHandler(this.Operation);
            // 
            // btn_equals
            // 
            this.btn_equals.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_equals.Location = new System.Drawing.Point(220, 498);
            this.btn_equals.Margin = new System.Windows.Forms.Padding(10);
            this.btn_equals.Name = "btn_equals";
            this.btn_equals.Size = new System.Drawing.Size(90, 90);
            this.btn_equals.TabIndex = 23;
            this.btn_equals.Text = "=";
            this.btn_equals.UseVisualStyleBackColor = true;
            this.btn_equals.Click += new System.EventHandler(this.Calculation);
            // 
            // btn_multiplication
            // 
            this.btn_multiplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_multiplication.Location = new System.Drawing.Point(315, 403);
            this.btn_multiplication.Margin = new System.Windows.Forms.Padding(10);
            this.btn_multiplication.Name = "btn_multiplication";
            this.btn_multiplication.Size = new System.Drawing.Size(90, 90);
            this.btn_multiplication.TabIndex = 20;
            this.btn_multiplication.Text = "x";
            this.btn_multiplication.UseVisualStyleBackColor = true;
            this.btn_multiplication.Click += new System.EventHandler(this.Operation);
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(30, 118);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(10);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(136, 90);
            this.btn_clear.TabIndex = 25;
            this.btn_clear.Text = "C";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.Clear);
            // 
            // btn_ClearEntry
            // 
            this.btn_ClearEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ClearEntry.Location = new System.Drawing.Point(174, 118);
            this.btn_ClearEntry.Margin = new System.Windows.Forms.Padding(10);
            this.btn_ClearEntry.Name = "btn_ClearEntry";
            this.btn_ClearEntry.Size = new System.Drawing.Size(136, 90);
            this.btn_ClearEntry.TabIndex = 26;
            this.btn_ClearEntry.Text = "CE";
            this.btn_ClearEntry.UseVisualStyleBackColor = true;
            this.btn_ClearEntry.Click += new System.EventHandler(this.ClearEntry);
            // 
            // negativeNum
            // 
            this.negativeNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.negativeNum.Location = new System.Drawing.Point(315, 118);
            this.negativeNum.Margin = new System.Windows.Forms.Padding(10);
            this.negativeNum.Name = "negativeNum";
            this.negativeNum.Size = new System.Drawing.Size(90, 90);
            this.negativeNum.TabIndex = 27;
            this.negativeNum.Text = "±";
            this.negativeNum.UseVisualStyleBackColor = true;
            this.negativeNum.Click += new System.EventHandler(this.negativeNum_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(434, 611);
            this.Controls.Add(this.negativeNum);
            this.Controls.Add(this.btn_ClearEntry);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_division);
            this.Controls.Add(this.btn_equals);
            this.Controls.Add(this.btn_decimalPoint);
            this.Controls.Add(this.btn_0);
            this.Controls.Add(this.btn_multiplication);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.btn_minus);
            this.Controls.Add(this.btn_6);
            this.Controls.Add(this.btn_5);
            this.Controls.Add(this.btn_4);
            this.Controls.Add(this.btn_plus);
            this.Controls.Add(this.btn_9);
            this.Controls.Add(this.btn_8);
            this.Controls.Add(this.btn_7);
            this.Controls.Add(this.numbersTxt);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximumSize = new System.Drawing.Size(450, 650);
            this.MinimumSize = new System.Drawing.Size(450, 650);
            this.Name = "Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numbersTxt;
        private System.Windows.Forms.Button btn_7;
        private System.Windows.Forms.Button btn_8;
        private System.Windows.Forms.Button btn_plus;
        private System.Windows.Forms.Button btn_9;
        private System.Windows.Forms.Button btn_minus;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_division;
        private System.Windows.Forms.Button btn_equals;
        private System.Windows.Forms.Button btn_decimalPoint;
        private System.Windows.Forms.Button btn_0;
        private System.Windows.Forms.Button btn_multiplication;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_ClearEntry;
        private System.Windows.Forms.Button negativeNum;
    }
}

