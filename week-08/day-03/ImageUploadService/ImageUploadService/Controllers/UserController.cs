using ImageUploadService.Models;
using ImageUploadService.Models.Entities;
using ImageUploadService.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImageUploadService.Controllers
{
    [Route("users")]
    public class UserController : Controller
    {
        public UserService UserService { get; set; }
        public UserController(UserService service)
        {
            UserService = service;
        }
        [HttpGet("list")]
        public IActionResult ListUsers()
        {
            UserViewModel model = new UserViewModel();
            model.Users = UserService.FindAll().Where(u => u.AllImages.Count() > 0).ToList();
            return View(model);
        }
        [HttpGet("imagesById")]
        public IActionResult ShowImages([FromQuery] int id)
        {
            ImageViewModel model = new ImageViewModel();
            User selectedUser = UserService.FindById(id);
            model.Images = selectedUser.AllImages;
            return View("../Image/ListImages", model);
        }
    }
}
