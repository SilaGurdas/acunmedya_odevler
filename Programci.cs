using Odev0308.İnterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Odev0308
{
    class Programci : Calisan , IMaasHesapla
    {
     
        override public double MaasinizNedir() 
        {
            return 50000;
        }
    }
}
