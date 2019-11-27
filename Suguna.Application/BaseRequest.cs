using Suguna.Abstraction.Interfaces;
using System;

namespace Suguna.Application
{
    public class BaseRequest : IBaseRequest
    {
        public Guid UserId { get; set; }
        public void Initialize(Guid userId)
        {
            UserId = userId;
        }
    }
}
