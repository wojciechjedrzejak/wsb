using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 - pole kwadratu\n2 - pole koła");
            Console.WriteLine("Wybierz wartość:");
            string x;
            x = Console.ReadLine();

            switch(x)
            {
                case "1":

                    Console.Clear();
                    Console.WriteLine("Podaj długość boku kwadratu:");
                    string a = Console.ReadLine();
                    int b;
                    b = int.Parse(a);
                    double pole1;
                    pole1 = b * b;
                    Console.WriteLine("\nPole kwadratu:{0:##.##}", pole1);
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine("Podaj długość promienia koła:");
                    string c = Console.ReadLine();
                    int d;
                    d = int.Parse(c);
                    double pole2;
                    pole2 = d * d * 3.14 / 2;
                    Console.WriteLine("Pole koła:{0:##.##}", pole2);
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Podałeś błędne dane");
                    break;
            }
            Console.ReadKey();
        }
    }
}
