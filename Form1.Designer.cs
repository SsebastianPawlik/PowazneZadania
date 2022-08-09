namespace _2.KompresjaSzyfrowanie
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.Kompresja = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.Dekompresja = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Plik = new System.Windows.Forms.TextBox();
            this.WybierzPlik = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Plik2 = new System.Windows.Forms.TextBox();
            this.WybierzPlik2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dekompresjamiejsce = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Kompresja
            // 
            this.Kompresja.Location = new System.Drawing.Point(11, 113);
            this.Kompresja.Name = "Kompresja";
            this.Kompresja.Size = new System.Drawing.Size(81, 23);
            this.Kompresja.TabIndex = 0;
            this.Kompresja.Text = "Kompresja";
            this.Kompresja.UseVisualStyleBackColor = true;
            this.Kompresja.Click += new System.EventHandler(this.button1_Click);
            // 
            // Dekompresja
            // 
            this.Dekompresja.Location = new System.Drawing.Point(11, 142);
            this.Dekompresja.Name = "Dekompresja";
            this.Dekompresja.Size = new System.Drawing.Size(81, 23);
            this.Dekompresja.TabIndex = 3;
            this.Dekompresja.Text = "Dekompresja";
            this.Dekompresja.UseVisualStyleBackColor = true;
            this.Dekompresja.Click += new System.EventHandler(this.Dekompresja_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(107, 142);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "deszyfracja";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Szyfrowanie/Deszyfrowanie/Dekompresja";
            // 
            // Plik
            // 
            this.Plik.Location = new System.Drawing.Point(219, 9);
            this.Plik.Name = "Plik";
            this.Plik.Size = new System.Drawing.Size(346, 20);
            this.Plik.TabIndex = 6;
            // 
            // WybierzPlik
            // 
            this.WybierzPlik.Location = new System.Drawing.Point(571, 9);
            this.WybierzPlik.Name = "WybierzPlik";
            this.WybierzPlik.Size = new System.Drawing.Size(34, 23);
            this.WybierzPlik.TabIndex = 7;
            this.WybierzPlik.Text = "...";
            this.WybierzPlik.UseVisualStyleBackColor = true;
            this.WybierzPlik.Click += new System.EventHandler(this.WybierzPlik_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(107, 113);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "szyfrowanie";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Kompresja";
            // 
            // Plik2
            // 
            this.Plik2.Location = new System.Drawing.Point(70, 35);
            this.Plik2.Name = "Plik2";
            this.Plik2.Size = new System.Drawing.Size(495, 20);
            this.Plik2.TabIndex = 10;
            // 
            // WybierzPlik2
            // 
            this.WybierzPlik2.Location = new System.Drawing.Point(571, 33);
            this.WybierzPlik2.Name = "WybierzPlik2";
            this.WybierzPlik2.Size = new System.Drawing.Size(34, 23);
            this.WybierzPlik2.TabIndex = 11;
            this.WybierzPlik2.Text = "...";
            this.WybierzPlik2.UseVisualStyleBackColor = true;
            this.WybierzPlik2.Click += new System.EventHandler(this.WybierzPlik2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Hasło";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(70, 87);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(495, 20);
            this.textBox1.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Lokalizacja po dekompresji";
            // 
            // dekompresjamiejsce
            // 
            this.dekompresjamiejsce.Location = new System.Drawing.Point(148, 61);
            this.dekompresjamiejsce.Name = "dekompresjamiejsce";
            this.dekompresjamiejsce.Size = new System.Drawing.Size(417, 20);
            this.dekompresjamiejsce.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(571, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 207);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dekompresjamiejsce);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.WybierzPlik2);
            this.Controls.Add(this.Plik2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.WybierzPlik);
            this.Controls.Add(this.Plik);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Dekompresja);
            this.Controls.Add(this.Kompresja);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Kompresja;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button Dekompresja;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Plik;
        private System.Windows.Forms.Button WybierzPlik;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Plik2;
        private System.Windows.Forms.Button WybierzPlik2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox dekompresjamiejsce;
        private System.Windows.Forms.Button button1;
    }
}

