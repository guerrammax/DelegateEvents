using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Product
    {
        List<Entities.Product> Products = new List<Entities.Product>
        {
            new Entities.Product
            {
                ProductID=1,
                ProductName="Azuvar",
                UnitPrice=12,
                UnitsInStck=100,
                CategoryID=1
            },
             new Entities.Product
            {
                ProductID=2,
                ProductName="Coca",
                UnitPrice=13,
                UnitsInStck=50,
                CategoryID=1
             },
              new Entities.Product
            {
                ProductID=3,
                ProductName="agua",
                UnitPrice=15,
                UnitsInStck=40,
                CategoryID=2
             },

        };
       public Entities.Product GetProductBYID(int ID)
        {
            var Item = Products.Where(x=>x.ProductID==ID).FirstOrDefault();
            return Item;
        }
    }
}
