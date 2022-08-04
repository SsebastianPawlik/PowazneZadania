using System;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Windows.Forms;


namespace _2.KompresjaSzyfrowanie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string sciezka = string.Empty;
        Szyfrowanie EncryptFile = new Szyfrowanie();
        Deszyfracja DecryptFile = new Deszyfracja();
        string zipPath = @"C:\Users\Praktykant\Desktop\result.zip";
        string extractPath = @"C:\Users\Praktykant\Desktop\extract123";
        
        private void button1_Click(object sender, EventArgs e)
        {
            ZipFile.CreateFromDirectory(sciezka, sciezka + ".zip");
        }

        private void Dekompresja_Click(object sender, EventArgs e)
        {
            ZipFile.ExtractToDirectory(Plik2.Text, Plik3.Text);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Szyfrowanie.EncryptFile(sciezka, extractPath, "1234567898765");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Deszyfracja.DecryptFile(Plik2.Text, extractPath, "1234567898765");
        }

        private void WybierzPlik_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FolderSelect = new FolderBrowserDialog();
            
            if (FolderSelect.ShowDialog() == DialogResult.OK)
            {
                sciezka = FolderSelect.SelectedPath;
                Plik.Text = sciezka;
            }
            
        }

        private void WybierzPlik2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "All files|*.*" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                    Plik2.Text = ofd.FileName;
            }
        }

        private void Docelowa_Click(object sender, EventArgs e)
        {
            
            FolderBrowserDialog FolderSelect = new FolderBrowserDialog();

            if (FolderSelect.ShowDialog() == DialogResult.OK)
            {
                Plik3.Text = FolderSelect.SelectedPath;

            }
        }

    }
}

