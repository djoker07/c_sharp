using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rectArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter first int: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("enter second int: ");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine("the area of the rectangle is: " + rArea(x, y));
        }

        static public int rArea(int a, int b)
        {
            return a * b;
        }
    }
}
