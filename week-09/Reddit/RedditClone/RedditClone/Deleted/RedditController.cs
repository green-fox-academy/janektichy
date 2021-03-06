using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
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
    [AllowAnonymous]
    [Route("reddit")]
    public class RedditController : Controller
    {
        const string SessionId = "userid";
        public PostService PostService { get; set; }
        public RedditController(PostService service)
        {
            PostService = service;
        }
        [HttpGet("list")]
        public IActionResult ListPosts()
        {           
            RedditViewModel model = new RedditViewModel();
            model.Posts = PostService.FindAll().OrderByDescending(p => p.Likes).Take(10).ToList();
            return View(model);
        }
        [HttpGet("submitNew")]
        public IActionResult SubmitPost()
        {
            return View("SubmitNew");
        }
        [HttpPost("add")]
        public IActionResult AddPost(string title, string url)
        {
            RedditPost post = new RedditPost() { Title = title, URL = url };
            PostService.AddPost(post);
            return RedirectToAction("ListPosts");
        }
        [HttpPost("edit")]
        public IActionResult EditPost(string like, int id)
        {
            PostService.EditById(id, like);
            return RedirectToAction("ListPosts");
        }
        [HttpGet("login")]
        public IActionResult Login(string name)
        {
            HttpContext.Session.SetInt32(SessionId, 3);
            return RedirectToAction("Index", "User");
        }
    }
}
