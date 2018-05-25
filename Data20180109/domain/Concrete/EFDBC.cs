using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity;
using domain.Entites;

namespace domain.Concrete
{
    public class EFDBC : DbContext
    {
        public DbSet<product> products { get; set; }
    }
}
