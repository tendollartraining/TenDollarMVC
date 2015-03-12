using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ArtistsRequest.Models;

namespace PartyInvites.Controllers {
    public class HomeController : Controller {

        public ViewResult Index() {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good Morning" : "Good Afternoon";
            return View();
        }

        [HttpGet]
        public ViewResult ArtistForm() {
            return View();
        }

        [HttpPost]
        public ViewResult ArtistForm(ClientResponse clientResponse) {
            if (ModelState.IsValid) {
                // TODO: Email response to the kendallsoft academy
                return View("Thanks", clientResponse);
            } else {
                // there is a validation error
                return View();
            }
        }
    }
}