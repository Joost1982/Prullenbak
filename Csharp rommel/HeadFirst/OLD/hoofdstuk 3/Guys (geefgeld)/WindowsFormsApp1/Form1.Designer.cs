namespace WindowsFormsApp1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.joostCashLabel = new System.Windows.Forms.Label();
            this.geertjeCashLabel = new System.Windows.Forms.Label();
            this.bankCashLabel = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(45, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 64);
            this.button1.TabIndex = 0;
            this.button1.Text = "Geef 10 euro aan Geertje";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(205, 226);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 64);
            this.button2.TabIndex = 1;
            this.button2.Text = "Ontvang 5 euro van Joost";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // joostCashLabel
            // 
            this.joostCashLabel.AutoSize = true;
            this.joostCashLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.joostCashLabel.Location = new System.Drawing.Point(51, 81);
            this.joostCashLabel.Name = "joostCashLabel";
            this.joostCashLabel.Size = new System.Drawing.Size(93, 20);
            this.joostCashLabel.TabIndex = 2;
            this.joostCashLabel.Text = "Joost heeft ";
            this.joostCashLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // geertjeCashLabel
            // 
            this.geertjeCashLabel.AutoSize = true;
            this.geertjeCashLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.geertjeCashLabel.Location = new System.Drawing.Point(51, 121);
            this.geertjeCashLabel.Name = "geertjeCashLabel";
            this.geertjeCashLabel.Size = new System.Drawing.Size(107, 20);
            this.geertjeCashLabel.TabIndex = 3;
            this.geertjeCashLabel.Text = "Geertje heeft ";
            this.geertjeCashLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // bankCashLabel
            // 
            this.bankCashLabel.AutoSize = true;
            this.bankCashLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bankCashLabel.Location = new System.Drawing.Point(51, 173);
            this.bankCashLabel.Name = "bankCashLabel";
            this.bankCashLabel.Size = new System.Drawing.Size(110, 20);
            this.bankCashLabel.TabIndex = 4;
            this.bankCashLabel.Text = "De bank heeft";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(45, 306);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(139, 64);
            this.button3.TabIndex = 5;
            this.button3.Text = "Geertje geeft 10 euro aan Joost";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(198, 306);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(139, 64);
            this.button4.TabIndex = 6;
            this.button4.Text = "Joost geeft 5 euro aan Geertje";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 444);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.bankCashLabel);
            this.Controls.Add(this.geertjeCashLabel);
            this.Controls.Add(this.joostCashLabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label joostCashLabel;
        private System.Windows.Forms.Label geertjeCashLabel;
        private System.Windows.Forms.Label bankCashLabel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

