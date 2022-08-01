using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1.KodowanieDekodowanieBase64
{
    internal class kodowanie
    {
       

        public kodowanie(string x)
        {
          
        }
        public string kodowaniee(string x)
        {
            string zakodowane = Convert.ToBase64String(Encoding.UTF8.GetBytes(x));
            
            return string.Format("Zakodowany tekst: {0}", zakodowane);
        }
    }
}
