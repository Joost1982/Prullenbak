namespace PartyPlanner2
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.kostenLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gezondCheckbox = new System.Windows.Forms.CheckBox();
            this.fancyCheckbox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.TeLangLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BirthdayKostenLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.FancyShitCheckboxBirthday = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft YaHei Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(210, 240);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.kostenLabel);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.gezondCheckbox);
            this.tabPage1.Controls.Add(this.fancyCheckbox);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.numericUpDown1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(202, 211);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dinner Party";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // kostenLabel
            // 
            this.kostenLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.kostenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kostenLabel.Location = new System.Drawing.Point(78, 151);
            this.kostenLabel.Name = "kostenLabel";
            this.kostenLabel.Size = new System.Drawing.Size(83, 22);
            this.kostenLabel.TabIndex = 11;
            this.kostenLabel.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Kosten:";
            // 
            // gezondCheckbox
            // 
            this.gezondCheckbox.AutoSize = true;
            this.gezondCheckbox.Location = new System.Drawing.Point(6, 91);
            this.gezondCheckbox.Name = "gezondCheckbox";
            this.gezondCheckbox.Size = new System.Drawing.Size(167, 20);
            this.gezondCheckbox.TabIndex = 9;
            this.gezondCheckbox.Text = "Gezonde Shit / geen alcohol";
            this.gezondCheckbox.UseVisualStyleBackColor = true;
            this.gezondCheckbox.CheckedChanged += new System.EventHandler(this.gezondCheckbox_CheckedChanged_1);
            // 
            // fancyCheckbox
            // 
            this.fancyCheckbox.AutoSize = true;
            this.fancyCheckbox.Location = new System.Drawing.Point(6, 65);
            this.fancyCheckbox.Name = "fancyCheckbox";
            this.fancyCheckbox.Size = new System.Drawing.Size(127, 20);
            this.fancyCheckbox.TabIndex = 8;
            this.fancyCheckbox.Text = "Fancy Decoratie Shit";
            this.fancyCheckbox.UseVisualStyleBackColor = true;
            this.fancyCheckbox.CheckedChanged += new System.EventHandler(this.fancyCheckbox_CheckedChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Aantal mensen";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(3, 28);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 6;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.TeLangLabel);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.BirthdayKostenLabel);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.FancyShitCheckboxBirthday);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.numericUpDown2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(202, 211);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Birthday Party";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // TeLangLabel
            // 
            this.TeLangLabel.AutoSize = true;
            this.TeLangLabel.BackColor = System.Drawing.Color.Red;
            this.TeLangLabel.Location = new System.Drawing.Point(93, 93);
            this.TeLangLabel.Name = "TeLangLabel";
            this.TeLangLabel.Size = new System.Drawing.Size(65, 16);
            this.TeLangLabel.TabIndex = 14;
            this.TeLangLabel.Text = "TOO LONG";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Cake writing";
            // 
            // BirthdayKostenLabel
            // 
            this.BirthdayKostenLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BirthdayKostenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BirthdayKostenLabel.Location = new System.Drawing.Point(78, 150);
            this.BirthdayKostenLabel.Name = "BirthdayKostenLabel";
            this.BirthdayKostenLabel.Size = new System.Drawing.Size(83, 22);
            this.BirthdayKostenLabel.TabIndex = 11;
            this.BirthdayKostenLabel.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(2, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Kosten:";
            // 
            // FancyShitCheckboxBirthday
            // 
            this.FancyShitCheckboxBirthday.AutoSize = true;
            this.FancyShitCheckboxBirthday.Location = new System.Drawing.Point(6, 65);
            this.FancyShitCheckboxBirthday.Name = "FancyShitCheckboxBirthday";
            this.FancyShitCheckboxBirthday.Size = new System.Drawing.Size(127, 20);
            this.FancyShitCheckboxBirthday.TabIndex = 8;
            this.FancyShitCheckboxBirthday.Text = "Fancy Decoratie Shit";
            this.FancyShitCheckboxBirthday.UseVisualStyleBackColor = true;
            this.FancyShitCheckboxBirthday.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Aantal mensen";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(3, 28);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown2.TabIndex = 6;
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(5, 116);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 22);
            this.textBox1.TabIndex = 15;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 242);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label kostenLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox gezondCheckbox;
        private System.Windows.Forms.CheckBox fancyCheckbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label BirthdayKostenLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox FancyShitCheckboxBirthday;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label TeLangLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
    }
}

