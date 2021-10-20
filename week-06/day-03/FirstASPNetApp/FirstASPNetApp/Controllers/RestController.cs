using Microsoft.AspNetCore.Mvc;
using FirstASPNetApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstASPNetApp.Controllers
{
    [Route("api")]
    public class RestController : Controller
    {
        [HttpGet("greeting")]
        public Greeting Greet([FromQuery]string name)
        {
            Greeting greet = new Greeting();
            greet.Content = $"Hello {name}! This site was loaded {greet.ID} times since last server start.";
            return greet;
        }
    }
}
