using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion_slut
{
    public class ProductService
    {
        private IProductRepo _productRepository;

        public ProductService(IProductRepo productRepo)
        {
            _productRepository = productRepo;
        }

        public IEnumerable<Product> GetProducts(IProductDiscount productDiscount)
        {
            IEnumerable<Product> productsFromDataStore = _productRepository.FindAll();
            foreach (Product p in productsFromDataStore)
            {
                p.AdjustPrice(productDiscount);
            }
            return productsFromDataStore;
        }
    }
}
