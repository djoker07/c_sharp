using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_IMS
{
    class Program
    {
        static void Main(string[] args)
        {
            bool quit = true;
            int selection = 0;
            Manager manager = new Manager();

            while (quit)
            {
                printMenu();
                try
                {
                    selection = int.Parse(Console.ReadLine());
                }catch(FormatException)
                {
                    Console.WriteLine("Invalid Option Retard");
                }

                switch(selection)
                {
                    case 1:
                        manager.addProduct();
                        break;
                    case 2:
                        manager.printSingleProduct();
                        break;
                    case 3:
                        manager.printInventory();
                        break;
                    case 4:
                        manager.updateProduct();
                        break;
                    case 5:
                        manager.removeProduct();
                        break;
                    case 6:
                        Console.WriteLine("Good Bye");
                        quit = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Option Retard");
                        break;


                }
            }
            //printMenu();
        }

        public static void printMenu()
        {
            Console.WriteLine();
            Console.WriteLine("=========================================");
            Console.WriteLine("Welcome to Major Mart IMS");
            Console.WriteLine("Select an option:");
            Console.WriteLine("=========================================");
            Console.WriteLine("1: Add new product to inventory");
            Console.WriteLine("2: Search a product in current inventory");
            Console.WriteLine("3: Display list of products");
            Console.WriteLine("4: Update the quantity of a product");
            Console.WriteLine("5: Remove a product from inventory");
            Console.WriteLine("6: Quit IMS");
        }
    }
}
