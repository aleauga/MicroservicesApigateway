using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Micro.Products.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        [Route("get/{id}")]
        public Task<IActionResult> GetProduct([FromRoute] int id)
        {
            return Task.FromResult<IActionResult>(Ok(value: id));
        }

        [HttpPost]
        [Route("new")]
        public Task<IActionResult> PostProduct([FromBody] int id)
        {
            return Task.FromResult<IActionResult>(Ok(value: id));
        }
    }
}
