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
            int[] tab = new int[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
            for (int i = 0; i < tab.Length; i++)
            {
                Console.Write(tab[i] + " ");
            }

            foreach (int value in tab)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine("\n");
            
            int j = 0;
            int size = tab.Length;
            size--;
            foreach (int value in tab)
            {
                if (j == 0)
                {
                    Console.WriteLine("Pierwszy element: {0}", tab[0]);
                }
                else if (j == size)
                {
                    Console.WriteLine("Ostatni element: {0}", tab[size]);
                }
                else
                {
                    Console.WriteLine("Kolejny element: {0}", tab[j]);
                }
                j++;
            }
            Console.WriteLine();
            /*utwórz tablicę n elementową, której rozmiar podaje użytkownik z klawiatury użytkownik następnie podaje ulubione kolory z klawiatury
             * wyświetl kolory w formacie
             * Kolor1: ...
             * Kolor2: ...
             */
            string text;
            byte count;

            do
            {
                Console.Write("Ilość ulubionych kolorów:");
                text = Console.ReadLine();
            } while (byte.TryParse(text, out count) == false);

            string[] colors = new string[count];

            //Console.WriteLine("\nIlość ulubionych kolorów: {0}", colors.Length);

            //count || colors.Length
            string color;
            for (int i = 0; i < count; i++)
            {
                Console.Write("Podaj kolor: ");
                color = Console.ReadLine();
                colors[i] = color;
            }
            int h = 0, y;
            while (h < colors.Length)
            {
                y = h;
                y++;
                Console.WriteLine("Kolor{0}: {1}", y, colors[h]);
                h++;
            }





            Console.ReadKey();
        }
    }
}