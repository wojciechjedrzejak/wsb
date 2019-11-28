using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace struktura_1
{
    class Program
    {
        public struct Punkt
        {
            public int x;
            public int y;

        }

        static void Main(string[] args)
        {
            Punkt punkt1 = new Punkt();
            Punkt punkt2;

            punkt1.x = 100;
            punkt1.y = 50;

            punkt2.x = 200;



            Console.WriteLine("Punkt1.x wynosi {0}", punkt1.x);
            Console.WriteLine("Punkt1.x wynosi {0}", punkt1.y);
            Console.WriteLine("Punkt1.x wynosi {0}", punkt2.x);


            Console.ReadKey();
        }
    }
}
