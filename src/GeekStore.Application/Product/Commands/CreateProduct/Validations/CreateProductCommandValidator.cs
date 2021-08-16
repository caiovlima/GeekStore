using FluentValidation;
using GeekStore.Application.Product.Commands.CreateProduct.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekStore.Application.Product.Commands.CreateProduct.Validations
{
    public class CreateProductCommandValidator : AbstractValidator<CreateProductCommand>
    {
        public CreateProductCommandValidator()
        {
            RuleFor(p => p.Product.SupplierID).NotEmpty().NotNull();
            RuleFor(p => p.Product.Name).NotEmpty().NotNull()
                .MaximumLength(200)
                .MinimumLength(2)
                .WithMessage("The field Product Name is required");
            RuleFor(p => p.Product.Description).NotEmpty().NotNull()
                .MaximumLength(1000)
                .MinimumLength(2)
                .WithMessage("The field Product Description is required");
            RuleFor(p => p.Product.Value).NotEmpty().NotNull();
        }
    }
}
