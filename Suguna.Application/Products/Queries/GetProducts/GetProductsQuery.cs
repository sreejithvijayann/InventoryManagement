using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Suguna.Application.Products.Queries.GetProducts
{
    public class GetProductsQuery : IRequest<IEnumerable<ProductDTO>>
    {
    }
}
