using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emos2.Domain.Security.Configurations
{
    public static class PasswodStrengthConfig
    {
        public static PasswordValidator GetPasswordStrengthOptions()
        {
            PasswordValidator passwordValidator = new PasswordValidator();
            bool setPasswordStrenght = bool.Parse(ConfigurationManager.AppSettings["SetPasswordStrenght"]);

            if (setPasswordStrenght)
            {
                passwordValidator.RequireUppercase = true;
                passwordValidator.RequireLowercase = true;
                passwordValidator.RequireNonLetterOrDigit = true;
                passwordValidator.RequireDigit = true;
                passwordValidator.RequiredLength = 8;
            }

            return passwordValidator;
        }
    }
}
