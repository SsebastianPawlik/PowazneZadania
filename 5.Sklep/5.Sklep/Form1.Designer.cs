namespace _5.Sklep
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BTwyswietl = new System.Windows.Forms.Button();
            this.BTdodaj = new System.Windows.Forms.Button();
            this.BTedytuj = new System.Windows.Forms.Button();
            this.BTskasuj = new System.Windows.Forms.Button();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbNazwa = new System.Windows.Forms.TextBox();
            this.tbKategoria = new System.Windows.Forms.TextBox();
            this.tbTresc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(648, 261);
            this.dataGridView1.TabIndex = 0;
            // 
            // BTwyswietl
            // 
            this.BTwyswietl.Location = new System.Drawing.Point(12, 279);
            this.BTwyswietl.Name = "BTwyswietl";
            this.BTwyswietl.Size = new System.Drawing.Size(75, 23);
            this.BTwyswietl.TabIndex = 1;
            this.BTwyswietl.Text = "Wyświetl";
            this.BTwyswietl.UseVisualStyleBackColor = true;
            this.BTwyswietl.Click += new System.EventHandler(this.BTwyswietl_Click);
            // 
            // BTdodaj
            // 
            this.BTdodaj.Location = new System.Drawing.Point(93, 279);
            this.BTdodaj.Name = "BTdodaj";
            this.BTdodaj.Size = new System.Drawing.Size(75, 23);
            this.BTdodaj.TabIndex = 2;
            this.BTdodaj.Text = "Dodaj";
            this.BTdodaj.UseVisualStyleBackColor = true;
            this.BTdodaj.Click += new System.EventHandler(this.BTdodaj_Click);
            // 
            // BTedytuj
            // 
            this.BTedytuj.Location = new System.Drawing.Point(174, 279);
            this.BTedytuj.Name = "BTedytuj";
            this.BTedytuj.Size = new System.Drawing.Size(75, 23);
            this.BTedytuj.TabIndex = 3;
            this.BTedytuj.Text = "Edytuj";
            this.BTedytuj.UseVisualStyleBackColor = true;
            this.BTedytuj.Click += new System.EventHandler(this.BTedytuj_Click);
            // 
            // BTskasuj
            // 
            this.BTskasuj.Location = new System.Drawing.Point(255, 279);
            this.BTskasuj.Name = "BTskasuj";
            this.BTskasuj.Size = new System.Drawing.Size(75, 23);
            this.BTskasuj.TabIndex = 4;
            this.BTskasuj.Text = "Skasuj";
            this.BTskasuj.UseVisualStyleBackColor = true;
            this.BTskasuj.Click += new System.EventHandler(this.BTskasuj_Click);
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(12, 321);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(100, 20);
            this.tbID.TabIndex = 5;
            this.tbID.TextChanged += new System.EventHandler(this.tbID_TextChanged);
            // 
            // tbNazwa
            // 
            this.tbNazwa.Location = new System.Drawing.Point(118, 321);
            this.tbNazwa.Name = "tbNazwa";
            this.tbNazwa.Size = new System.Drawing.Size(100, 20);
            this.tbNazwa.TabIndex = 6;
            // 
            // tbKategoria
            // 
            this.tbKategoria.Location = new System.Drawing.Point(224, 321);
            this.tbKategoria.Name = "tbKategoria";
            this.tbKategoria.Size = new System.Drawing.Size(100, 20);
            this.tbKategoria.TabIndex = 7;
            // 
            // tbTresc
            // 
            this.tbTresc.Location = new System.Drawing.Point(330, 321);
            this.tbTresc.Name = "tbTresc";
            this.tbTresc.Size = new System.Drawing.Size(100, 20);
            this.tbTresc.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nazwa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(224, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Kategoria";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(330, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Treść";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 352);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbTresc);
            this.Controls.Add(this.tbKategoria);
            this.Controls.Add(this.tbNazwa);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.BTskasuj);
            this.Controls.Add(this.BTedytuj);
            this.Controls.Add(this.BTdodaj);
            this.Controls.Add(this.BTwyswietl);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BTwyswietl;
        private System.Windows.Forms.Button BTdodaj;
        private System.Windows.Forms.Button BTedytuj;
        private System.Windows.Forms.Button BTskasuj;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tbNazwa;
        private System.Windows.Forms.TextBox tbKategoria;
        private System.Windows.Forms.TextBox tbTresc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

