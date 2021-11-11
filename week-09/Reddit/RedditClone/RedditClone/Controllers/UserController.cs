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
    [Route("users")]
    public class UserController : Controller
    {
        public UserService UserService { get; set; }
        public PostService PostService { get; set; }
        //public IServiceProvider Services { get; set; }
        //public ISession Session { get; set; }

        //public int CurrentUserId { get; }
        //public User CurrentUser { get; }
        public UserController(UserService service, PostService postService)
        {
            UserService = service;
            PostService = postService;
            //CurrentUserId = httpContext.Session.GetInt32("userid").Value;
            //CurrentUser = UserService.FindById(CurrentUserId);

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
        [HttpPost("edit")]
        public IActionResult EditPost(string like, int id)
        {
            PostService.EditById(id, like);
            return RedirectToAction("ListPosts");
        }
        [HttpGet("submitNew")]
        public IActionResult SubmitPost()
        {
            return View("SubmitNew");
        }
        [HttpPost("add")]
        public IActionResult AddPost(string title, string url)
        {
            int CurrentUserId = HttpContext.Session.GetInt32("userid").Value;
            HttpContext.Session.SetInt32("userid", CurrentUserId);
            RedditPost post = new RedditPost() { Title = title, URL = url, Userid = CurrentUserId };
            PostService.AddPost(post);
            return RedirectToAction("ListPosts");
        }
    }
}
