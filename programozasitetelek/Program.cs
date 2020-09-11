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
            eldontes();
            kivalasztas();
            kereses();
            maximum();
            minimum();

            Console.ReadKey();
        }

        private static void minimum()
        {
            int hely = 0;
            int min = 1;
            for (int i = 0; i < tomb.Length; i++)
            {
                if (min>tomb[i])
                {
                    min = tomb[i];
                    hely = i;
                }
            }
            Console.WriteLine("A legkisebb szám a {0}, index helye {1}", min, hely);
        }

        private static void maximum()
        {
            int hely = 0;
            int max = 1;
            for (int i = 0; i < tomb.Length; i++)
            {
                if (max<tomb[i])
                {
                    max = tomb[i];
                    hely = i;
                }
            }

            Console.WriteLine("A legnagyobb szám a tömbben a {0}, index helye {1}", max, hely);
        }

        private static void kereses()
        {

            int i = 0;

            while (i < tomb.Length && tomb[i] != 50)
            {
                i++;
            }
            if (i < tomb.Length)
            {
                Console.WriteLine("Benne van az 50 a {0}. helyen /{1}. indexű helyen.", i, i+1);
            }
            else
            {
                Console.WriteLine("Nincs benne az 50.");
            }
        }

        private static void kivalasztas()
        {
            int i = 0;
            while (tomb[i] != 50)
            {
                i++;
            }
            
            Console.WriteLine("A tömb {0}. indexű eleme az 50", i);

        }

        private static void eldontes()
        {
            int i = 0;
            //bool r = false;
            while (i < tomb.Length && tomb[i]!=69)  //for ciklussal breaket is használhatunk
            {
                i++;
            }
            if (i < tomb.Length)
            {
                Console.WriteLine("Van 69 a tömbben!");
            }
            else
            {
                Console.WriteLine("Nincs 69 a tömbben!");
            }
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
