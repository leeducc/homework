using ConsoleApp2.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.main
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Product product = new Product("Laptop", 1500.00m, 10);

       
            Console.WriteLine(product.ToString());
        }
    }
}
