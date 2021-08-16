using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using GeekStore.Application.Product.Commands.CreateProduct.Command;
using GeekStore.Application.ViewModels.Product;
using Microsoft.Extensions.Logging;
using GeekStore.Application.Product.Interfaces;
using AutoMapper;
using GeekStore.Application.Product.Commands.CreateProduct.Validations;
using FluentValidation;

namespace GeekStore.Application.Product.Commands.CreateProduct.Handler
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, ProductViewModel>
    {
        private readonly ILogger<CreateProductCommandHandler> _logger;
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public CreateProductCommandHandler(ILogger<CreateProductCommandHandler> logger, IProductRepository productRepository, IMapper mapper)
        {
            _logger = logger;
            _productRepository = productRepository;
            _mapper = mapper;

        }
        public async Task<ProductViewModel> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var validator = new CreateProductCommandValidator();
                var validation = validator.Validate(request);

                if (!validation.IsValid) throw new ValidationException("Ops! Something wrong when try to create product! ", validation.Errors);

                var productViewModel = await _productRepository.CreateProduct(request);
                return productViewModel;
            }
            catch (ValidationException ex)
            {
                _logger.LogInformation("Ops! The request is invalid");
                throw ex;
            }
            catch (Exception ex)
            {
                _logger.LogInformation("Ops! Maybe the params is invalid");
                throw ex;
            }
        }
    }
}
