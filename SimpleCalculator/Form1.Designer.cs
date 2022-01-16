namespace SimpleCalculator
{
    partial class simpleCalculator
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
            this.numDisplay = new System.Windows.Forms.TextBox();
            this.butEqual = new System.Windows.Forms.Button();
            this.butPlus = new System.Windows.Forms.Button();
            this.butMinus = new System.Windows.Forms.Button();
            this.butMultiply = new System.Windows.Forms.Button();
            this.butDivide = new System.Windows.Forms.Button();
            this.butBackSpace = new System.Windows.Forms.Button();
            this.butDecimal = new System.Windows.Forms.Button();
            this.num0 = new System.Windows.Forms.Button();
            this.num2 = new System.Windows.Forms.Button();
            this.num3 = new System.Windows.Forms.Button();
            this.num1 = new System.Windows.Forms.Button();
            this.num6 = new System.Windows.Forms.Button();
            this.num5 = new System.Windows.Forms.Button();
            this.num4 = new System.Windows.Forms.Button();
            this.num9 = new System.Windows.Forms.Button();
            this.num8 = new System.Windows.Forms.Button();
            this.num7 = new System.Windows.Forms.Button();
            this.butClear = new System.Windows.Forms.Button();
            this.butPercent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // numDisplay
            // 
            this.numDisplay.BackColor = System.Drawing.SystemColors.MenuText;
            this.numDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.numDisplay.ForeColor = System.Drawing.SystemColors.Window;
            this.numDisplay.Location = new System.Drawing.Point(30, 36);
            this.numDisplay.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.numDisplay.Multiline = true;
            this.numDisplay.Name = "numDisplay";
            this.numDisplay.Size = new System.Drawing.Size(791, 135);
            this.numDisplay.TabIndex = 0;
            this.numDisplay.Text = "0";
            this.numDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // butEqual
            // 
            this.butEqual.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butEqual.Location = new System.Drawing.Point(598, 926);
            this.butEqual.MinimumSize = new System.Drawing.Size(158, 114);
            this.butEqual.Name = "butEqual";
            this.butEqual.Padding = new System.Windows.Forms.Padding(1);
            this.butEqual.Size = new System.Drawing.Size(223, 128);
            this.butEqual.TabIndex = 1;
            this.butEqual.Text = "=";
            this.butEqual.UseVisualStyleBackColor = true;
            this.butEqual.Click += new System.EventHandler(this.operatorEqualClick);
            // 
            // butPlus
            // 
            this.butPlus.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butPlus.Location = new System.Drawing.Point(598, 781);
            this.butPlus.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.butPlus.MinimumSize = new System.Drawing.Size(158, 114);
            this.butPlus.Name = "butPlus";
            this.butPlus.Padding = new System.Windows.Forms.Padding(1);
            this.butPlus.Size = new System.Drawing.Size(223, 128);
            this.butPlus.TabIndex = 2;
            this.butPlus.Text = "+";
            this.butPlus.UseVisualStyleBackColor = true;
            this.butPlus.Click += new System.EventHandler(this.operatorClick);
            // 
            // butMinus
            // 
            this.butMinus.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butMinus.Location = new System.Drawing.Point(598, 634);
            this.butMinus.MinimumSize = new System.Drawing.Size(158, 114);
            this.butMinus.Name = "butMinus";
            this.butMinus.Padding = new System.Windows.Forms.Padding(1);
            this.butMinus.Size = new System.Drawing.Size(223, 128);
            this.butMinus.TabIndex = 3;
            this.butMinus.Text = "-";
            this.butMinus.UseVisualStyleBackColor = true;
            this.butMinus.Click += new System.EventHandler(this.operatorClick);
            // 
            // butMultiply
            // 
            this.butMultiply.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butMultiply.Location = new System.Drawing.Point(598, 489);
            this.butMultiply.MinimumSize = new System.Drawing.Size(158, 114);
            this.butMultiply.Name = "butMultiply";
            this.butMultiply.Padding = new System.Windows.Forms.Padding(1);
            this.butMultiply.Size = new System.Drawing.Size(223, 128);
            this.butMultiply.TabIndex = 4;
            this.butMultiply.Text = "x";
            this.butMultiply.UseVisualStyleBackColor = true;
            this.butMultiply.Click += new System.EventHandler(this.operatorClick);
            // 
            // butDivide
            // 
            this.butDivide.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDivide.Location = new System.Drawing.Point(598, 342);
            this.butDivide.MinimumSize = new System.Drawing.Size(158, 114);
            this.butDivide.Name = "butDivide";
            this.butDivide.Padding = new System.Windows.Forms.Padding(1);
            this.butDivide.Size = new System.Drawing.Size(223, 128);
            this.butDivide.TabIndex = 5;
            this.butDivide.Text = "/";
            this.butDivide.UseVisualStyleBackColor = true;
            this.butDivide.Click += new System.EventHandler(this.operatorClick);
            // 
            // butBackSpace
            // 
            this.butBackSpace.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butBackSpace.Location = new System.Drawing.Point(598, 195);
            this.butBackSpace.MinimumSize = new System.Drawing.Size(158, 114);
            this.butBackSpace.Name = "butBackSpace";
            this.butBackSpace.Padding = new System.Windows.Forms.Padding(1);
            this.butBackSpace.Size = new System.Drawing.Size(223, 128);
            this.butBackSpace.TabIndex = 6;
            this.butBackSpace.Text = "←";
            this.butBackSpace.UseVisualStyleBackColor = true;
            this.butBackSpace.Click += new System.EventHandler(this.butBackSpace_Click);
            // 
            // butDecimal
            // 
            this.butDecimal.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDecimal.Location = new System.Drawing.Point(405, 929);
            this.butDecimal.MinimumSize = new System.Drawing.Size(158, 114);
            this.butDecimal.Name = "butDecimal";
            this.butDecimal.Padding = new System.Windows.Forms.Padding(1);
            this.butDecimal.Size = new System.Drawing.Size(182, 128);
            this.butDecimal.TabIndex = 7;
            this.butDecimal.Text = ".";
            this.butDecimal.UseVisualStyleBackColor = true;
            this.butDecimal.Click += new System.EventHandler(this.butDecimal_Click);
            // 
            // num0
            // 
            this.num0.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num0.Location = new System.Drawing.Point(21, 929);
            this.num0.MinimumSize = new System.Drawing.Size(158, 114);
            this.num0.Name = "num0";
            this.num0.Padding = new System.Windows.Forms.Padding(1);
            this.num0.Size = new System.Drawing.Size(375, 128);
            this.num0.TabIndex = 8;
            this.num0.Text = "0";
            this.num0.UseVisualStyleBackColor = true;
            this.num0.Click += new System.EventHandler(this.numClick);
            // 
            // num2
            // 
            this.num2.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num2.Location = new System.Drawing.Point(208, 784);
            this.num2.MinimumSize = new System.Drawing.Size(158, 114);
            this.num2.Name = "num2";
            this.num2.Padding = new System.Windows.Forms.Padding(1);
            this.num2.Size = new System.Drawing.Size(188, 128);
            this.num2.TabIndex = 10;
            this.num2.Text = "2";
            this.num2.UseVisualStyleBackColor = true;
            this.num2.Click += new System.EventHandler(this.numClick);
            // 
            // num3
            // 
            this.num3.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num3.Location = new System.Drawing.Point(405, 784);
            this.num3.MinimumSize = new System.Drawing.Size(158, 114);
            this.num3.Name = "num3";
            this.num3.Padding = new System.Windows.Forms.Padding(1);
            this.num3.Size = new System.Drawing.Size(182, 128);
            this.num3.TabIndex = 11;
            this.num3.Text = "3";
            this.num3.UseVisualStyleBackColor = true;
            this.num3.Click += new System.EventHandler(this.numClick);
            // 
            // num1
            // 
            this.num1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num1.Location = new System.Drawing.Point(21, 781);
            this.num1.MinimumSize = new System.Drawing.Size(158, 114);
            this.num1.Name = "num1";
            this.num1.Padding = new System.Windows.Forms.Padding(1);
            this.num1.Size = new System.Drawing.Size(182, 128);
            this.num1.TabIndex = 12;
            this.num1.Text = "1";
            this.num1.UseVisualStyleBackColor = true;
            this.num1.Click += new System.EventHandler(this.numClick);
            // 
            // num6
            // 
            this.num6.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num6.Location = new System.Drawing.Point(405, 636);
            this.num6.MinimumSize = new System.Drawing.Size(158, 114);
            this.num6.Name = "num6";
            this.num6.Padding = new System.Windows.Forms.Padding(1);
            this.num6.Size = new System.Drawing.Size(182, 128);
            this.num6.TabIndex = 13;
            this.num6.Text = "6";
            this.num6.UseVisualStyleBackColor = true;
            this.num6.Click += new System.EventHandler(this.numClick);
            // 
            // num5
            // 
            this.num5.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num5.Location = new System.Drawing.Point(208, 636);
            this.num5.MinimumSize = new System.Drawing.Size(158, 114);
            this.num5.Name = "num5";
            this.num5.Padding = new System.Windows.Forms.Padding(1);
            this.num5.Size = new System.Drawing.Size(188, 128);
            this.num5.TabIndex = 14;
            this.num5.Text = "5";
            this.num5.UseVisualStyleBackColor = true;
            this.num5.Click += new System.EventHandler(this.numClick);
            // 
            // num4
            // 
            this.num4.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num4.Location = new System.Drawing.Point(21, 636);
            this.num4.MinimumSize = new System.Drawing.Size(158, 114);
            this.num4.Name = "num4";
            this.num4.Padding = new System.Windows.Forms.Padding(1);
            this.num4.Size = new System.Drawing.Size(182, 128);
            this.num4.TabIndex = 15;
            this.num4.Text = "4";
            this.num4.UseVisualStyleBackColor = true;
            this.num4.Click += new System.EventHandler(this.numClick);
            // 
            // num9
            // 
            this.num9.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num9.Location = new System.Drawing.Point(405, 492);
            this.num9.MinimumSize = new System.Drawing.Size(158, 114);
            this.num9.Name = "num9";
            this.num9.Padding = new System.Windows.Forms.Padding(1);
            this.num9.Size = new System.Drawing.Size(182, 128);
            this.num9.TabIndex = 16;
            this.num9.Text = "9";
            this.num9.UseVisualStyleBackColor = true;
            this.num9.Click += new System.EventHandler(this.numClick);
            // 
            // num8
            // 
            this.num8.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num8.Location = new System.Drawing.Point(208, 492);
            this.num8.MinimumSize = new System.Drawing.Size(158, 114);
            this.num8.Name = "num8";
            this.num8.Padding = new System.Windows.Forms.Padding(1);
            this.num8.Size = new System.Drawing.Size(188, 128);
            this.num8.TabIndex = 17;
            this.num8.Text = "8";
            this.num8.UseVisualStyleBackColor = true;
            this.num8.Click += new System.EventHandler(this.numClick);
            // 
            // num7
            // 
            this.num7.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num7.Location = new System.Drawing.Point(21, 492);
            this.num7.MinimumSize = new System.Drawing.Size(158, 114);
            this.num7.Name = "num7";
            this.num7.Padding = new System.Windows.Forms.Padding(1);
            this.num7.Size = new System.Drawing.Size(182, 128);
            this.num7.TabIndex = 18;
            this.num7.Text = "7";
            this.num7.UseVisualStyleBackColor = true;
            this.num7.Click += new System.EventHandler(this.numClick);
            // 
            // butClear
            // 
            this.butClear.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butClear.Location = new System.Drawing.Point(209, 194);
            this.butClear.MinimumSize = new System.Drawing.Size(158, 114);
            this.butClear.Name = "butClear";
            this.butClear.Padding = new System.Windows.Forms.Padding(1);
            this.butClear.Size = new System.Drawing.Size(381, 276);
            this.butClear.TabIndex = 22;
            this.butClear.TabStop = false;
            this.butClear.Text = "C";
            this.butClear.UseVisualStyleBackColor = true;
            this.butClear.Click += new System.EventHandler(this.butClear_Click);
            // 
            // butPercent
            // 
            this.butPercent.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butPercent.Location = new System.Drawing.Point(21, 195);
            this.butPercent.MinimumSize = new System.Drawing.Size(158, 114);
            this.butPercent.Name = "butPercent";
            this.butPercent.Padding = new System.Windows.Forms.Padding(1);
            this.butPercent.Size = new System.Drawing.Size(182, 276);
            this.butPercent.TabIndex = 24;
            this.butPercent.Text = "%";
            this.butPercent.UseVisualStyleBackColor = true;
            this.butPercent.Click += new System.EventHandler(this.butPercent_Click);
            // 
            // simpleCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 1061);
            this.Controls.Add(this.butPercent);
            this.Controls.Add(this.butClear);
            this.Controls.Add(this.num7);
            this.Controls.Add(this.num8);
            this.Controls.Add(this.num9);
            this.Controls.Add(this.num4);
            this.Controls.Add(this.num5);
            this.Controls.Add(this.num6);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.num3);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num0);
            this.Controls.Add(this.butDecimal);
            this.Controls.Add(this.butBackSpace);
            this.Controls.Add(this.butDivide);
            this.Controls.Add(this.butMultiply);
            this.Controls.Add(this.butMinus);
            this.Controls.Add(this.butPlus);
            this.Controls.Add(this.butEqual);
            this.Controls.Add(this.numDisplay);
            this.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.MinimumSize = new System.Drawing.Size(158, 114);
            this.Name = "simpleCalculator";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.Text = "Texas Instrument";
            this.Load += new System.EventHandler(this.simpleCalculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numDisplay;
        private System.Windows.Forms.Button butEqual;
        private System.Windows.Forms.Button butPlus;
        private System.Windows.Forms.Button butMinus;
        private System.Windows.Forms.Button butMultiply;
        private System.Windows.Forms.Button butDivide;
        private System.Windows.Forms.Button butBackSpace;
        private System.Windows.Forms.Button butDecimal;
        private System.Windows.Forms.Button num0;
        private System.Windows.Forms.Button num2;
        private System.Windows.Forms.Button num3;
        private System.Windows.Forms.Button num1;
        private System.Windows.Forms.Button num6;
        private System.Windows.Forms.Button num5;
        private System.Windows.Forms.Button num4;
        private System.Windows.Forms.Button num9;
        private System.Windows.Forms.Button num8;
        private System.Windows.Forms.Button num7;
        private System.Windows.Forms.Button butClear;
        private System.Windows.Forms.Button butPercent;
    }
}

