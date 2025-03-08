using Odev0308.İnterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev0308
{
    class BMW : Araba, IDenizdeYuzer, IHavadaUcar, IHizliGider

    {
        public void HizliGit(string marka)
        {
            Console.WriteLine(marka +" "+"Hızlı gider");
        }

        public void Uc(string marka)
        {
            Console.WriteLine(marka +" "+"Havada uçar");
        }

        public override double YakitTüketimi()
        {
            return 90;
        }

        public void Yuz(string marka)
        {
            Console.WriteLine(marka +" "+"Denizde yüzer");
        }
    }
}
