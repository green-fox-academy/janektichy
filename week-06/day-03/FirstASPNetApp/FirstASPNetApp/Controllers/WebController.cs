using Microsoft.AspNetCore.Mvc;
using FirstASPNetApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstASPNetApp.Controllers
{
    [Route("web")]
    public class WebController : Controller
    {
        [HttpGet("greeting")]
        public IActionResult Greeting()
        {
            var greeting = new Greeting()
            {
                ID = 1,
                Content = "from the model"
            };

            return View(greeting);
        }
    }
}
