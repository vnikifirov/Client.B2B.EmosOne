using Emos2.Infrastructure.Entities.Database;
using Emos2.MVC.Helpers;
using Microsoft.AspNet.Identity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Emos2.MVC.Controllers
{
    public class HomeController : BaseController
    {


        public ActionResult Index()
        {

            return View();
        }


        public ActionResult GetStaff()
        {
            APIRequest ar = new APIRequest("users");
            var response = ar.Get();

            IEnumerable<CEMUser> users = null;

            if (ar.responseModel.IsSuccess)
            {
                users = JsonConvert.DeserializeObject<List<CEMUser>>(response);
            }

            return View(users);
        }

    }
}