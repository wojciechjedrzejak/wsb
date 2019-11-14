using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funkcje2
{
    class Program
    {
        static void Main(string[] args)
        {
            //napisz funkcję wyświetlającą, czy liczba jest parzysta czy nieparzysta, ma zwrócić stringa
            Console.Write(parzysta(2));
            Console.ReadKey();
            //napisz funkcję wyświętlającą sumę cyfr liczby całkowitej
            int x = 20;
            Console.WriteLine("Suma cyfr {0} wynosi: {1}", sum(x), x);
        }


        static string parzysta(int x)
        {
            if (x%2 == 0)
            {
                return "Parzysta";
            }
            else
            {
                return "Nieparzysta";
            }
        }


        static int sum(int x)
        {
            int sum = 0;

            do
            {
                sum = sum + x % 10;
                x = x / 10;
            } while (x != 0);

            return sum;
        }
    }
}
