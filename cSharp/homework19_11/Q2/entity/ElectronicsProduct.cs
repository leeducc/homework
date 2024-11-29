using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2.entity
{
    class ElectronicsProduct : Product
    {
        public override string Name { get; set; }
        public override decimal Price { get; set; }
        public int WarrantyPeriod { get; set; }

        public override decimal CalculateDiscount()
        {
            return WarrantyPeriod > 12 ? Price * 0.2m : Price * 0.1m;
        }
    }
}
