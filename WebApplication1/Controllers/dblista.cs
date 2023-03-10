using Microsoft.AspNetCore.Mvc;
using WebApplication1.Actions;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class dblista : ControllerBase
    {
        [HttpGet("init")]
        public IActionResult init()
        {
            Actions.Action action = new Actions.Action();
            var response = action.makelist();
            return Ok(response);
        }
    }
}