using Micro.User.Services.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Micro.User.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _service;

        public UserController(IUserService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("getuser/{id}")]
        public Task<IActionResult> GetUser([FromRoute]int id)
        {
            return Task.FromResult<IActionResult>(Ok(_service.GetUser(id)));
        }
    }
}
