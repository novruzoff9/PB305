using SoftDelete.Extensions;
using SoftDelete.Models;

namespace SoftDelete
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            Product product1 = new Product()
            {
                Id = 1,
                Name = "Laptop",
                Price = 1200.00m
            };
            Product product2 = new Product()
            {
                Id = 2,
                Name = "Smartphone",
                Price = 800.00m
            };
            Product product3 = new Product()
            {
                Id = 3,
                Name = "Tablet",
                Price = 500.00m
            };
            Product product4 = new Product()
            {
                Id = 4,
                Name = "Smartwatch",
                Price = 200.00m
            };
            products.Add(product1);
            products.Add(product2);
            products.Add(product3);
            products.Add(product4);

            products.SoftDeleteMany(x=>x.Id > 2);

            foreach (var item in products)
            {
                Console.WriteLine(item);
            }

            var activeProducts = products.GetActiveItems();
            activeProducts.ForEach(Console.WriteLine);
        }
    }
}
