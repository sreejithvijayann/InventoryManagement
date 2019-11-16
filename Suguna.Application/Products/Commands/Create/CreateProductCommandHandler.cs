using MediatR;
using Suguna.Persistence.Models;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Suguna.Application.Products.Commands.Create
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, long>
    {
        private readonly SugunaContext _context;
        public CreateProductCommandHandler(SugunaContext context)
        {
            _context = context;
        }
        public Task<long> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
