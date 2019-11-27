using MediatR;
using Suguna.Persistence.Models;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Suguna.Application.Products.Queries.Search
{
    public class SearchProductsQueryHandler : IRequestHandler<SearchProductsQuery, IEnumerable<SearchProductsQueryResponse>>
    {
        private readonly SugunaContext _context;
        public SearchProductsQueryHandler(SugunaContext context)
        {
            _context = context;
        }

        public Task<IEnumerable<SearchProductsQueryResponse>> Handle(SearchProductsQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
