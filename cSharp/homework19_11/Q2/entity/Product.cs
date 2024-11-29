using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2.entity
{
    abstract class Product
    {
        public abstract string Name { get; set; }
        public abstract decimal Price { get; set; }
        public abstract decimal CalculateDiscount();
    }

}
