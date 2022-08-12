using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4.Brainfuck
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] tablica = new int[] { 0, 0, 0, 0, 0, 0, 0, 0 };
        
        private void button1_Click(object sender, EventArgs e)
        {
            char[] znak = new char[] { '>', '<', '[', ']', '.', '+', '-', ',' };
            string[] test = new string[] { richTextBox1.Text};
            
            for (int i = 0; i < richTextBox1.TextLength; i++)
            {
                char[] eee = test[i].ToCharArray();
                if (eee[i] == '>')
                {
                    tablica[0]++;
                    MessageBox.Show("Test");
                }
               else if (richTextBox1.Text == "<")
                {
                    tablica[1]++;
                }
                else if (richTextBox1.Text == ".")
                {
                    tablica[2]++;
                }
                else if (richTextBox1.Text == "+")
                {
                    tablica[3]++;
                }
                else if (richTextBox1.Text == "-")
                {
                    tablica[4]++;
                }
                else if (richTextBox1.Text == "[")
                {
                    tablica[5]++;
                }
                else if (richTextBox1.Text == "]")
                {
                    tablica[6]++;
                }
                else if (richTextBox1.Text == ",")
                {
                    tablica[7]++;
                }
                
            }
            for (int i = 0; i < 8; i++)
            {
                richTextBox2.Text += tablica[i] +""+ znak[i] + " + ";

            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
