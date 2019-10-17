using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * napisz program, ktory za pomocą instrukcji do while dla danych wartości zmieniających się w przedziale od 0 do 15 oblicza wartość funkcji y = 4x
             */
            int y = 0, x = 0;
            do
            {
                y = 4 * x;
                Console.WriteLine("x = {0}\ty = {1}", x, y);
                x++;
            } while (x <= 15);

            //napisz program znajduący się powyżej za pomocą pętli while

            x = 0;
            y = 0;

            while(x <= 15)
            {
                y = 4 * x;
                Console.WriteLine("x = {0}\ty = {1}", x, y);
                x++;
            }

            //napisz program, który za pomocą instrukcji while dla danych wartości x zmieniających się w przedziale od 1 do 50 obliczy ich sumę
            Console.WriteLine();
            x = 1; 
            int suma = 0;

            while(x <= 50)
            {
                suma = suma + x;
                x++;
            }
            Console.WriteLine("suma = {0}", suma);

            //wypisz tabliczkę mnożenia
            int iloczyn;
            for(int i=1; i<=10; i++)
            {
                for(int j=1; j<=10; j++)
                {
                    iloczyn = i * j;
                    Console.Write("{0}\t", iloczyn);
                }
                Console.WriteLine();
            }

            //napisz program, który za pomocą pentli for zsumuje liczby nieparzyste z przedziału od 1 do 10
            int c = 0;
            for(int i=1; i<=10; i++)
            {
                if (i % 2 != 0)
                {
                    c += i;
                }
            }
            Console.WriteLine("suma = {0}", c);

            int n = 1, m = 1;
            int iloczyn2 = 0;
            do
            {
                do
                {
                    iloczyn2 = n * m;
                    Console.Write("{0}\t", iloczyn2);
                    m++;
                } while (m <= 10);
                n++;
                m = 1;
                Console.WriteLine();
            } while (n <= 10);

            //Napisz program, który wyświetli duże litery alfabetu od A do Z i od Z do A z wykorzystaniem pętli for

            char znak = 'A';
            for(znak='A'; znak<'Z'; znak++)
            {
                Console.Write("{0}, ", znak);
            }
            Console.Write("Z.");
            Console.WriteLine();
            for(znak='Z'; znak>'A'; znak--)
            {
                Console.Write("{0}, ", znak);
            }
            Console.Write("A. ");

            int j = 1;
            for (; j <= 10; j++)
            {
                if (j == 3 || j == 6 || j == 7)
                    continue;
                Console.Write(j + ' ');
            }







            Console.ReadKey();
        }
    }
}
