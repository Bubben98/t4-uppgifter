using domain.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using domain.Entites;

namespace domain.Concrete
{
    public class EFProductRepository : IProductRepository
    {
        private List<product> _products;
            public EFProductRepository()
        {
            _products = new List<product>();
            _products.Add(new product() { Name = "DDD", Price = 200 });
            _products.Add(new product() { Name = "EEE", Price = 220 });
        }

        public IEnumerable<product> Products =>_products;
    }
}
