namespace WinForms2Home
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
            this.Loadtxt = new System.Windows.Forms.TextBox();
            this.Loadbtn = new System.Windows.Forms.Button();
            this.AnketGb = new System.Windows.Forms.GroupBox();
            this.Femalerb = new System.Windows.Forms.RadioButton();
            this.Malerb = new System.Windows.Forms.RadioButton();
            this.Genderlbl = new System.Windows.Forms.Label();
            this.Birthdatedp = new System.Windows.Forms.DateTimePicker();
            this.Bdatelbl = new System.Windows.Forms.Label();
            this.Phonetxt = new System.Windows.Forms.TextBox();
            this.Citytxt = new System.Windows.Forms.TextBox();
            this.Countrytxt = new System.Windows.Forms.TextBox();
            this.Phonelbl = new System.Windows.Forms.Label();
            this.Citylbl = new System.Windows.Forms.Label();
            this.Conutrylbl = new System.Windows.Forms.Label();
            this.Fathertxt = new System.Windows.Forms.TextBox();
            this.Nametxt = new System.Windows.Forms.TextBox();
            this.Fatherlbl = new System.Windows.Forms.Label();
            this.Namelbl = new System.Windows.Forms.Label();
            this.Surnametxt = new System.Windows.Forms.TextBox();
            this.Surnamelb = new System.Windows.Forms.Label();
            this.Savebtn = new System.Windows.Forms.Button();
            this.AnketGb.SuspendLayout();
            this.SuspendLayout();
            // 
            // Loadtxt
            // 
            this.Loadtxt.Location = new System.Drawing.Point(53, 11);
            this.Loadtxt.Name = "Loadtxt";
            this.Loadtxt.Size = new System.Drawing.Size(100, 23);
            this.Loadtxt.TabIndex = 0;
            // 
            // Loadbtn
            // 
            this.Loadbtn.Location = new System.Drawing.Point(175, 12);
            this.Loadbtn.Name = "Loadbtn";
            this.Loadbtn.Size = new System.Drawing.Size(75, 23);
            this.Loadbtn.TabIndex = 1;
            this.Loadbtn.Text = "Load";
            this.Loadbtn.UseVisualStyleBackColor = true;
            this.Loadbtn.Click += new System.EventHandler(this.Loadbtn_Click);
            // 
            // AnketGb
            // 
            this.AnketGb.Controls.Add(this.Femalerb);
            this.AnketGb.Controls.Add(this.Malerb);
            this.AnketGb.Controls.Add(this.Genderlbl);
            this.AnketGb.Controls.Add(this.Birthdatedp);
            this.AnketGb.Controls.Add(this.Bdatelbl);
            this.AnketGb.Controls.Add(this.Phonetxt);
            this.AnketGb.Controls.Add(this.Citytxt);
            this.AnketGb.Controls.Add(this.Countrytxt);
            this.AnketGb.Controls.Add(this.Phonelbl);
            this.AnketGb.Controls.Add(this.Citylbl);
            this.AnketGb.Controls.Add(this.Conutrylbl);
            this.AnketGb.Controls.Add(this.Fathertxt);
            this.AnketGb.Controls.Add(this.Nametxt);
            this.AnketGb.Controls.Add(this.Fatherlbl);
            this.AnketGb.Controls.Add(this.Namelbl);
            this.AnketGb.Controls.Add(this.Surnametxt);
            this.AnketGb.Controls.Add(this.Surnamelb);
            this.AnketGb.Location = new System.Drawing.Point(12, 59);
            this.AnketGb.Name = "AnketGb";
            this.AnketGb.Size = new System.Drawing.Size(309, 327);
            this.AnketGb.TabIndex = 2;
            this.AnketGb.TabStop = false;
            this.AnketGb.Text = "Anket";
            // 
            // Femalerb
            // 
            this.Femalerb.AutoSize = true;
            this.Femalerb.Location = new System.Drawing.Point(147, 276);
            this.Femalerb.Name = "Femalerb";
            this.Femalerb.Size = new System.Drawing.Size(63, 19);
            this.Femalerb.TabIndex = 18;
            this.Femalerb.TabStop = true;
            this.Femalerb.Text = "Female";
            this.Femalerb.UseVisualStyleBackColor = true;
            // 
            // Malerb
            // 
            this.Malerb.AutoSize = true;
            this.Malerb.Location = new System.Drawing.Point(90, 276);
            this.Malerb.Name = "Malerb";
            this.Malerb.Size = new System.Drawing.Size(51, 19);
            this.Malerb.TabIndex = 17;
            this.Malerb.TabStop = true;
            this.Malerb.Text = "Male";
            this.Malerb.UseVisualStyleBackColor = true;
            // 
            // Genderlbl
            // 
            this.Genderlbl.AutoSize = true;
            this.Genderlbl.Location = new System.Drawing.Point(3, 278);
            this.Genderlbl.Name = "Genderlbl";
            this.Genderlbl.Size = new System.Drawing.Size(45, 15);
            this.Genderlbl.TabIndex = 16;
            this.Genderlbl.Text = "Gender";
            // 
            // Birthdatedp
            // 
            this.Birthdatedp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Birthdatedp.Location = new System.Drawing.Point(90, 237);
            this.Birthdatedp.Name = "Birthdatedp";
            this.Birthdatedp.Size = new System.Drawing.Size(120, 23);
            this.Birthdatedp.TabIndex = 15;
            // 
            // Bdatelbl
            // 
            this.Bdatelbl.AutoSize = true;
            this.Bdatelbl.Location = new System.Drawing.Point(3, 243);
            this.Bdatelbl.Name = "Bdatelbl";
            this.Bdatelbl.Size = new System.Drawing.Size(59, 15);
            this.Bdatelbl.TabIndex = 14;
            this.Bdatelbl.Text = "Birth Date";
            // 
            // Phonetxt
            // 
            this.Phonetxt.Location = new System.Drawing.Point(90, 192);
            this.Phonetxt.Name = "Phonetxt";
            this.Phonetxt.PlaceholderText = "Phone number";
            this.Phonetxt.Size = new System.Drawing.Size(120, 23);
            this.Phonetxt.TabIndex = 13;
            // 
            // Citytxt
            // 
            this.Citytxt.Location = new System.Drawing.Point(90, 163);
            this.Citytxt.Name = "Citytxt";
            this.Citytxt.PlaceholderText = "City";
            this.Citytxt.Size = new System.Drawing.Size(120, 23);
            this.Citytxt.TabIndex = 12;
            // 
            // Countrytxt
            // 
            this.Countrytxt.Location = new System.Drawing.Point(90, 131);
            this.Countrytxt.Name = "Countrytxt";
            this.Countrytxt.PlaceholderText = "Country";
            this.Countrytxt.Size = new System.Drawing.Size(120, 23);
            this.Countrytxt.TabIndex = 11;
            // 
            // Phonelbl
            // 
            this.Phonelbl.AutoSize = true;
            this.Phonelbl.Location = new System.Drawing.Point(6, 197);
            this.Phonelbl.Name = "Phonelbl";
            this.Phonelbl.Size = new System.Drawing.Size(41, 15);
            this.Phonelbl.TabIndex = 10;
            this.Phonelbl.Text = "Phone";
            // 
            // Citylbl
            // 
            this.Citylbl.AutoSize = true;
            this.Citylbl.Location = new System.Drawing.Point(6, 171);
            this.Citylbl.Name = "Citylbl";
            this.Citylbl.Size = new System.Drawing.Size(28, 15);
            this.Citylbl.TabIndex = 9;
            this.Citylbl.Text = "City";
            // 
            // Conutrylbl
            // 
            this.Conutrylbl.AutoSize = true;
            this.Conutrylbl.Location = new System.Drawing.Point(6, 139);
            this.Conutrylbl.Name = "Conutrylbl";
            this.Conutrylbl.Size = new System.Drawing.Size(50, 15);
            this.Conutrylbl.TabIndex = 8;
            this.Conutrylbl.Text = "Country";
            // 
            // Fathertxt
            // 
            this.Fathertxt.Location = new System.Drawing.Point(90, 82);
            this.Fathertxt.Name = "Fathertxt";
            this.Fathertxt.PlaceholderText = "Father\'s name";
            this.Fathertxt.Size = new System.Drawing.Size(120, 23);
            this.Fathertxt.TabIndex = 7;
            // 
            // Nametxt
            // 
            this.Nametxt.Location = new System.Drawing.Point(90, 53);
            this.Nametxt.Name = "Nametxt";
            this.Nametxt.PlaceholderText = "Name";
            this.Nametxt.Size = new System.Drawing.Size(120, 23);
            this.Nametxt.TabIndex = 6;
            // 
            // Fatherlbl
            // 
            this.Fatherlbl.AutoSize = true;
            this.Fatherlbl.Location = new System.Drawing.Point(3, 85);
            this.Fatherlbl.Name = "Fatherlbl";
            this.Fatherlbl.Size = new System.Drawing.Size(81, 15);
            this.Fatherlbl.TabIndex = 5;
            this.Fatherlbl.Text = "Father\'s name";
            // 
            // Namelbl
            // 
            this.Namelbl.AutoSize = true;
            this.Namelbl.Location = new System.Drawing.Point(6, 56);
            this.Namelbl.Name = "Namelbl";
            this.Namelbl.Size = new System.Drawing.Size(39, 15);
            this.Namelbl.TabIndex = 4;
            this.Namelbl.Text = "Name";
            // 
            // Surnametxt
            // 
            this.Surnametxt.Location = new System.Drawing.Point(90, 19);
            this.Surnametxt.Name = "Surnametxt";
            this.Surnametxt.PlaceholderText = "Surname";
            this.Surnametxt.Size = new System.Drawing.Size(120, 23);
            this.Surnametxt.TabIndex = 3;
            // 
            // Surnamelb
            // 
            this.Surnamelb.AutoSize = true;
            this.Surnamelb.Location = new System.Drawing.Point(6, 22);
            this.Surnamelb.Name = "Surnamelb";
            this.Surnamelb.Size = new System.Drawing.Size(54, 15);
            this.Surnamelb.TabIndex = 0;
            this.Surnamelb.Text = "Surname";
            // 
            // Savebtn
            // 
            this.Savebtn.Location = new System.Drawing.Point(44, 392);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(219, 23);
            this.Savebtn.TabIndex = 3;
            this.Savebtn.Text = "Save";
            this.Savebtn.UseVisualStyleBackColor = true;
            this.Savebtn.Click += new System.EventHandler(this.Savebtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 422);
            this.Controls.Add(this.Savebtn);
            this.Controls.Add(this.AnketGb);
            this.Controls.Add(this.Loadbtn);
            this.Controls.Add(this.Loadtxt);
            this.Name = "Form1";
            this.Text = "Anket";
            this.AnketGb.ResumeLayout(false);
            this.AnketGb.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox Loadtxt;
        private Button Loadbtn;
        private GroupBox AnketGb;
        private TextBox Fathertxt;
        private TextBox Nametxt;
        private Label Fatherlbl;
        private Label Namelbl;
        private TextBox Surnametxt;
        private Label Surnamelb;
        private RadioButton Femalerb;
        private RadioButton Malerb;
        private Label Genderlbl;
        private DateTimePicker Birthdatedp;
        private Label Bdatelbl;
        private TextBox Phonetxt;
        private TextBox Citytxt;
        private TextBox Countrytxt;
        private Label Phonelbl;
        private Label Citylbl;
        private Label Conutrylbl;
        private Button Savebtn;
    }
}