using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_IMS
{
    class Manager
    {
        List<Product> inventory = new List<Product>();

        public void addProduct()
        {
            Product p = new Product();

            Console.WriteLine("Enter product name: ");
            p.name = Console.ReadLine();

            Console.WriteLine("Enter product quantity: ");
            try
            {
                p.quantity = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Not a number idiot");
            }

            Console.WriteLine("Enter product price: ");
            p.price = Console.ReadLine();

            Console.WriteLine("Enter product category: ");
            p.category = Console.ReadLine();

            inventory.Add(p);
        }

        public void removeProduct()
        {
            Product p = searchForProduct(); 
            if(p != null)
            {
                inventory.Remove(p);
                Console.WriteLine("Product Removed");
            }  
            else
            {
                Console.WriteLine("Product doesn't exist");
            }
        }

        public void updateProduct()
        {
            Product p = searchForProduct();
            if(p != null)
            {
                Console.WriteLine("Enter new quantity for " + p.name);
                p.quantity = int.Parse(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("Product doesn't exist");
            }
        }

        public void printInventory()
        {
            foreach(Product p in inventory)
            {
                Console.WriteLine("Name: " + p.name + " === Quantity: " + p.quantity + " === Price: " + p.price + " === Category: " + p.category);
            }
        }

        public void printSingleProduct()
        {
            Product p = searchForProduct();
            Console.WriteLine("Name: " + p.name + " === Quantity: " + p.quantity + " === Price: " + p.price + " === Category: " + p.category);
        }

        public Product searchForProduct()
        {
            Product p = new Product();
            Console.WriteLine("Enter product name: ");
            p.name = Console.ReadLine();

            for (int i = 0; i < inventory.Count; i++)
            {
                if (string.Equals(p.name, inventory[i].name))
                {
                    return inventory[i];
                }

            }

            return null;
        }
    }
}
