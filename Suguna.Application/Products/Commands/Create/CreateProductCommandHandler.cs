using MediatR;
using Suguna.Common;
using Suguna.Persistence.Models;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Suguna.Application.Products.Commands.Create
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, ResponseDTO>
    {
        private readonly SugunaContext _context;
        public CreateProductCommandHandler(SugunaContext context)
        {
            _context = context;
        }

        public async Task<ResponseDTO> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            Product product = new Product()
            {
                CreatedBy = request.UserId,
                ModifiedBy = request.UserId,
                ModifiedOn = DateTime.UtcNow,
                Name = request.Name,
                ShortName=request.ShortName
            };

            var entry = await _context.AddAsync(product);
            await _context.SaveChangesAsync();
            return new ResponseDTO()
            {
                Data = entry.Entity.Guid,
                Message = "Product added successfully."
            };
        }
    }
}
