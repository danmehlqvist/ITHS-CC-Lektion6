using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion_slut
{
    public interface IProductDiscount
    {
        int AdjustPrice(int price);
    }
}
