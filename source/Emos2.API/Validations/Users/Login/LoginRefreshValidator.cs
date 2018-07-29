using Emos2.API.Models.Users.Login;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Emos2.API.Validations.Users.Login
{
    public class LoginRefreshValidator : AbstractValidator<LoginRefreshModel>
    {
        public LoginRefreshValidator()
        {
            RuleFor(lr => lr.ClientId).NotEmpty();
            RuleFor(lr => lr.RefresToken).NotEmpty();
        }
    }
}