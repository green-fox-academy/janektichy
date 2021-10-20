using GreetTheWorld.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreetTheWorld.Controllers
{
    [Route("")]
    public class GreetController : Controller
    {
        [HttpGet("greet")]
        public IActionResult Greet()
        {
            var greet = new Greeting();
            return View(greet);
        }
    }
}
