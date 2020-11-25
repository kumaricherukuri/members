using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MemberApplication.Controllers
{
    public class MemberController : Controller
    {
        
        public ActionResult Index()
        {
            return View("_Members");
        }
    }
}