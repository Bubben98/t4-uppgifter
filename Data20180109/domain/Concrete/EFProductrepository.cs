using System;
using System.Collections.Generic;
using System.Text;
using domain.Entites;
using domain.Abstract;

namespace domain.Concrete
{
    class EFProductrepository : IProductRepository
    {
        private readonly EFDBC _data = new EFDBC();
        public IEnumerable<product> Products => _data.products;
    }
}
