﻿using System;
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
        public SellProductUseCase(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
        public void Execute(int productId, int quantityToSell)
        {
            var product = productRepository.GetProductById(productId);
            if (product == null) return;

            product.Quantity -= quantityToSell;
            productRepository.UpdateProduct(product);
        }
    }
}
