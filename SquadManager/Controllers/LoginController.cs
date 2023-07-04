using FluentValidation.Results;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using SquadManager.Models;
using SquadManager.Validator;
using System.ComponentModel.DataAnnotations;
using ValidationResult = FluentValidation.Results.ValidationResult;

namespace SquadManager.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            UserViewModel user = new UserViewModel();
            UserValidator validator = new UserValidator();

            ValidationResult results = validator.Validate(user);

            if (!results.IsValid)
            {
                foreach(var failure  in results.Errors)
                {
                    Console.WriteLine("Property " + failure.PropertyName + " Failed Validation. Error was: " + failure.ErrorMessage);
                }
            }


            return View("Index", user);
        }

        [HttpPost]
        public IActionResult Test(UserViewModel user)
        {
            user.Email = "E-mail enviado!";
            return View("Index", user);
        }

        public IActionResult SignUp()
        {
            return View();
        }
    }

   
}
