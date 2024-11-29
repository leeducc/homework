using Q2.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2.main
{
    class Program
    {
        static void Main()
        {
            
            Console.WriteLine("Enter details for Electronics Product:");
            Console.Write("Name: ");
            string eName = Console.ReadLine();
            Console.Write("Price: $");
            decimal ePrice = decimal.Parse(Console.ReadLine());
            Console.Write("Warranty Period (months): ");
            int eWarranty = int.Parse(Console.ReadLine());

            ElectronicsProduct eProduct = new ElectronicsProduct
            {
                Name = eName,
                Price = ePrice,
                WarrantyPeriod = eWarranty
            };

            decimal eDiscount = eProduct.CalculateDiscount();
            Console.WriteLine($"Discount for {eProduct.Name}: ${eDiscount:F2}");

            
            Console.WriteLine("\nEnter details for Clothing Product:");
            Console.Write("Name: ");
            string cName = Console.ReadLine();
            Console.Write("Price: $");
            decimal cPrice = decimal.Parse(Console.ReadLine());
            Console.Write("Size (S/M/L/XL/XXL): ");
            string cSize = Console.ReadLine();

            ClothingProduct cProduct = new ClothingProduct
            {
                Name = cName,
                Price = cPrice,
                Size = cSize
            };

            decimal cDiscount = cProduct.CalculateDiscount();
            Console.WriteLine($"Discount for {cProduct.Name}: ${cDiscount:F2}");
        }
    }

}
