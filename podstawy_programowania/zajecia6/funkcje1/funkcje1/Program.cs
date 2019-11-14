using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funkcje1
{
    class Program
    {
        static void Main(string[] args)
        {
            Show();
            Add(3, 5);
            Add(2, 3, 4);
            Add(1, 2)
            Console.WriteLine("Wynik dodawania w funkcji z 4 arg = {0}", Add(2, d: 4));
            Console.ReadKey();
        }

        static void Show()
        {
            Console.WriteLine("WSB");
        }

        static void Add(int a, int b)
        {
            int result = a + b;
            Console.WriteLine("Wynik dodawania {1} i {2}: {0}", result, a, b);
        }

        static void Add(int a, int b, int c)
        {
            Console.WriteLine("Wynik = {0}", a + b + c);
        }

        static int Add(int a, int d, int b = 10, int c = 5)
        {
            return a + b + c + d;
        }

        static void data(string name, string surname="Nowak", int age = 30)
        {
            Console.WriteLine("Imię: {0} \nnazwisko")
        }

    }
}
