using System;
using System.Collections.Generic;
using System.Text;
using U241017A.DATA;

namespace U241017A.DATA
{
    public class Repository
    { 
  
        private static Repository _repo = new Repository();
        public static Repository GetRepo { get { return _repo; } }


        private List<Product> prod = new List<Product>();

        public Repository()
        {
            prod.Add(new Product() { Name = "1", Event = "Hejdf", Date = "Igårs", Location = "Här8" });
            prod.Add(new Product() { Name = "2", Event = "Hej23", Date = "Igårg", Location = "Här7" });
            prod.Add(new Product() { Name = "3", Event = "Hej23", Date = "Igårg", Location = "Här6" });
            prod.Add(new Product() { Name = "5", Event = "Hejs", Date = "Igårv", Location = "Här5" });
            prod.Add(new Product() { Name = "4", Event = "Hej6", Date = "Igårv", Location = "Här1" });
        }

        public List<Product> Products
        {
            get
            {
                return prod;
            }
        }


        public void Add(Product p)
        {
            prod.Add(p);
        }


    }
}
