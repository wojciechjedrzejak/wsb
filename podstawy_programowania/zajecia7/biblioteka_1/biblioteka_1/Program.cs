using System;
using biblioteka_1_dll;

namespace biblioteka_1
{
    class Program
    {
        static void Main(string[] args)
        {
            MathClass x = new MathClass();
            Console.WriteLine(x.Add(3, 5));

            Console.ReadKey();
        }
    }
}
