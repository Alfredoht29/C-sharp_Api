using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    public class Lista : Controller
    {
        [HttpGet("init")]
        public void init()
        {
          /*  recorrer();
            recorrerfor();*/
        }
        /*public List<UserModel> Makelist()
        {
            List<UserModel> userlist = new List<UserModel>();
            userlist.Add(new UserModel { Id = 2, Name = "XD", Email = "email@mail.com" });
            userlist.Add(new UserModel { Id = 3, Name = "cocadepina", Email = "cocal@mail.com" });
            userlist.Add(new UserModel { Id = 4, Name = "cocanormal", Email = "coca@email.com" });
            return userlist;
        }
        public void recorrer()
        {
            var userlist = Makelist();
            foreach (var user in userlist)
            {
                if(user.Id%2 == 0)
                {
                    Console.WriteLine(user.Name);
                }
            }
        }
        public void recorrerfor()
        {
            var userlist = Makelist();
            for(int i = 0; i < userlist.Count; i++)
            {
                Console.WriteLine(userlist[i].Name);
            }
        }*/
    }
}
