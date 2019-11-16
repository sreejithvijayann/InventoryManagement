using System;
using System.Collections.Generic;
using System.Text;

namespace Suguna.Application.Products.Queries.GetProducts
{
    public class ProductDTO
    {
        public short Id { get; set; }
        public Guid Guid { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public decimal Price { get; set; }
    }
}
