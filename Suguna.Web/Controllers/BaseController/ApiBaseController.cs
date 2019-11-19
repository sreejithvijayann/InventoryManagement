using Microsoft.AspNetCore.Mvc;
using System;

namespace Suguna.Web.Controllers.BaseController
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiBaseController : ControllerBase
    {
        public Guid ContextUserId { get; private set; }
        public ApiBaseController()
        {
            ContextUserId = new Guid("08ce0784 - 6a47 - 4e50 - 88b7 - 4a0588c9d9b4");
        }
    }
}