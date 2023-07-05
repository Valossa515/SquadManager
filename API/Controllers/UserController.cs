using API.Validator;
using Commun;
using FluentValidation.Results;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

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
            UserValidator validator = new UserValidator();
            ValidationResult results = validator.Validate(user);

            if(!results.IsValid)
            {
                foreach(var failure  in results.Errors)
                {
                    Console.WriteLine("Property " + failure.PropertyName + " failed validation. Error was: " + failure.ErrorMessage);
                }
            }

            if (user.Password == "123")
                return Ok(new { response = "OK" });
            else
                return Ok(new { response = "ERROR" });
        }

        [HttpPost("forgot")]
        public IActionResult Forgot([FromBody] string email)
        {
            return Ok(new { response = "OK" });
        }

        [HttpPost("reset")]
        public IActionResult Reset(UserModelReset user)
        {
            if (user.Password != null && user.ConfirmPassword != null)
            {
                return Ok(new { response = "OK" });
            }
            else
            {
                return Ok(new { response = "ERRO" });
            }
        }
    }
}
