using Odev0308.İnterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev0308
{
    class Stajyer : Calisan , IMaasHesapla
    {
        public override double MaasinizNedir()
        {
            return 5000;
        }
    }
}
