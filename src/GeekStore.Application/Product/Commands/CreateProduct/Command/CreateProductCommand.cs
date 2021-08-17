﻿using MediatR;
using GeekStore.Application.ViewModels.Product;

namespace GeekStore.Application.Product.Commands.CreateProduct.Command
{
    public class CreateProductCommand : IRequest<ProductViewModel>
    {
        public CreateProductCommand(ProductViewModel product)
        {
            Product = product;
        }
        public ProductViewModel Product { get; set; }
    }
}
