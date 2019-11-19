using System;

namespace Suguna.Common
{
    public class ResponseDTO
    {
        public object Data { get; set; }
        public string Message { get; set; }

        public void Initialize(object data, string message)
        {
            Data = data;
            Message = message;
        }
    }
}
