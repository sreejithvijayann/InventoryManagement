using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Suguna.Application.Products.Queries.Search
{
    public  class SearchProductsQuery : IRequest<IEnumerable<SearchProductsQueryResponse>>
    {
        public string Search { get; set; }
    }
}
