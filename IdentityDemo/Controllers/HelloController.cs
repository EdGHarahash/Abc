using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IdentityDemo.Controllers
{
    [Authorize]
    public class HelloController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}