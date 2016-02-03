using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_P1._1
{
    class Program
    {
        //this program uses the enviroment class to print out the system specs to the console
        static void Main(string[] args)
        {
            Console.WriteLine("machine name: " + Environment.MachineName);
            Console.WriteLine("OS version: " + Environment.OSVersion);
            Console.WriteLine("processor count: " + Environment.ProcessorCount);
            Console.WriteLine("user name: " + Environment.UserName);
            Console.WriteLine("physical memory: " + Environment.WorkingSet);
            Console.WriteLine("network name: " + Environment.UserDomainName);

        }
    }
}
