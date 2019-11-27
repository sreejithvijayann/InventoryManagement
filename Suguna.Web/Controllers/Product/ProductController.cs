using MediatR;
using Microsoft.AspNetCore.Mvc;
using Suguna.Application.Products.Commands.Create;
using Suguna.Application.Products.Commands.Update;
using Suguna.Application.Products.Commands.UpdateProductPrice;
using Suguna.Application.Products.Queries.GetProducts;
using Suguna.Application.Products.Queries.Search;
using Suguna.Common;
using Suguna.Web.Controllers.BaseController;
using System;
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

        [HttpPost]
        [Route("product")]
        public async Task<IActionResult> CreateProduct(CreateProductCommand request)
        {
            request.Initialize(ContextUserId);
            return Ok(await _mediator.Send(request));
        }

        [HttpGet]
        [Route("products")]
        public async Task<IActionResult> ReadAllProducts()
        {
            GetProductsQuery request = new GetProductsQuery();
            return Ok(await _mediator.Send(request));
        }

        [HttpGet]
        [Route("product")]
        public async Task<IActionResult> SearchProducts(string search)
        {
            SearchProductsQuery request = new SearchProductsQuery()
            {
                Search = search
            };
            return Ok(await _mediator.Send(request));
        }

        [HttpPatch]
        [Route("product")]
        public async Task<IActionResult> UpdateProduct(UpdateProductCommand request)
        {
            try
            {
                request.Initialize(ContextUserId);
                var response = await _mediator.Send(request);
                return await GetResponseAsync(response);
            }
            catch(Exception exp)
            {
                throw exp;
            }
        }


        [HttpPut]
        [Route("product/price")]
        public async Task<IActionResult> UpdateProductPrice(UpdateProductPriceCommand request)
        {
            try
            {
                request.Initialize(ContextUserId);
                var response = await _mediator.Send(request);
                return await GetResponseAsync(response);
            }
            catch (Exception exp)
            {
                throw exp;
            }
        }
    }
}