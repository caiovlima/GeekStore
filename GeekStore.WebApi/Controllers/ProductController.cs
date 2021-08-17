using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using GeekStore.Application.Product.Commands.CreateProduct.Command;
using GeekStore.Application.ViewModels.Product;

namespace GeekStore.WebApi.Controllers
{
    [Route("product")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }
        
        [HttpPost]
        public async Task<IActionResult> CreteProduct(ProductViewModel product)
        {
            var result = await _mediator.Send(new CreateProductCommand(product));
            return Ok(result);
        }
    }
}
