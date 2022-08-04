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
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.Dekompresja = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Plik = new System.Windows.Forms.TextBox();
            this.WybierzPlik = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Kompresja";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 130);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(150, 17);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Szyfrowanie asymetryczne";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(11, 153);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(144, 17);
            this.checkBox2.TabIndex = 2;
            this.checkBox2.Text = "Szyfrowanie symetryczne";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // Dekompresja
            // 
            this.Dekompresja.Location = new System.Drawing.Point(92, 69);
            this.Dekompresja.Name = "Dekompresja";
            this.Dekompresja.Size = new System.Drawing.Size(81, 23);
            this.Dekompresja.TabIndex = 3;
            this.Dekompresja.Text = "Dekompresja";
            this.Dekompresja.UseVisualStyleBackColor = true;
            this.Dekompresja.Click += new System.EventHandler(this.Dekompresja_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(335, 69);
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
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ścieżka kompresja";
            // 
            // Plik
            // 
            this.Plik.Location = new System.Drawing.Point(115, 10);
            this.Plik.Name = "Plik";
            this.Plik.Size = new System.Drawing.Size(346, 20);
            this.Plik.TabIndex = 6;
            // 
            // WybierzPlik
            // 
            this.WybierzPlik.Location = new System.Drawing.Point(469, 8);
            this.WybierzPlik.Name = "WybierzPlik";
            this.WybierzPlik.Size = new System.Drawing.Size(34, 23);
            this.WybierzPlik.TabIndex = 7;
            this.WybierzPlik.Text = "...";
            this.WybierzPlik.UseVisualStyleBackColor = true;
            this.WybierzPlik.Click += new System.EventHandler(this.WybierzPlik_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(219, 69);
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
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ścieżka kompresja";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(114, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(346, 20);
            this.textBox1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 213);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.WybierzPlik);
            this.Controls.Add(this.Plik);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Dekompresja);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button Dekompresja;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Plik;
        private System.Windows.Forms.Button WybierzPlik;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

