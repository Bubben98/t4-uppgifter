using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console.GUI
{
    class Program

    {
        private static domain.Abstract.IProductRepository _repo = new domain.Concrete.EFProductRepository();
        static void Main(string[] args)
        {
            

            foreach (var item in _repo.Products)
            {
                System.Console.WriteLine(item.Name);
            }
        }
    }
}
