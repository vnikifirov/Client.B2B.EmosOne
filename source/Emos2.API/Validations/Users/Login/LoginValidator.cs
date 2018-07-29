using Emos2.API.Models.Users.Login;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Emos2.API.Validations.Users.Login
{
    public class LoginValidator : AbstractValidator<LoginModel>
    {
        public LoginValidator()
        {
            RuleFor(l => l.Username).NotEmpty();
            RuleFor(l => l.Password).NotEmpty();
        }
    }
}