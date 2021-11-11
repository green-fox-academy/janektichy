using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TryingMiddleware.Controllers
{
    [Route("users")]
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
