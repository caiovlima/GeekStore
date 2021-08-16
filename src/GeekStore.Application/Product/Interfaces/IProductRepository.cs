using GeekStore.Application.Product.Commands.CreateProduct.Command;
using GeekStore.Application.ViewModels.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekStore.Application.Product.Interfaces
{
    public interface IProductRepository
    {
        Task<ProductViewModel> CreateProduct(CreateProductCommand productCommand);
    }
}
