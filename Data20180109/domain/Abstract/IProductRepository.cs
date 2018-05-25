using domain.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace domain.Abstract
{
    public interface IProductRepository
    {
        IEnumerable<product> Products {get; }


    }
}
