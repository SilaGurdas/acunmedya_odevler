using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev
{
    class Dongu
    {
   
            public static void WhileOrnek()
            {
                int i = 0;
                while (i < 10)
                {
                    Console.WriteLine("While döngüsü: " + i);
                    i++;
                }
            }

            public static void DoWhileOrnek()
            {
                int j = 0;
                do
                {
                    Console.WriteLine("Do-while döngüsü: " + j);
                    j++;
                } while (j < 10);
            }
     }
 }

