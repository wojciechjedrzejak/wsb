using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wyjatki2
{
    class Program
    {
        static void Main(string[] args)
        {
            uint number;
            string x;
            while (true)
            {
                Console.WriteLine("Wprowadź liczbę całkowitą: ");
                try
                {
                    x = Console.ReadLine();
                }
                catch (OutOfMemoryException)
                {
                    Console.WriteLine("Pamięć");
                }
                
                try
                {
                    number = uint.Parse(x);
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Wprowadź liczbę w poprawnym formacie np. 4");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Wprowadzona liczba jest poza dopuszczalnym zakresem");
                    Console.WriteLine("Zakres liczb: <0;4 294 967 295>");
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("Pusta wartość\n");
                }
                Console.WriteLine("Wprowadź poprawnie wartość\n");
            }
            Console.WriteLine("Liczba całkowita: {0}", number);
        }
    }
}
