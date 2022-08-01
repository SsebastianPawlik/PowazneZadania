using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1.KodowanieDekodowanieBase64
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Kodowanie_Click(object sender, EventArgs e)
        {

            // Bez używania klas

            tekst.Text = "Zakodowany tekst: " + Convert.ToBase64String(Encoding.UTF8.GetBytes(TBKodowanie.Text));
        }
        private void Dekodowanie_Click(object sender, EventArgs e)
        {
            // Bez używania klas

            tekst.Text = "Zdekodowany tekst: " + Encoding.UTF8.GetString(Convert.FromBase64String(TBDekodowanie.Text));
            
        }

        private void KodowanieKlasa_Click(object sender, EventArgs e)
        {
            // Za pomocą klas

            kodowanie kodowanie = new kodowanie(TBKodowanie.Text);
            tekst.Text = kodowanie.kodowaniee(TBKodowanie.Text);
        }

        private void DekodowanieKlasa_Click(object sender, EventArgs e)
        {
            // Za pomocą klas

            dekodowanie dekodowanie = new dekodowanie(TBDekodowanie.Text);
            tekst.Text = dekodowanie.dekodowaniee(TBDekodowanie.Text);
        }
    }
}
