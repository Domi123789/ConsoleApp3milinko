using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3milinko
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            Console.WriteLine($"prije izvrsavanja metode iznos {a}");
            Metoda(a);
            Console.WriteLine($"nakon izvrsavanja metode iznos {a}");
            Console.ReadKey();
        }

        static void Metoda (int a)
        {
            a = 5;
            Console.WriteLine($"tijekom izvrsavanja metode iznos {a}");
        }
    }
}
