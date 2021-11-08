using Microsoft.AspNetCore.Mvc;
using RedditClone.Entities;
using RedditClone.Models;
using RedditClone.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedditClone.Controllers
{
    [Route("users")]
    public class UserController : Controller
    {
        public UserService UserService { get; set; }
        public UserController(UserService service)
        {
            UserService = service;
        }
        [HttpGet("register")]
        public IActionResult RegisterUser()
        {
            UserViewModel model = new UserViewModel();
            return View(model);
        }
        [HttpPost("addOrLogin")]
        public IActionResult AddOrLoginUser(string username, string password, string action)
        {
            UserViewModel model = new UserViewModel();
            if (action == "register")
            {
                if (UserService.FindByName(username) is not null)
                {
                    model.Error = false;
                    return View("RegisterUser", model);
                }
                model.Error = false;
                UserService.RegisterNewUser(username, password);
                return RedirectToAction("RedditClone/Controllers/RedditController/ListPosts");
            }
            if (action == "login")
            {
                User user = UserService.FindByName(username);
                if (user is null || user.Password != password)
                {
                    model.Error = true;
                    return View("RegisterUser", model);
                }
                model.Error = false;
                return RedirectToAction("RedditClone/Controllers/RedditController/ListPosts");
            }
            return View("RegisterUser");
        }
    }
}
