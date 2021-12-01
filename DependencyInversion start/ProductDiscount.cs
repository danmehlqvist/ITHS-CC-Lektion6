using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion_start
{
    public class ProductDiscount
    {
        public int AdjustPrice(int price)
        {
            return (int)(0.9 * price);
        }
    }
}
