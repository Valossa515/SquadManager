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
        [HttpPost("create")]
        public IActionResult Create(UserModel user)
        {
            if (user.Password == "123")
                return Ok(new { response = "OK" });
            else
                return Ok(new { response = "ERROR" });
        }
    }
}
