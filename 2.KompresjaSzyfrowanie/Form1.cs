using System;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
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
        Kompresja archiwum = new Kompresja();
        Szyfrowanie szyfr = new Szyfrowanie();
        public string directoryPath = @"C:\Users\Praktykant\Desktop\Nowy folder\Grafika\Rozdzial_1";

        private void button1_Click(object sender, EventArgs e)
        {
/*            
        DirectoryInfo directorySelected = new DirectoryInfo(directoryPath);
            archiwum.Compress(directorySelected);*/
            FolderBrowserDialog FolderSelect = new FolderBrowserDialog();
            string sciezka = string.Empty;
            if (FolderSelect.ShowDialog() == DialogResult.OK)
            {
                sciezka = FolderSelect.SelectedPath;

            }
            DirectoryInfo Folderinfo = new DirectoryInfo(sciezka);
            foreach (FileInfo plikInfo in Folderinfo.GetFiles())
            {
               archiwum.Compress(plikInfo);
            }
        }

        private void Dekompresja_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FolderSelect = new FolderBrowserDialog();
            string sciezka = string.Empty;
            if (FolderSelect.ShowDialog() == DialogResult.OK)
            {
                sciezka = FolderSelect.SelectedPath;

            }
            DirectoryInfo Folderinfo = new DirectoryInfo(sciezka);
            foreach (FileInfo plikInfo in Folderinfo.GetFiles())
            {
                archiwum.Decompress(plikInfo);
                MessageBox.Show("Test");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
        
        }
            
        
    }
}

