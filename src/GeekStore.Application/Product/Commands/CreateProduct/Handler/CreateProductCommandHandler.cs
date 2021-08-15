using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using GeekStore.Application.Product.Commands.CreateProduct.Command;
using GeekStore.Application.ViewModels.Product;

namespace GeekStore.Application.Product.Commands.CreateProduct.Handler
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, ProductViewModel>
    {
        public async Task<ProductViewModel> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
