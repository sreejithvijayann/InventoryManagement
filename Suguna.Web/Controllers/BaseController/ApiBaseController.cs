using Microsoft.AspNetCore.Mvc;
using Suguna.Common;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace Suguna.Web.Controllers.BaseController
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiBaseController : ControllerBase
    {
        public Guid ContextUserId { get; private set; }
        public ApiBaseController()
        {
            ContextUserId = new Guid("08ce0784-6a47-4e50-88b7-4a0588c9d9b4");
        }

        protected Task<IActionResult> GetResponseAsync(ResponseDTO response)
        {
            IActionResult result = null;
            switch (response.StatusCode)
            {
                case ApiStatusCode.Success:
                    result = Ok(response);
                    break;
                case ApiStatusCode.ItemNotFound:
                    result = NotFound(response);
                    break;
                default:
                    result = BadRequest(response);
                    break;
            }

            return Task.FromResult(result);
        }
    }
}