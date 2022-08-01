namespace _1.KodowanieDekodowanieBase64
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
            this.TBKodowanie = new System.Windows.Forms.TextBox();
            this.TBDekodowanie = new System.Windows.Forms.TextBox();
            this.tekst = new System.Windows.Forms.RichTextBox();
            this.Kodowanie = new System.Windows.Forms.Button();
            this.Dekodowanie = new System.Windows.Forms.Button();
            this.lable1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.KodowanieKlasa = new System.Windows.Forms.Button();
            this.DekodowanieKlasa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TBKodowanie
            // 
            this.TBKodowanie.Location = new System.Drawing.Point(12, 25);
            this.TBKodowanie.Name = "TBKodowanie";
            this.TBKodowanie.Size = new System.Drawing.Size(229, 20);
            this.TBKodowanie.TabIndex = 0;
            // 
            // TBDekodowanie
            // 
            this.TBDekodowanie.Location = new System.Drawing.Point(12, 108);
            this.TBDekodowanie.Name = "TBDekodowanie";
            this.TBDekodowanie.Size = new System.Drawing.Size(229, 20);
            this.TBDekodowanie.TabIndex = 1;
            // 
            // tekst
            // 
            this.tekst.Location = new System.Drawing.Point(277, 25);
            this.tekst.Name = "tekst";
            this.tekst.Size = new System.Drawing.Size(161, 103);
            this.tekst.TabIndex = 2;
            this.tekst.Text = "";
            // 
            // Kodowanie
            // 
            this.Kodowanie.Location = new System.Drawing.Point(12, 51);
            this.Kodowanie.Name = "Kodowanie";
            this.Kodowanie.Size = new System.Drawing.Size(75, 23);
            this.Kodowanie.TabIndex = 3;
            this.Kodowanie.Text = "Kodowanie";
            this.Kodowanie.UseVisualStyleBackColor = true;
            this.Kodowanie.Click += new System.EventHandler(this.Kodowanie_Click);
            // 
            // Dekodowanie
            // 
            this.Dekodowanie.Location = new System.Drawing.Point(12, 134);
            this.Dekodowanie.Name = "Dekodowanie";
            this.Dekodowanie.Size = new System.Drawing.Size(75, 23);
            this.Dekodowanie.TabIndex = 4;
            this.Dekodowanie.Text = "Dekodowanie";
            this.Dekodowanie.UseVisualStyleBackColor = true;
            this.Dekodowanie.Click += new System.EventHandler(this.Dekodowanie_Click);
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.Location = new System.Drawing.Point(12, 9);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(60, 13);
            this.lable1.TabIndex = 5;
            this.lable1.Text = "Kodowanie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Dekodowanie";
            // 
            // KodowanieKlasa
            // 
            this.KodowanieKlasa.Location = new System.Drawing.Point(123, 51);
            this.KodowanieKlasa.Name = "KodowanieKlasa";
            this.KodowanieKlasa.Size = new System.Drawing.Size(118, 23);
            this.KodowanieKlasa.TabIndex = 7;
            this.KodowanieKlasa.Text = "KodowanieKlasa";
            this.KodowanieKlasa.UseVisualStyleBackColor = true;
            this.KodowanieKlasa.Click += new System.EventHandler(this.KodowanieKlasa_Click);
            // 
            // DekodowanieKlasa
            // 
            this.DekodowanieKlasa.Location = new System.Drawing.Point(123, 134);
            this.DekodowanieKlasa.Name = "DekodowanieKlasa";
            this.DekodowanieKlasa.Size = new System.Drawing.Size(118, 23);
            this.DekodowanieKlasa.TabIndex = 8;
            this.DekodowanieKlasa.Text = "DekodowanieKlasa";
            this.DekodowanieKlasa.UseVisualStyleBackColor = true;
            this.DekodowanieKlasa.Click += new System.EventHandler(this.DekodowanieKlasa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DekodowanieKlasa);
            this.Controls.Add(this.KodowanieKlasa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lable1);
            this.Controls.Add(this.Dekodowanie);
            this.Controls.Add(this.Kodowanie);
            this.Controls.Add(this.tekst);
            this.Controls.Add(this.TBDekodowanie);
            this.Controls.Add(this.TBKodowanie);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBKodowanie;
        private System.Windows.Forms.TextBox TBDekodowanie;
        private System.Windows.Forms.RichTextBox tekst;
        private System.Windows.Forms.Button Kodowanie;
        private System.Windows.Forms.Button Dekodowanie;
        private System.Windows.Forms.Label lable1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button KodowanieKlasa;
        private System.Windows.Forms.Button DekodowanieKlasa;
    }
}

