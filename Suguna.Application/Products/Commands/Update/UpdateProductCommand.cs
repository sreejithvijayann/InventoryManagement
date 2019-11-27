using Suguna.Abstraction.Interfaces.Command.Product;
using System;

namespace Suguna.Application.Products.Commands.Update
{
    public class UpdateProductCommand : BaseRequest, IUpdateProduct
    {
        public Guid Guid { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }

    }
}
