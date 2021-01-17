using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControllersAndActions.Controllers
{
    public class ExampleController : Controller
    {
        public ViewResult Index() => View(DateTime.Now);
        public ViewResult Result() => View((object)"Hello redirect");

        //public LocalRedirectResult Redirect() => LocalRedirect("google.com");
        //public RedirectToRouteResult Redirect() => RedirectToRoute(new { Controller = "Example", Action = "Result", id = "TestID" });
        //public RedirectToActionResult Redirect() => RedirectToAction(nameof(Result));
        public RedirectToActionResult Redirect() => RedirectToAction("Index", "Home");
    }
}
