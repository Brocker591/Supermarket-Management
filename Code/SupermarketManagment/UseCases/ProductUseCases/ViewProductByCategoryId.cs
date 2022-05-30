using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;
using UseCases.UseCaseInterfaces;

namespace UseCases.ProductUseCases
{
    public class ViewProductByCategoryId : IViewProductByCategoryId
    {
        private readonly IProductRepository productRepository;

        public ViewProductByCategoryId(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public IEnumerable<Product> Execute(int categoryId)
        {
            return productRepository.GetProductByCategoryId(categoryId);
        }
    }
}
