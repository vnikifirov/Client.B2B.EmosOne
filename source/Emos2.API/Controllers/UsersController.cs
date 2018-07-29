using AutoMapper.QueryableExtensions;
using Emos2.API.Attributes;
using Emos2.API.Models.Users;
using Emos2.Infrastructure.Declares;
using Emos2.Infrastructure.Entities.Database;
using Emos2.Infrastructure.Entities.Users;
using Emos2.Infrastructure.Services;
 
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Emos2.API.Controllers
{
    public class UsersController : BaseController
    {
        private readonly IUserService userService;
      

        public UsersController(IUserService userService)
        {
            this.userService = userService;
            userService.SetClientConnectionString(getConnectionString());
        }

        [IsAuthorizeAttribute(Permission.CAN_ACCESS_ALL_MPTS_UNITS)]
        [HttpGet]
        [Route("users/")]
        public IHttpActionResult  GetUsers()
        {
            IEnumerable<UserModel> users = this.userService.SelectAll()
                                   .ProjectTo<UserModel>(this.Mapper.ConfigurationProvider)
                                   .Take(100)
                                   .OrderBy(u => u.FirstName);
            return Ok(users);
        }

        [IsAuthorizeAttribute(Permission.CAN_CREATE_JOB )]
        [HttpGet]
        [Route("users/{id}")]
        public IHttpActionResult GetUser(int id)
        {
            CEMUser userData = this.userService.Select(id);
            UserModel userModel = this.Mapper.Map<UserModel>(userData);

            return Ok( userModel);
        }

        //[HttpPost]
        //[Route("users/")]
        //[ValidateModelStateFilter]
        //public UserModel CreateUser(UserCreateModel userCreateModel)
        //{
        //    UserCreateData userCreateData = this.Mapper.Map<UserCreateData>(userCreateModel);

        //    this.userService.Create(userCreateData);

        //    UserData newUserData = this.userService.Select(userCreateData.Username);
        //    UserModel newUserModel = this.Mapper.Map<UserModel>(newUserData);

        //    return newUserModel;
        //}

        //[HttpPut]
        //[Route("users/")]
        //[ValidateModelStateFilter]
        //public UserModel UpdateUser(UserUpdateModel userUpdateModel)
        //{
        //    UserUpdateData userUpdateData = this.Mapper.Map<UserUpdateData>(userUpdateModel);

        //    this.userService.Update(userUpdateData);

        //    UserData userData = this.userService.Select(userUpdateData.Id);
        //    UserModel userModel = this.Mapper.Map<UserModel>(userData);

        //    return userModel;
        //}
    }
}
