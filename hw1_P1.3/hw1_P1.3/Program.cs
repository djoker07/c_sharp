using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw1_P1._3
{
    class Program
    {
        //function to find the max number divisible by 5
        static void findMax(int[] numbers)
        {
            int max = 0;
            foreach(int n in numbers)
            {
                if(n % 5 == 0 && n > max)
                {
                    max = n;
                }
            }

            Console.WriteLine("the maximun number divided by 5 in this list is: " + max);
        }
        //this program uses a function that takes in several integers to find the
        //maximun number divisible by 5
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 10, 8, 15, 17, 12 };

            Console.WriteLine("the list of integers is: ");
            foreach(int n in numbers)
            {
                Console.Write(n + " ");
            }
            Console.WriteLine();
            

            findMax(numbers);
        }
    }
}
