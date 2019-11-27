using MediatR;
using Suguna.Abstraction;
using Suguna.Common;
using Suguna.Persistence.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Suguna.Application.Products.Commands.Update
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand, ResponseDTO>
    {
        private readonly SugunaContext _context;
        private ResponseDTO _response;
        public UpdateProductCommandHandler(SugunaContext context, ResponseDTO response)
        {
            _context = context;
            _response = response;
        }

        public async Task<ResponseDTO> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            var product = _context.Product.Where(x => x.Guid.Equals(request.Guid)).FirstOrDefault();
            if (product == null)
            {
                _response.Initialize(MessageConstants.PRODUCTNOTFOUND, ApiStatusCode.ItemNotFound);
                _response.Message = MessageConstants.PRODUCTNOTFOUND;
                return _response;
            }

            product.ModifiedBy = request.UserId;
            product.ModifiedOn = DateTime.UtcNow;
            product.Name = request.Name;
            product.ShortName = request.ShortName;

            var result = await _context.SaveChangesAsync();
            if(result <= 0)
            {
                _response.Initialize(MessageConstants.PRODUCTNOTUPDATED, ApiStatusCode.UpdateFailed);
                return _response;
            }

            _response.Initialize(MessageConstants.PRODUCTUPDATED, ApiStatusCode.Success, request.Guid);
            return _response;
        }
    }
}
