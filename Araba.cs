using Odev0308.İnterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev0308
{
    abstract class Araba : IYakitTüketimi
    {
        public string marka;


        public abstract double YakitTüketimi();

    }
}
