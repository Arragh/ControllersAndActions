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

        public JsonResult Index2() => Json(new[] { "Ferrari", "Lamborghini", "Maserati" });
        public ContentResult Index3() => Content("[\"Ferrari\",\"Lamborghini\",\"Maserati\"]");
        public ObjectResult Index4() => Ok(new string[] { "Шла Саша по шоссе и сосала сушку" });
        public VirtualFileResult Index5() => File("/dist/bootstrap/css/bootstrap.css", "text/css");
        public StatusCodeResult Index6() => NotFound();
    }
}
