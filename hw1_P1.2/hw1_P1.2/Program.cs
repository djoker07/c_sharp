using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw1_P1._2
{
    class Program
    {
        //this program simulates an answering machine system
        static void Main(string[] args)
        {
            Console.WriteLine("available options are: \n0 - prnt\n1 - sales offices\n3 - record a message\n5 - exit:");
            Console.Write("please enter your optio: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            bool b = false;

            while(b != true)
            {
                switch (choice)
                {
                    case 0:
                        Console.WriteLine("we are transfering you to an operator");
                        b = true;
                        break;

                    case 1:
                        Console.WriteLine("our sales offices are closed right now");
                        b = true;
                        break;

                    case 3:
                        Console.WriteLine("record your message now");
                        b = true;
                        break;

                    case 5:
                        Console.WriteLine("good bye");
                        b = true;
                        break;

                    default:
                        Console.WriteLine("invalid option");
                        b = true;
                        break;
                }

            }
        }
    }
}
