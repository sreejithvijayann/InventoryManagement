using MediatR;
using Microsoft.AspNetCore.Mvc;
using Suguna.Application.Products.Commands.Create;
using Suguna.Application.Products.Queries.GetProducts;
using Suguna.Web.Controllers.BaseController;
using System.Collections.Generic;
using System.Threading.Tasks;
using HttpGetAttribute = Microsoft.AspNetCore.Mvc.HttpGetAttribute;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace Suguna.Web.Controllers.Product
{
    [Route("api")]
    [ApiController]
    public class ProductController : ApiBaseController
    {
        private readonly IMediator _mediator;
        public ProductController(IMediator mediator)
        {
            _mediator  = mediator;
        }

        [HttpGet]
        [Route("products")]
        public async Task<IActionResult> ReadAllProducts()
        {
            GetProductsQuery request = new GetProductsQuery();
            return Ok(await _mediator.Send(request));
        }

        [HttpPost]
        [Route("product")]
        public async Task<IActionResult> CreateProduct(CreateProductCommand request)
        {
            request.Initialize(ContextUserId);
            return Ok(await _mediator.Send(request));
        }
    }
}