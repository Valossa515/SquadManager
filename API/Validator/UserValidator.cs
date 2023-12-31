﻿using Commun;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace API.Validator
{
    public class UserValidator : AbstractValidator<UserModel>
    {
        public UserValidator()
        {
            RuleFor(user => user.Username).NotNull().WithMessage("Username vazio");
            RuleFor(user => user.Email).NotNull().WithMessage("E-mail vazio");
            RuleFor(user => user.Email).EmailAddress().WithMessage("O e-mail está inválido");
            RuleFor(user => user.Password).NotNull().WithMessage("Digite a senha");
            RuleFor(user => user.Password).Equal(o => o.ConfirmPassword).WithMessage("Senhas diferentes");
        }
    }
}
