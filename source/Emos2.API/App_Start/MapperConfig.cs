using AutoMapper;
using Emos2.API.Models.Events;
using Emos2.API.Models.Users;
using Emos2.Infrastructure.Entities.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Emos2.API.App_Start
{
    public class MapperConfig
    {

        public static IMapper Mapper;


        public static void InitializeMapper()
        {
            MapperConfiguration mapperConfiguration = new MapperConfiguration(cfg => {

                #region Users

                //cfg.CreateMap<UserCreateModel, UserCreateData>();
                //cfg.CreateMap<UserUpdateModel, UserUpdateData>();
                cfg.CreateMap<CEMUser, UserModel>();

                #endregion


                cfg.CreateMap<Event, EventModel>();


            });

            Mapper = mapperConfiguration.CreateMapper();
        }

    }
}