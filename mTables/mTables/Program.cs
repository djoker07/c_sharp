using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mTables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter table parameter: ");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine();
            printTables(x);

            Console.WriteLine();
            pTables(x);

        }

        static void pTables(int x)
        {
            for (int i = 1; i <= x; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write( (i * j) + " ");
                }
                Console.WriteLine("\n");
                //Console.WriteLine();
            }
        }

        static void printTables(int a)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i + " * " + a + " = " + (i * a));
            }
        }
    }
}
