using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Suguna.Common
{
    public enum ApiStatusCode
    {
        ItemNotFound = HttpStatusCode.NotFound,
        Success = HttpStatusCode.OK,
        UpdateFailed = HttpStatusCode.BadRequest,
        ValidationFailed = HttpStatusCode.BadRequest,
    }
}
