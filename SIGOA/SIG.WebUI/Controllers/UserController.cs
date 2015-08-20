using SIG.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SIG.WebUI.Controllers
{
    [CustomAuthorize(Roles = "User")]
    // [CustomAuthorize(Users = "1,2")]
    public class UserController : BaseController
    {
        //
        // GET: /User/
        public ActionResult Index()
        {
            return View();
        }
    }
}