using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1.KodowanieDekodowanieBase64
{
    internal class dekodowanie
    {
 
        public dekodowanie(string x)
        {
            
        }
        public string dekodowaniee(string x)
        {
            string zwyklyTekst = Encoding.UTF8.GetString(Convert.FromBase64String(x));
            
            return string.Format("zdekodowany tekst: {0}", zwyklyTekst);
        }
    }
}
