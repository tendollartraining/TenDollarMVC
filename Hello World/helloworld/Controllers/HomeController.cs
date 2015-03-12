using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloWorld.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()        
        {
           //Note to put something on screen using The Content Method if must be onverted to a string

           //return Content(@"<b>Hello World</b>");
           //return Content("Hello World");
           //return Content((2*2).ToString());
           //Use System Library
            var dt = System.DateTime.Now.ToString();
           // return Content(dt);
           return View();
        }

        //Insert Code snippet here
        // /home/MyAction is route
        public ActionResult MyAction()
        {
              return Content("Hello My Action");
        }
    }
}