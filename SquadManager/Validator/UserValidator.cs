using FluentValidation;
using SquadManager.Models;

namespace SquadManager.Validator
{
    public class UserValidator : AbstractValidator<UserViewModel>
    {
        public UserValidator() { 
            RuleFor(user => user.Email).NotNull().WithMessage("E-mail não pode ser vazio!");
            RuleFor(user => user.Email).EmailAddress().WithMessage("Seu E-mail está errado!");
            RuleFor(user => user.Username).NotNull().WithMessage("Digite a senha!");
        }
    }
}
