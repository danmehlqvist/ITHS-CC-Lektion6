using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion_slut
{
    public class PropertyInjection
    {
        private IProductDiscount _productDiscount;

        public IProductDiscount ProductDiscount
        {
            get
            {
                if (_productDiscount is null)
                {
                    _productDiscount = new ProductDiscount();
                }
                return _productDiscount;
            }
            set { _productDiscount = value; }
        }

        public void DoSomething()
        {
            // Här använder vi ProductDiscount till något
        }


    }
}
