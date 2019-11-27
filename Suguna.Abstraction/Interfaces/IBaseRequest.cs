using MediatR;
using Suguna.Common;
using System;

namespace Suguna.Abstraction.Interfaces
{
    public interface IBaseRequest : IRequest<ResponseDTO>
    {
        void Initialize(Guid userId);
    }
}
