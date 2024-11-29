using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2.entity
{
    class ClothingProduct : Product
    {
        public override string Name { get; set; }
        public override decimal Price { get; set; }
        public string Size { get; set; }

        public override decimal CalculateDiscount()
        {
            return (Size == "S" || Size == "M" || Size == "L") ? Price * 0.15m : Price * 0.1m;
        }
    }
}
