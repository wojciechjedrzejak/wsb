using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tablice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisz program, który w 10-elementowej tablicy jednowymiarowej o nazwie tab umieszcza liczby całkowite z przedziału od 1 do 10

            int n = 10, i;
            //deklaracja tablicy o nazwie tab typu całkowitego o rozmiarze n = 10
            int[] tab = new int[n];

            for (i = 0; i < tab.Length; i++)
            {
                tab[i] = i;
            }

            //wyświetlenie zawartości tablicy

            for (i = 0; i < tab.Length; i++)
            {
                Console.WriteLine(tab[i]);
            }

            /*napisz program, który w 5-elementowej tablicy jednowymiarowej o nazwie colors umieszcza nazwy kolorów podane z klawiatury przez użytkownika. Wyświetl kolory w formacie
             * kolor1: red
             * kolor2: blue
             * ...
             * kolor5: yellow
             */
            string[] colors = new string[5];
            string color;
            for (i = 0; i < colors.Length; i++)
            {
                Console.Write("Podaj ulubiony kolor:");
                color = Console.ReadLine();
                colors[i] = color;
            }

            Console.Clear();

            Console.WriteLine("Ulubione kolory: ");
            int x = 0, count;
            while (x < colors.Length)
            {
                count = x + 1;
                Console.WriteLine("Kolor{0}:{1}", count, colors[x]);
                x++;
            }

            Console.ReadKey();
        }
    }
}
