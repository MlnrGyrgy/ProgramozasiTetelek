﻿using System;
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
        static void Szamolas()
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("A tömb elemei közül hány darab osztható hárommal?");
            int harommal = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i]%3==0)
                {
                    harommal++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("A tömbben {0} szám osztható hárommal.",harommal);
        }
        static void Eldontes()
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Van-e 69 a tömbben?");
            int i = 0;
            while (i<tomb.Length && tomb[i] != 69)
            {
                i++;
            }
            Console.WriteLine();
            if (i<tomb.Length)
            {
                Console.WriteLine("Van 69 a tömbben.");
            }
            else Console.WriteLine("Nincs 69 a tömbben");
        }
        static void Kivalasztas()
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Kiválasztás tétele");
            int i = 0;
            while (i < tomb.Length && tomb[i] != 50)
            {
                i++;
            }
            Console.WriteLine("Az 50 {0}. helyen található.",i+1);
            
        }
        static void Kereses()
        {
            int i = 0;
            while (i < tomb.Length&&tomb[i] != 50)
            {
                i++;
            }
            if (i<tomb.Length)
            {
                Console.WriteLine("A tömb tartalmazza az 50-es számot. \nA(z) {0}. helyen található.",i+1);
            }
            else Console.WriteLine("Nem található a tömbben az 50-es elem.");
        }
        static void Maximum()
        {
            int max = 0;
            for (int i = 1; i < tomb.Length; i++)
            {
                if (tomb[i]>tomb[max])
                {
                    max = i;
                }
            }
            Console.WriteLine("{0} ", tomb[max]);

        }
        static void Main(string[] args)
        {
            //TombKiiras();
            //Osszegzes();
            //Szamolas();
            //Eldontes();
            //Kivalasztas();
            //Kereses();
            Maximum();
            Console.ReadKey();
        }
    }
}
