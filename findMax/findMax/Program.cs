using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace findMax
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("the max between 1, 20, 17, 8, 10, 15, 12 is: " + max(1, 20, 17, 8, 10, 15, 12) );
            

            Console.WriteLine();
        }

        static int max(params int[] x)
        {
            int max = 0;
            for (int i = 0; i < x.Length; i++)
            {
                if(max < x[i])
                {
                    max = x[i];
                }
            }

            return max;
        }
    }
}
