﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wyjatki
{
    class Program
    {
        static void Main(string[] args)
        {
            //typ wartosciowy
            int a = 10;
            int b = a;

            a--;
            b++;

            Console.WriteLine("Zmienna a: {0}", a);
            Console.WriteLine("Zmienna b: {0}", b);

            //typ referencyjny
            int[] tabA = { 1, 1, 1 };
            int[] tabB = tabA;

            tabA[2] = 50;
            tabB[1] = 25;

            Console.WriteLine("\nTablica A:");
            foreach (int item in tabA)
            {
                Console.Write("{0} ", item);
            }

            Console.WriteLine("\nTablica B:");
            foreach (int item in tabB)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();

            //uproszczone wyrazenie inicjalizacji tablic

            char[] vowels = {'a', 'e', 'i'};
            Console.WriteLine(vowels[0]);

            int[,] age =
            {
                {20, 30 },
                {20, 30 },
                {20, 30 },
            };
            Console.WriteLine("{0}", age[1, 1]);

            string[][] name =
            {
                new string[] {"Anna"},
                new string[] {"Anna", "Janusz"},
                new string[] {"Anna"}
            };

            Console.WriteLine(name[1][0]);
            Console.WriteLine("Ilość wymiarów: {0}", vowels.Rank);
            Console.WriteLine("Ilość wymiarów: {0}", age.Rank);
            Console.WriteLine("Ilość wymiarów: {0}", name.Rank);

            //kopiowanie tablic
            int[] tablica = { 1, 2, 3, 4, 5 };
            int[] kopiaTablica = new int[5];

            tablica.CopyTo(kopiaTablica, 0);
            foreach (int item in kopiaTablica)
            {
                Console.Write("{0} ", item);
            }

            int[] kopiaTablica2 = new int[5];

            Array.Copy(tablica, kopiaTablica2, tablica.Length);

            foreach (int item in kopiaTablica)
            {
                Console.Write("{0} ", item);
            }

            int[] kopiaTablica2 = new int[5];

            //Array.Copy(tablica, kopiaTablica2, 3);
            Array.Copy(tablica, kopiaTablica2, tablica.Length);

            foreach (int item in kopiaTablica)
            {

            }

            Console.ReadKey();
        }
    }
}
