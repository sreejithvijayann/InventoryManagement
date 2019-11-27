using Suguna.Abstraction.Interfaces.Command.Product;

namespace Suguna.Application.Products.Commands.UpdateProductPrice
{
    public class UpdateProductPriceCommand : BaseRequest, IUpdateProductPrice
    {
        public short ProductId { get; set; }
        public decimal Amount { get; set; }
        public bool CurrentPrice { get; set; }
    }
}
