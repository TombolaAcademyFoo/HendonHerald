using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HendonHerald.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

        public ActionResult News()
        {
            return View();
        }

        public ActionResult Local()
        {
            return View();
        }

        public ActionResult Sport()
        {
            return View();
        }

        public ActionResult Stuff()
        {
            return View();
        }
	}
}