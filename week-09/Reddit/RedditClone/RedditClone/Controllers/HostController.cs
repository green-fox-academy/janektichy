using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using RedditClone.Entities;
using RedditClone.Models;
using RedditClone.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedditClone.Controllers
{
    [Route("host")]
    [AllowAnonymous]
    public class HostController : Controller
    {
        const string SessionId = "userid";
        public UserService UserService { get; set; }
        public PostService PostService { get; set; }
        //public IServiceProvider Services { get; set; }
        //public ISession Session { get; set; }
        public HostController(PostService service, UserService userService)
        {
            PostService = service;
            UserService = userService;
            //Services = services;
            //Session = Services.GetRequiredService<IHttpContextAccessor>().HttpContext.Session;
        }
        [HttpGet("list")]
        public IActionResult ListPosts()
        {
            RedditViewModel model = new RedditViewModel();
            model.Posts = PostService.FindAll().OrderByDescending(p => p.Likes).Take(10).ToList();
            return View(model);
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
            User logUser = UserService.FindByName(username);
            if (action == "register")
            {
                if (logUser is not null)
                {
                    model.Error = true;
                    return View("RegisterUser", model);
                }
                model.Error = false;
                logUser = UserService.RegisterNewUser(username, password);
                HttpContext.Session.SetInt32(SessionId, logUser.Id);
                return RedirectToAction("ListPosts", "User");
            }
            if (action == "login")
            {
                if (logUser is null || logUser.Password != password)
                {
                    model.Error = true;
                    return View("RegisterUser", model);
                }
                model.Error = false;
                HttpContext.Session.SetInt32(SessionId, logUser.Id);
                return RedirectToAction("ListPosts", "User");
            }
            return View("RegisterUser");
        }
    }
}
