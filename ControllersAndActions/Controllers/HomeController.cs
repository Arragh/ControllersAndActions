using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControllersAndActions.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View("SimpleForm");
        //public ViewResult ReceiveForm()
        //{
        //    var name = Request.Form["name"];
        //    var city = Request.Form["city"];
        //    return View("Result", $"{name} живет в {city}");
        //}

        public ViewResult ReceiveForm(string name, string city) => View("Result", $"Лошара {name} живет в {city}");
    }
}
