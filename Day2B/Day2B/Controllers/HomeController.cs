using Day2B.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Day2B.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Display()
        {
            StudSubj obj = new StudSubj {
                s_id = 100,
                name="sruthi",
                sub_id="mat123",
                sub_name="maths"
            };
            return View(obj);
        }
    }
}