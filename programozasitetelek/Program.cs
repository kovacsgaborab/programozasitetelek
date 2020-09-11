using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programozasitetelek
{
    class Program
    {
        static int[] tomb = new int[] {12, 7, 2, 4, 45, 99, 1, 8, 95, 50};
        static void Main(string[] args)
        {
            tombkiiras();
            osszegzes();
            megszamolas();

            
            Console.ReadKey();
        }

        private static void megszamolas()
        {
            int a = 0;

            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i]%3==0)
                {
                    a++;
                }
            }

            Console.WriteLine("{0} darab 3-mal osztható szám van a tömbben", a);
        }

        private static void osszegzes()
        {
            int osszeg = 0;

            for (int i = 0; i < tomb.Length; i++)
            {
                osszeg += tomb[i];
            }

            Console.WriteLine("\n{0}",osszeg);
        }

        private static void tombkiiras()
        {
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write("{0}, ", tomb[i]);
            }
        }
    }
}
