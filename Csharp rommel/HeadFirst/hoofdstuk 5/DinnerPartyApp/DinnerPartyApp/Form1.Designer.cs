namespace DinnerPartyApp
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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.fancyCheckbox = new System.Windows.Forms.CheckBox();
            this.gezondCheckbox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.kostenLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(12, 34);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Aantal mensen";
            // 
            // fancyCheckbox
            // 
            this.fancyCheckbox.AutoSize = true;
            this.fancyCheckbox.Location = new System.Drawing.Point(15, 71);
            this.fancyCheckbox.Name = "fancyCheckbox";
            this.fancyCheckbox.Size = new System.Drawing.Size(125, 17);
            this.fancyCheckbox.TabIndex = 2;
            this.fancyCheckbox.Text = "Fancy Decoratie Shit";
            this.fancyCheckbox.UseVisualStyleBackColor = true;
            this.fancyCheckbox.CheckedChanged += new System.EventHandler(this.fancyCheckbox_CheckedChanged);
            // 
            // gezondCheckbox
            // 
            this.gezondCheckbox.AutoSize = true;
            this.gezondCheckbox.Location = new System.Drawing.Point(15, 94);
            this.gezondCheckbox.Name = "gezondCheckbox";
            this.gezondCheckbox.Size = new System.Drawing.Size(162, 17);
            this.gezondCheckbox.TabIndex = 3;
            this.gezondCheckbox.Text = "Gezonde Shit / geen alcohol";
            this.gezondCheckbox.UseVisualStyleBackColor = true;
            this.gezondCheckbox.CheckedChanged += new System.EventHandler(this.gezondCheckbox_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kosten:";
            // 
            // kostenLabel
            // 
            this.kostenLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.kostenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kostenLabel.Location = new System.Drawing.Point(79, 117);
            this.kostenLabel.Name = "kostenLabel";
            this.kostenLabel.Size = new System.Drawing.Size(83, 22);
            this.kostenLabel.TabIndex = 5;
            this.kostenLabel.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(181, 151);
            this.Controls.Add(this.kostenLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gezondCheckbox);
            this.Controls.Add(this.fancyCheckbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Party Planner";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox fancyCheckbox;
        private System.Windows.Forms.CheckBox gezondCheckbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label kostenLabel;
    }
}

