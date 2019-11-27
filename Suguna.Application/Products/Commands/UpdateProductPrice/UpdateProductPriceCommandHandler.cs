using MediatR;
using Suguna.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Suguna.Application.Products.Commands.UpdateProductPrice
{
    public class UpdateProductPriceCommandHandler : IRequestHandler<UpdateProductPriceCommand, ResponseDTO>
    {

        public Task<ResponseDTO> Handle(UpdateProductPriceCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
