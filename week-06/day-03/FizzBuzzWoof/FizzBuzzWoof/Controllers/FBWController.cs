using FizzBuzzWoof.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FizzBuzzWoof.Controllers
{
    public class FBWController : Controller
    {
        [Route("")]
        public IActionResult Index()
        {
            var counter = new Counter();
            return View(counter);
        }
    }
}
