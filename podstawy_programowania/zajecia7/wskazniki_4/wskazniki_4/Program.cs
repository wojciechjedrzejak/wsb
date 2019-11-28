using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wskazniki_4
{
    class Program
    {
        struct Test
        {


            int n;

            unsafe static void Main(string[] args)
            {
                Test x = new Test();
                Test* p = &x;

                (*p).n = 20;

                Console.WriteLine(x.n);
                Console.ReadKey();
            }
        }
    }
}
