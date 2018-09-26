namespace calculatortugas
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.hitung = new System.Windows.Forms.Button();
            this.Operasi = new System.Windows.Forms.ComboBox();
            this.Nilai2 = new System.Windows.Forms.TextBox();
            this.lstHasil = new System.Windows.Forms.TextBox();
            this.Nilai1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nilai A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nilai B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Operasi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(133, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hasil";
            // 
            // hitung
            // 
            this.hitung.Location = new System.Drawing.Point(387, 79);
            this.hitung.Name = "hitung";
            this.hitung.Size = new System.Drawing.Size(75, 33);
            this.hitung.TabIndex = 4;
            this.hitung.Text = "Hitung";
            this.hitung.UseVisualStyleBackColor = true;
            this.hitung.Click += new System.EventHandler(this.button1_Click);
            // 
            // Operasi
            // 
            this.Operasi.FormattingEnabled = true;
            this.Operasi.Items.AddRange(new object[] {
            "Pertambahan",
            "Pengurangan",
            "Perkalian",
            "Pembagian"});
            this.Operasi.Location = new System.Drawing.Point(223, 120);
            this.Operasi.Name = "Operasi";
            this.Operasi.Size = new System.Drawing.Size(121, 24);
            this.Operasi.TabIndex = 5;
            // 
            // Nilai2
            // 
            this.Nilai2.Location = new System.Drawing.Point(223, 84);
            this.Nilai2.Name = "Nilai2";
            this.Nilai2.Size = new System.Drawing.Size(121, 22);
            this.Nilai2.TabIndex = 6;
            // 
            // lstHasil
            // 
            this.lstHasil.Location = new System.Drawing.Point(223, 154);
            this.lstHasil.Name = "lstHasil";
            this.lstHasil.Size = new System.Drawing.Size(121, 22);
            this.lstHasil.TabIndex = 8;
            // 
            // Nilai1
            // 
            this.Nilai1.Location = new System.Drawing.Point(223, 54);
            this.Nilai1.Name = "Nilai1";
            this.Nilai1.Size = new System.Drawing.Size(121, 22);
            this.Nilai1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Nilai1);
            this.Controls.Add(this.lstHasil);
            this.Controls.Add(this.Nilai2);
            this.Controls.Add(this.Operasi);
            this.Controls.Add(this.hitung);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Operasi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button hitung;
        private System.Windows.Forms.ComboBox Operasi;
        private System.Windows.Forms.TextBox Nilai2;
        private System.Windows.Forms.TextBox lstHasil;
        private System.Windows.Forms.TextBox Nilai1;
    }
}

