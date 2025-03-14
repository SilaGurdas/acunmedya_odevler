﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev
{
    class YasKategori
    {
        public static string Hesapla(int yas)
        {
            if (yas < 0 || yas > 99)
                return "Ya hiç doğmadınız ya da çoktan öldünüz...";
            else if (yas < 18)
                return "Küçüksünüz";
            else if (yas < 35)
                return "Gençsiniz";
            else if (yas < 55)
                return "Yetişkinsiniz";
            else if (yas < 75)
                return "Yaşlısınız";
            else
                return "Çok yaşlısınız";
        }





    }
}
