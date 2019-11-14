using System;

namespace przestrzenie_nazw
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.Console.WriteLine("WSB");

            First_name.namespace_1 obj1 = new First_name.namespace_1();
            obj1.Show();

            Second_name.namespace_2 obj2 = new Second_name.namespace_2();
            obj2.Show();

            //Outer.Middle.Inner.Prog ob = new Outer.Middle.Inner.Prog();
            Program ob = new Program();
            Console.WriteLine("Rezultat dodawania: {0}", ob.Add(3, 5));

            Console.ReadKey();
        }
    }
}


namespace First_name
{
    class namespace_1
    {
        public void Show()
        {
            Console.WriteLine("Pierwsza przestrzeń nazw");
        }
    }
}



namespace Second_name
{
    class namespace_2
    {
        public void Show()
        {
            Console.WriteLine("Druga przestrzeń nazw");
        }
    }
}



namespace Outer
{
    namespace Middle
    {
        namespace Inner
        {
            class Prog
            {
                public int x, y;

                public int Add(int x, int y)
                {
                    return x + y;
                }
            }
        }
    }
}