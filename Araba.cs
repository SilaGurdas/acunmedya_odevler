using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev
{
    class Araba
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public double Tuketim { get; set; }

        public static string ArabaDurumu(int yas)
        {
            if (yas < 0 || yas > 30)
                return "Ya hiç üretilmedi ya da trafikten men edilmiştir";
            else if (yas < 10)
                return "Arabanız yeni";
            else if (yas < 20)
                return "Servise götürmeniz gerekebilir";
            else
                return "Arabanız hurdaya çıkabilir";
        }

      
    }
    
}
