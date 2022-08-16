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
        string koncowy = "";
        public Form1()
        {
            InitializeComponent();
        }
        static string kodujRLE(string dane)
        {
            string wynik = "";
            int licznik = 0;
            char c = dane[0];
            for (int i = 0; i < dane.Length; i++)
            {
                if (dane[i] == c)
                {
                    licznik++;
                }
                else
                {
                    dopisz(ref wynik, c, licznik);
                    c = dane[i];
                    licznik = 1;
                }
            }
            dopisz(ref wynik, c, licznik);
            return wynik;
        }
        static void dopisz(ref string str, char c, int licznik)
        {
            if (licznik > 0)
            {
                str += c;
                if (licznik > 1)
                {
                    str += licznik.ToString() + " + ";
                }
            }
            /* while (licznik > 0)
             {
                 int ile = licznik >= 1000 ? 1000 : licznik;
                 licznik -= ile;
                 str += c;
                 str += ile.ToString();
             }*/
        }
        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < richTextBox1.TextLength; i++)
            {
                koncowy = kodujRLE(richTextBox1.Text);
            }
            richTextBox2.Text = koncowy;
        }
        static string dekodujRLE(string dane)
        {
            string wynik = "";
            for (int i = 0; i < dane.Length; i += 2)
            {
                int ile = dane[i + 1] - '0';
                while (ile -- > 0)
                {
                    wynik += dane[i];
                }
            }
            return wynik;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < richTextBox1.TextLength; i++)
            {
                koncowy = dekodujRLE(richTextBox1.Text);
            }
            richTextBox2.Text = koncowy;
        }
    }
}
