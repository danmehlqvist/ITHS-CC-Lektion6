using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion_start
{
    public class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public void AdjustPrice(ProductDiscount productDiscount)
        {
            Price = productDiscount.AdjustPrice(Price);
        }

        public override string ToString()
        {
            return $"{Name}, {Price}";
        }
    }
}
