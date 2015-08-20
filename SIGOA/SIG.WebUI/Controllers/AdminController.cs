using SIG.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SIG.WebUI.Controllers
{
    [CustomAuthorize(Roles= "Admin")]
 // [CustomAuthorize(Users = "1")]
    public class AdminController : BaseController
    {
        //
        // GET: /Admin/
        public ActionResult Index()
        {
            return View();
        }
    }
}