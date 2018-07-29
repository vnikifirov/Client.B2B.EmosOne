using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Emos2.MVC.Models.ResponseModel
{
    public class ResponseModel
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public string Data { get; set; }

    }
}