using Odev0308.İnterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev0308
{
    class Porsche : Araba , IHavadaUcar
    {
        public void Uc(string marka)
        {
            Console.WriteLine(marka+" "+"Havada uçar"); 
        }

        public override double YakitTüketimi()
        {
            return 70;
        }
    }
}
