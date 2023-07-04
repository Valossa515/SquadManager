using Commun;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpPost]
        public IActionResult Login(UserModel user)
        {
            if(user.Password == "yhdeksan515")
            {
                return Ok(new { response = "ok" });
            }
            else
            {
                return Ok(new { response = "ERRO!" });
            }
           
        }
    }
}
