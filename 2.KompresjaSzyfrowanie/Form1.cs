﻿using System;
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
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> b77e65c58cb4da0ed50cf253e51ea529e042b527
        string extractPath = @"C:\Users\Praktykant\Desktop\extract123";
        
        private void button1_Click(object sender, EventArgs e)
        {
            ZipFile.CreateFromDirectory(sciezka, sciezka + ".zip");
<<<<<<< HEAD
=======
=======
>>>>>>> b77e65c58cb4da0ed50cf253e51ea529e042b527
        string extractPath = @"C:\Users\Praktykant\Desktop\extract";
        
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog pplik = new OpenFileDialog() { Filter = "All files|*.*" };

            string startPath = Plik.Text;


            /*      DirectoryInfo directorySelected = new DirectoryInfo(directoryPath);
                      archiwum.Compress(directorySelected);*/
            /*   FolderBrowserDialog FolderSelect = new FolderBrowserDialog();
               string sciezka = string.Empty;
               if (FolderSelect.ShowDialog() == DialogResult.OK)
               {
                   sciezka = FolderSelect.SelectedPath;
               }
               DirectoryInfo Folderinfo = new DirectoryInfo(sciezka);
               foreach (FileInfo plikInfo in Folderinfo.GetFiles())
               {
                ZipFile.CreateFromDirectory(sciezka, zipPath);
            }*/
            /* using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "All files|*.*" })
             {
                 if (ofd.ShowDialog() == DialogResult.OK)
                     Plik.Text = ofd.FileName;
                 ZipFile.CreateFromDirectory(Plik.Text, zipPath);
             }*/

           // ZipFile.CreateFromDirectory(sciezka, zipPath);

            if (checkBox1.Checked)
            {
                 ZipFile.CreateFromDirectory(sciezka, zipPath);
                 Szyfrowanie.EncryptFile(zipPath, @"C:\Users\Praktykant\Desktop\extract.zip", "1234512345678976");
            }
            else
            {
                ZipFile.CreateFromDirectory(sciezka, zipPath);
            }
<<<<<<< HEAD
=======
>>>>>>> 7e43d2b74099637a1e149b827a085b866bf4d629
>>>>>>> b77e65c58cb4da0ed50cf253e51ea529e042b527
        }

        private void Dekompresja_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> b77e65c58cb4da0ed50cf253e51ea529e042b527
            ZipFile.ExtractToDirectory(Plik2.Text, Plik3.Text);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Szyfrowanie.EncryptFile(sciezka, extractPath, "1234567898765");
<<<<<<< HEAD
=======
=======
>>>>>>> b77e65c58cb4da0ed50cf253e51ea529e042b527
            ZipFile.ExtractToDirectory(zipPath, extractPath);
              FolderBrowserDialog FolderSelect = new FolderBrowserDialog();
              
              if (FolderSelect.ShowDialog() == DialogResult.OK)
              {
                  sciezka = FolderSelect.SelectedPath;

              }
              DirectoryInfo Folderinfo = new DirectoryInfo(sciezka);
              foreach (FileInfo plikInfo in Folderinfo.GetFiles())
              {
                 // archiwum.Decompress(plikInfo);
              }
<<<<<<< HEAD
=======
>>>>>>> 7e43d2b74099637a1e149b827a085b866bf4d629
>>>>>>> b77e65c58cb4da0ed50cf253e51ea529e042b527
        }

        private void button2_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            Deszyfracja.DecryptFile(Plik2.Text, extractPath, "1234567898765");
            Deszyfracja.DecryptFile(@"C:\Users\Praktykant\Desktop\extract.zip", @"C:\Users\Praktykant\Desktop\extractss.zip", "1234512345678976");
=======
<<<<<<< HEAD
            Deszyfracja.DecryptFile(Plik2.Text, extractPath, "1234567898765");
=======
            Deszyfracja.DecryptFile(@"C:\Users\Praktykant\Desktop\extract.zip", @"C:\Users\Praktykant\Desktop\extractss.zip", "1234512345678976");
>>>>>>> 7e43d2b74099637a1e149b827a085b866bf4d629
>>>>>>> b77e65c58cb4da0ed50cf253e51ea529e042b527
        }

        private void WybierzPlik_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FolderSelect = new FolderBrowserDialog();
            
            if (FolderSelect.ShowDialog() == DialogResult.OK)
            {
                sciezka = FolderSelect.SelectedPath;
                Plik.Text = sciezka;
            }
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> b77e65c58cb4da0ed50cf253e51ea529e042b527
            
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

<<<<<<< HEAD
=======
=======
>>>>>>> b77e65c58cb4da0ed50cf253e51ea529e042b527
            DirectoryInfo Folderinfo = new DirectoryInfo(sciezka);

            /*using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "All files|*.*" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                    Plik.Text = ofd.FileName;
            }*/
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {
            Szyfrowanie.EncryptFile(@"C:\Users\Praktykant\Desktop\result.zip", @"C:\Users\Praktykant\Desktop\extract.zip", "1234512345678976");
        }
<<<<<<< HEAD
=======
>>>>>>> 7e43d2b74099637a1e149b827a085b866bf4d629
>>>>>>> b77e65c58cb4da0ed50cf253e51ea529e042b527
    }
}

