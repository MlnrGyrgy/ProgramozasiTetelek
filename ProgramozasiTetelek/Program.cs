using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramozasiTetelek
{
    class Program
    {
        static int[] tomb = new int[10] { 12, 7, 2, 4, 45, 99, 1, 8, 95, 50 };
        static void TombKiiras()
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Tömb elemeinek kiíratása.");
            Console.WriteLine();

            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write(tomb[i] + ",");
            }
            Console.WriteLine();
        }
        static void Osszegzes()
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Tömb elemeinek összegzése.");
            int osszeg = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                osszeg = osszeg + tomb[i];
            }
            Console.WriteLine();
            Console.WriteLine(osszeg);
        }
        static void Main(string[] args)
        {
            TombKiiras();
            Osszegzes();
            Console.ReadKey();
        }
    }
}
