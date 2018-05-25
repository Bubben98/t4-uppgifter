using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace u13091702
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> Products = new List<Product>();

            Products.Add(new Product() { Name = "a", Price = 1 });
            Products.Add(new Product() { Name = "b", Price = 10 });

            Products.Add(new Product() { Name = "c", Price = 12 });
            Console.WriteLine("Dyraste produkten är: " + Products.Max(p => p.Price));

            int i = Products.Max(p => p.Price);
            Console.WriteLine("Dyraste produkten är: " + Products.Find(x => x.Price == 10).Name);

            //Lambda
            //x =>
            //(x,y) =>
            //(x, y, z) => 
            //() =>

        }
    }
    public class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
    }
}
