using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion_slut
{
    public class ProductRepo: IProductRepo
    {
        public IEnumerable<Product> FindAll()
        {
            return new List<Product>()
            {
                new Product()
                {
                    Name ="Ett",
                    Price=100,
                },
                new Product()
                {
                    Name ="Två",
                    Price=200,
                },
                new Product()
                {
                    Name ="Tre",
                    Price=300,
                },

            };
        }
    }
}
