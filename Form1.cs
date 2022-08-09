using System;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;


namespace _2.KompresjaSzyfrowanie
{
    public partial class Form1 : Form
    {
        byte[] abc;
        byte[,] tabela;
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
                ZipFile.CreateFromDirectory(Plik2.Text, Plik2.Text + ".zip");
        }

        private void Dekompresja_Click(object sender, EventArgs e)
        {
            ZipFile.ExtractToDirectory(Plik.Text, dekompresjamiejsce.Text);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            byte[] fileContent = File.ReadAllBytes(Plik.Text);
            byte[] password = Encoding.ASCII.GetBytes(textBox1.Text);
            byte[] keys = new byte[fileContent.Length];
            for (int i = 0; i < fileContent.Length; i++)
                keys[i] = password[i % password.Length];
            byte[] result = new byte[fileContent.Length];
            
                for (int i = 0; i < fileContent.Length; i++)
                {
                    byte value = fileContent[i];
                    byte key = keys[i];
                    int valueIndex = -1, keyIndex = -1;
                    for (int j = 0; j < 256; j++)
                    {
                        if (abc[j] == value)
                        {
                            valueIndex = j;
                            break;
                        }
                    }
                    for (int j = 0; j < 256; j++)
                    {
                        if (abc[j] == key)
                        {
                            keyIndex = j;
                            break;
                        }
                    }
                    result[i] = tabela[keyIndex, valueIndex];
                }
            string fileExt = Path.GetExtension(Plik.Text);
            SaveFileDialog sd = new SaveFileDialog();
            sd.Filter = "Files (*" + fileExt + ") | *" + fileExt;
            if (sd.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllBytes(sd.FileName, result);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            byte[] fileContent = File.ReadAllBytes(Plik.Text);
            byte[] password = Encoding.ASCII.GetBytes(textBox1.Text);
            byte[] keys = new byte[fileContent.Length];
            for (int i = 0; i < fileContent.Length; i++)
                keys[i] = password[i % password.Length];
            byte[] result = new byte[fileContent.Length];
            for (int i = 0; i < fileContent.Length; i++)
                {
                    byte value = fileContent[i];
                    byte key = keys[i];
                    int valueIndex = -1, keyIndex = -1;

                    for (int j = 0; j < 256; j++)
                    {
                        if (abc[j] == key)
                        {
                            keyIndex = j;
                            break;
                        }
                    }
                    for (int j = 0; j < 256; j++)
                    {
                        if (tabela[keyIndex, j] == value)
                        {
                            valueIndex = j;
                            break;
                        }
                    }
                    result[i] = abc[valueIndex];
                }
            string fileExt = Path.GetExtension(Plik.Text);
            SaveFileDialog sd = new SaveFileDialog();
            sd.Filter = "Files (*" + fileExt + ") | *" + fileExt;
            if (sd.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllBytes(sd.FileName, result);
            }
        }

        private void WybierzPlik_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.Multiselect = true;
            if(od.ShowDialog()== DialogResult.OK)
            {
                Plik.Text = od.FileName;    
            }
            
        }

        private void WybierzPlik2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FolderSelect = new FolderBrowserDialog();

            if (FolderSelect.ShowDialog() == DialogResult.OK)
            {
                      Plik2.Text = FolderSelect.SelectedPath;

            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            abc = new byte[256];
            for (int i=0; i<256; i++)
            {
                abc[i] = Convert.ToByte(i);
            }
            tabela = new byte[256, 256];
            for (int i = 0; i <256; i++)
                for (int j = 0; j<256; j++)
                {
                    tabela[i, j] = abc[(i + j) % 256];
                }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FolderBrowserDialog FolderSelect = new FolderBrowserDialog();

            if (FolderSelect.ShowDialog() == DialogResult.OK)
            {
                dekompresjamiejsce.Text = FolderSelect.SelectedPath;

            }
        }
    }
}

