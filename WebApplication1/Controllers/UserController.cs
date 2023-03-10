using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;


namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet(Name = "user")]
        public UserModel GetUsers()
        {
            UserModel user1 = new UserModel();
            user1.Id = 1;
            user1.Name = "Test";
            user1.Email = "test@gmail.com";
            return user1;
        }
    }
}
