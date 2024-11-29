using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.entity
{
    public class Product
    {
       
        public string Name;
        public decimal Price;
        public int Quantity;

        public Product(string name, decimal price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public override string ToString()
        {
            return $"Tên: {Name}, Giá: {Price:F2}, Số lượng: {Quantity}";
        }
    }
}
