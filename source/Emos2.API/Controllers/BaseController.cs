

using AutoMapper;
using Emos2.API.Attributes;
using Emos2.API.Helpers;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Emos2.API.Controllers
{

    [ExceptionHandling]
    public abstract class BaseController : ApiController
    {
        protected IMapper Mapper;
        private string connectionString;
        private string clientCode;

        public BaseController()
        {
            // this is done on application startup
            Mapper = App_Start.MapperConfig.Mapper;

            // get ClientCode
            if (System.Web.HttpContext.Current.Request.Headers != null)
            {
                IEnumerable<string> headerValues = System.Web.HttpContext.Current.Request.Headers.GetValues("ClientCode");
                if (headerValues != null)
                {
                      clientCode = headerValues.FirstOrDefault();
                }
            }
        }


        protected string getConnectionString()
        {
            if (string.IsNullOrEmpty(connectionString))
            {
                connectionString = CacheHelper.GetConnectionString(clientCode);
            }

            return connectionString;
        }


        //private void InitializeMapper()
        //{
        //    MapperConfiguration mapperConfiguration =  new MapperConfiguration(cfg => {

        //        #region Users

        //        //cfg.CreateMap<UserCreateModel, UserCreateData>();
        //        //cfg.CreateMap<UserUpdateModel, UserUpdateData>();
        //      //  cfg.CreateMap<UserData, UserModel>();

        //        #endregion
        //    });

        //    this.Mapper = mapperConfiguration.CreateMapper();
        //}
    }
}
