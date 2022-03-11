using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EquinoxCode.Controllers
{
    public class UserController : Controller
    {        
        public PartialViewResult Index()
        {
            return PartialView();
        }
        public ActionResult EnesCingal()
		{
            return View();
		}
        public ActionResult EyupCilkaya()
        {
            return View();
        }
        public ActionResult EmirGozcu()
        {
            return View();
        }
    }
}