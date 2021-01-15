using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControllersAndActions.Controllers
{
    public class DerivedController : Controller
    {
        public IActionResult Index() => View("Result", "Это деривед-контроллер");

        public ViewResult Headers() => View("DictionaryResult", Request.Headers.ToDictionary(kvp => kvp.Key, kvp => kvp.Value.First()));
    }
}
