using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using homework22_11.entity;

namespace homework22_11.main
{
    public class ProductManager
    {
        private List<Product> products = new List<Product>();

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public void DisplayProducts()
        {
            foreach (var product in products)
            {
                Console.WriteLine(product.GetInfo());
            }
        }

        public void RemoveProducts(Predicate<Product> predicate)
        {
            products.RemoveAll(predicate);
        }

        public void UpdatePrices(Action<Product> updateAction)
        {
            products.ForEach(updateAction);
        }

        public IEnumerable<Product> FilterProducts(Func<Product, bool> predicate)
        {
            return products.Where(predicate);
        }
    }
}
