using MediatR;
using Microsoft.EntityFrameworkCore;
using Suguna.Persistence.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Suguna.Application.Products.Queries.GetProducts
{
    public class GetProductsQueryHandler : IRequestHandler<GetProductsQuery, IEnumerable<ProductDTO>>
    {
        private readonly SugunaContext _context;
        public GetProductsQueryHandler(SugunaContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<ProductDTO>> Handle(GetProductsQuery request, CancellationToken cancellationToken)
        {
            return await _context.Product.Select(x => new ProductDTO()
            {
                Guid = x.Guid,
                Id = x.Id,
                Name = x.Name,
                ShortName = x.ShortName,
                Price = x.Price.Where(y=>y.CurrentPrice == true).FirstOrDefault().Price1
            }).ToListAsync();
        }
    }
}
