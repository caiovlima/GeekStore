using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeekStore.Application.Product.Commands.CreateProduct.Command;
using GeekStore.Application.Product.Interfaces;
using GeekStore.Application.ViewModels.Product;

namespace GeekStore.Infra.Repository
{
    public class ProductRepository : IProductRepository
    {
        public async Task<ProductViewModel> CreateProduct(CreateProductCommand productCommand)
        {
            throw new NotImplementedException();
        }
    }
}
