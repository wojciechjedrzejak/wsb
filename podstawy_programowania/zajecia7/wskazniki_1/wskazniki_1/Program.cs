using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wskazniki_1
{
    class Program
    {
        unsafe static void Main(string[] args)
        {
            char* x;
            char letter = 'a';
            x = &letter;

            Console.WriteLine("Znak: {0}", letter);
            //Console.WriteLine("Adres w pamięci: {0}", *x); //wartość zmiennej
            Console.WriteLine("Adres w pamięci: {0}", (int)x);

            double number = 69;
            double* numberAddress;
            numberAddress = &number;

            Console.WriteLine("Numer: {0}", *numberAddress);
            Console.WriteLine("Adres w pamięci: {0}", (int)numberAddress);
            Console.WriteLine("Liczba wynosi {0}", numberAddress->ToString());


            Console.ReadKey();
        }
    }
}
