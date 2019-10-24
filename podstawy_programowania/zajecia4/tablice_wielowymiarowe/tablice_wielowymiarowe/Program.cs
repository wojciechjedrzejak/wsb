using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tablice_wielowymiarowe
{
    class Program
    {
        static void Main(string[] args)
        {
            //tablice prostokątne

            int[,] tab = new int[,]
            {
                {1, 2, 3, 4},
                {5, 6, 7, 8},
                {9, 10, 11, 12},
                {13, 14, 15, 16}
            };


            for (int i = 0; i < tab.GetLength(0); i++)
            {
                //wiersze
                for (int j= 0; j < tab.GetLength(1); j++)
                {
                    //kolumny
                    Console.Write("{0}\t", tab[i, j]);
                }
                Console.WriteLine();
            }

            //Utwórz tablicę dwuwymiarową i zainicjuj ją danymi i * 3 + j

            int[,] tab2 = new int[3, 3];

            for (int i = 0; i < tab2.GetLength(0); i++)
            {
                for (int j = 0; j < tab2.GetLength(1); j++)
                {
                    tab2[i, j] = i * 3 + j;
                    Console.Write("{0}\t", tab2[i, j]);
                }
                Console.WriteLine("\n");

            }

            string[][] country = new string[4][];

            Console.WriteLine("Rozmiar zewnętrznego wymiaru tablicy nieregularnej {0}", country.Length);

            int[][] numbers2 = new int[3][]
            {
                new int[] {1},
                new int[] {2, 3, 4, 5},
                new int[] {6, 7},
            };

            for (int i = 0; i < length; i++)
            {
                for (int i = 0; i < length; i++)
                {

                }
            }

            Console.ReadKey();
        }
    }
}
