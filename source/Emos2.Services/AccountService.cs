using Emos2.Domain.Security.Configurations;

using Emos2.Infrastructure.Entities.Database;
using Emos2.Infrastructure.Services;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emos2.Services
{
    public class AccountService : IAccountService
    {
        private readonly ApplicationUserManager userManager;

        public AccountService(ApplicationUserManager userManager)
        {
            this.userManager = userManager;
            this.userManager.PasswordValidator = PasswodStrengthConfig.GetPasswordStrengthOptions();
        }


        #region Private methods

        private void ProcessIdentityResult(string title, IdentityResult result)
        {
            if (!result.Succeeded)
            {
                string errorMessage = $"Title: {title}{Environment.NewLine}Error Message: {result.Errors.Aggregate((s1, s2) => $"{s1}, {s2}")}";

                throw new Exception(errorMessage);
            }
        }

        #endregion

        #region IAccountService implementations

        public void Activate(string username)
        {
            ApplicationUser user = this.userManager.FindByName(username);
            user.EmailConfirmed = true;

            IdentityResult activateResult = this.userManager.Update(user);

            this.ProcessIdentityResult("User Activation", activateResult);
        }

        public void ChangePassword(string username, string oldPassword, string newPassword)
        {
            ApplicationUser user = this.userManager.FindByName(username);
            IdentityResult changePasswordResult = this.userManager.ChangePassword(user.Id, oldPassword, newPassword);

            this.ProcessIdentityResult("Change User Password", changePasswordResult);
        }

        public void Deactivate(string username)
        {
            ApplicationUser user = this.userManager.FindByName(username);
            user.EmailConfirmed = false;

            IdentityResult deactivateResult = this.userManager.Update(user);

            this.ProcessIdentityResult("User deactivation", deactivateResult);
        }

        public bool Exists(string username)
        {
            return this.userManager.FindByName(username) != null;
        }

        public bool EmailExists(string email)
        {
            return this.userManager.FindByEmail(email) != null;
        }

        public bool ValidatePassword(string password)
        {
            IdentityResult passwordValidationResult = this.userManager.PasswordValidator.ValidateAsync(password).Result;

            return passwordValidationResult.Succeeded;
        }

        #endregion
    }
}
