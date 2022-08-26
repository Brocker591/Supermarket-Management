using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;
using UseCases.UseCaseInterfaces;

namespace UseCases.ProductUseCases
{
    public class SellProductUseCase : ISellProductUseCase
    {
        public readonly IProductRepository productRepository;
        private readonly IRecordTransactionUseCase recordTransactionUseCase;

        public SellProductUseCase(IProductRepository productRepository, IRecordTransactionUseCase recordTransactionUseCase)
        {
            this.productRepository = productRepository;
            this.recordTransactionUseCase = recordTransactionUseCase;
        }
        public void Execute(string cashierName, int productId, int quantityToSell)
        {
            var product = productRepository.GetProductById(productId);
            if (product == null) return;

            recordTransactionUseCase.Execute(cashierName, productId, quantityToSell);

            product.Quantity -= quantityToSell;
            productRepository.UpdateProduct(product);
            
        }
    }
}
