namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Label();
            this.minus = new System.Windows.Forms.Label();
            this.muliply = new System.Windows.Forms.Label();
            this.divide = new System.Windows.Forms.Label();
            this.buttonDot = new System.Windows.Forms.Button();
            this.buttonResult = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBox
            // 
            this.txtBox.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBox.Location = new System.Drawing.Point(12, 26);
            this.txtBox.Name = "txtBox";
            this.txtBox.ReadOnly = true;
            this.txtBox.Size = new System.Drawing.Size(300, 43);
            this.txtBox.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonDot_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(98, 84);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonDot_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(191, 84);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.buttonDot_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(17, 134);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.buttonDot_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(98, 134);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.buttonDot_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(191, 134);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 6;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.buttonDot_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(17, 179);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 7;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.buttonDot_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(98, 179);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 8;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.buttonDot_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(191, 179);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 9;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.buttonDot_Click);
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(98, 219);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(75, 23);
            this.button0.TabIndex = 10;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.buttonDot_Click);
            // 
            // plus
            // 
            this.plus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plus.Location = new System.Drawing.Point(289, 88);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(23, 23);
            this.plus.TabIndex = 11;
            this.plus.Text = "+";
            this.plus.Click += new System.EventHandler(this.divide_Click);
            // 
            // minus
            // 
            this.minus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.minus.Location = new System.Drawing.Point(289, 134);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(23, 23);
            this.minus.TabIndex = 12;
            this.minus.Text = "-";
            this.minus.Click += new System.EventHandler(this.divide_Click);
            // 
            // muliply
            // 
            this.muliply.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.muliply.Location = new System.Drawing.Point(289, 183);
            this.muliply.Name = "muliply";
            this.muliply.Size = new System.Drawing.Size(23, 19);
            this.muliply.TabIndex = 13;
            this.muliply.Text = "*";
            this.muliply.Click += new System.EventHandler(this.divide_Click);
            // 
            // divide
            // 
            this.divide.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.divide.Location = new System.Drawing.Point(289, 219);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(23, 23);
            this.divide.TabIndex = 14;
            this.divide.Text = "/";
            this.divide.Click += new System.EventHandler(this.divide_Click);
            // 
            // buttonDot
            // 
            this.buttonDot.Location = new System.Drawing.Point(17, 219);
            this.buttonDot.Name = "buttonDot";
            this.buttonDot.Size = new System.Drawing.Size(75, 23);
            this.buttonDot.TabIndex = 15;
            this.buttonDot.Text = ".";
            this.buttonDot.UseVisualStyleBackColor = true;
            this.buttonDot.Click += new System.EventHandler(this.buttonDot_Click);
            // 
            // buttonResult
            // 
            this.buttonResult.Location = new System.Drawing.Point(17, 259);
            this.buttonResult.Name = "buttonResult";
            this.buttonResult.Size = new System.Drawing.Size(249, 23);
            this.buttonResult.TabIndex = 16;
            this.buttonResult.Text = "=";
            this.buttonResult.UseVisualStyleBackColor = true;
            this.buttonResult.Click += new System.EventHandler(this.buttonResult_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(191, 219);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 23);
            this.Clear.TabIndex = 17;
            this.Clear.Text = "C";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 292);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.buttonResult);
            this.Controls.Add(this.buttonDot);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.muliply);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBox);
            this.Name = "Form1";
            this.Text = "CalculatorApp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtBox;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button0;
        private Label plus;
        private Label minus;
        private Label muliply;
        private Label divide;
        private Button buttonDot;
        private Button buttonResult;
        private Button Clear;
    }
}