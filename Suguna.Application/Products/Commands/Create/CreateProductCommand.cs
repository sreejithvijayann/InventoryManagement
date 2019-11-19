using MediatR;
using Suguna.Common;
using System;

namespace Suguna.Application.Products.Commands.Create
{
    public class CreateProductCommand : IRequest<ResponseDTO>
    {
        public Guid UserId { get; internal set; }
        public string Name { get; set; }
        public string ShortName { get; set; }

        public void Initialize(Guid userId)
        {
            UserId = userId;
        }
    }
}
