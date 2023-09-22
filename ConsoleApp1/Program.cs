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
            int a = 7, b = 2;

            int x = --a + --b;

            a = 2 * x--;

            x += a += b;



            Console.WriteLine(x);
            Console.ReadKey();

        }
    }
}
