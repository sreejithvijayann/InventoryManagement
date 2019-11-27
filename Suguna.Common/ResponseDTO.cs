using System;
using System.Net;

namespace Suguna.Common
{
    public class ResponseDTO
    {
        public object Data { get; set; }
        public string Message { get; set; }
        public ApiStatusCode StatusCode { get; set; }

        public void Initialize(string message, ApiStatusCode statusCode, object data = null)
        {
            Data = data;
            Message = message;
            StatusCode = statusCode;
        }
    }
}
