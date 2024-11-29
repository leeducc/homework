using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework22_11.entity
{
    public class Clothing : Product
    {
        public string Size { get; set; }

        public override string GetInfo()
        {
            return $"ID: {Id}, Name: {Name}, Price: {Price}, Category: {Category}, Size: {Size}";
        }
    }
}
