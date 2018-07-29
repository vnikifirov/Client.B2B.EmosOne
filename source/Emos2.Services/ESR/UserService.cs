using Emos2.Infrastructure.Entities.Database;
using Emos2.Infrastructure.Repositories;
using Emos2.Infrastructure.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emos2.Infrastructure.Entities.Users;
using System.Transactions;
using Microsoft.AspNet.Identity;
using Emos2.Domain.Security.Configurations;

namespace Emos2.Services
{
    public class UserService : ServiceBaseESR<CEMUser>, IUserService
    {
        //private readonly ApplicationUserManager userManager;
        //private readonly ApplicationRoleManager roleManager;
        private IRepositoryESR<CEMUser> userRepository;


        public UserService(IRepositoryESR<CEMUser> userRepository) : base(userRepository)
        {       
            this.userRepository = userRepository;
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

        #region IUserService implementations

        public void Create(UserCreateData userCreateData)
        {
            using (var transactionScope = new TransactionScope())
            {
                ApplicationUser user = new ApplicationUser
                {
                    Id = userCreateData.Username,
                    UserName = userCreateData.Username,
                    Email = userCreateData.Email,
                    PhoneNumber = userCreateData.Phone
                };

                //IdentityResult createUserAccountResult = this.userManager.Create(user, userCreateData.Password);
                //this.ProcessIdentityResult("Creating User Account", createUserAccountResult);

                CEMUser userData = this.baseRepository.Create();
                userData = this.mapper.Map<UserCreateData, CEMUser>(userCreateData, userData);
               // userData.AccountDataId = user.Id;
                this.Save(userData);

                //IdentityResult addingRolesToUserResult = this.userManager.AddToRoles(user.Id, userCreateData.Roles.ToArray());
                //this.ProcessIdentityResult("Adding Roles to the User", addingRolesToUserResult);

                transactionScope.Complete();
            }
        }

        public void Update(UserUpdateData userUpdateData)
        {
            using (var transactionScope = new TransactionScope())
            {
                //ApplicationUser user = this.userManager.FindByName(userUpdateData.Username);
                //user.Email = userUpdateData.Email;
                //user.PhoneNumber = userUpdateData.Phone;

                //IdentityResult updateUserAccountResult = this.userManager.Update(user);
                //this.ProcessIdentityResult("Update User Account data", updateUserAccountResult);

                CEMUser userData = this.Select(userUpdateData.Id);
                userData = this.mapper.Map<UserUpdateData, CEMUser>(userUpdateData, userData);
                this.Save(userData);

                //IEnumerable<string> oldUserRoles = this.userManager.GetRoles(user.Id);
                //IdentityResult removeOldUserRolesResult = this.userManager.RemoveFromRoles(user.Id, oldUserRoles.ToArray());
                //this.ProcessIdentityResult("Update User Roles", removeOldUserRolesResult);

                //IdentityResult addingUserRolesResult = this.userManager.AddToRoles(user.Id, userUpdateData.Roles.ToArray());
                //this.ProcessIdentityResult("Update User Roles", addingUserRolesResult);

                transactionScope.Complete();
            }
        }

        public CEMUser Select(string username)
        {
            CEMUser userData = null;
          //  ApplicationUser applicationUser = this.userManager.FindByName(username);

            //if (applicationUser != null)
            //{
            //    userData = this.SelectAllBy(u => u.AccountDataId == applicationUser.Id).First();
            //}

            return userData;
        }

        #endregion
    }
}
