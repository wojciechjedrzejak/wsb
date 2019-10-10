using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Obliczanie pola trójkąta\n");
            Console.Write("Podaj długość podstawy:");
            string x1 = Console.ReadLine();
            Console.Write("Podaj wysokość:");
            string x2 = Console.ReadLine();
            int y1, y2;
            double pole;
            y1 = int.Parse(x1);
            if (int.TryParse(x1, out y1) && int.TryParse(x2, out y2))
            {
                //obliczenia pola 
                pole = 0.5 * y1 * y2;
                Console.WriteLine("Pole trójkąta wynosi: {0}", pole);
            } else {
                //error
                Console.WriteLine("Podałeś błędne dane!");
            }

            Console.ReadKey();
        } 
    }
}
