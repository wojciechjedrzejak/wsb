using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Text;

namespace pliki_1
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo wsbDir = new DirectoryInfo(".");

            DirectoryInfo studentDir = new DirectoryInfo(@"C:\Users\Student");

            Console.WriteLine(studentDir.FullName);
            Console.WriteLine(studentDir.Name);
            Console.WriteLine(studentDir.Parent);
            Console.WriteLine(studentDir.Attributes);
            Console.WriteLine(studentDir.CreationTime);


            string[] customers =
            {
                "Anna Nowak",
                "Janusz Kowalski",
                "Tomasz Nowak",
            };


            string path = @"C:\Users\Student";
            try
            {
                if (Directory.Exists(path))
                {
                    Console.WriteLine("\nKatalog istnieje");
                }
                else
                {
                    Directory.CreateDirectory("\\Users\\student\\C#Files");

                    string textFilePath = @"C:\Users\Student\C#Files\testFile.txt";
                    File.WriteAllLines(textFilePath, customers);

                    Console.WriteLine("\nKatalog został utworzony: {0}", Directory.GetCreationTime(path));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: {0}", e.ToString());
            }

            if (Directory.Exists(path))
            {
                Console.WriteLine("\nCzy chcesz usunąć katalog z plikami? 1-true, 0-false");
                string delete = Console.ReadLine();

                if (delete == "1")
                {
                    Directory.Delete(path, true);
                }

                if (!Directory.Exists(path))
                {
                    Console.WriteLine("Katalog został usunięty!");
                }
                else
                {
                    Console.WriteLine("Nie usunąłeś katalogu");
                }

            }


            Console.ReadKey();
        }
    }
}