using ControllersAndActions.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllersAndActions.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View("SimpleForm");

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //public ViewResult ReceiveForm()
        //{
        //    var name = Request.Form["name"];
        //    var city = Request.Form["city"];
        //    return View("Result", $"{name} живет в {city}");
        //}

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //public ViewResult ReceiveForm(string name, string city) => View("Result", $"Лошара {name} живет в {city}");

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //public void ReceiveForm(string name, string city)
        //{
        //    Response.StatusCode = 200;
        //    Response.ContentType = "text/html;charset=utf-8";
        //    byte[] content = Encoding.UTF8.GetBytes($"<html><body><font color=red>{name} живет в {city}</font></body></html>");
        //    Response.Body.WriteAsync(content, 0, content.Length);
        //}

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //public IActionResult ReceiveForm(string name, string city) => new CustomHtmlResult { Content = $"{name} влачит свое существование в {city}" };

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //public IActionResult ReceiveForm(string name, string city) => Content($"{name} влачит свое жалкое существование в {city}");

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public ViewResult ReceiveForm(string name, string city) => View("Result", $"{name} влачит свое жалкое существование в {city}");
    }
}
