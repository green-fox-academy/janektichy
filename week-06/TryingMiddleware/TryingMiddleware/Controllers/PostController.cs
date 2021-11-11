using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TryingMiddleware.Controllers
{
    [AllowAnonymous]
    [Route("posts")]
    public class PostController : Controller
    {
        const string SessionId = "userid";
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet("login")]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost("log")]
        public IActionResult Login(string name)
        {
            HttpContext.Session.SetInt32(SessionId, 3);
            return RedirectToAction("Index", "User");
        }
    }
}
