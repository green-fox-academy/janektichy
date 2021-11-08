using ImageUploadService.Models;
using ImageUploadService.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ImageUploadService.Controllers
{
    [Route("upload")]
    public class FileUploadController : Controller
    {
        public UserService UserService { get; set; }
        public FileUploadController(UserService service)
        {
            UserService = service;
        }
        [HttpGet("image")]
        public IActionResult FileUpload()
        {
            UserViewModel model = new UserViewModel();
            model.Users = UserService.FindAll();
            return View(model);
        }
        [HttpPost("saveImage")]
        public IActionResult SaveImage(int userid, IFormFile file)
        {
            UserViewModel model = new UserViewModel();
            if (file.Length > 2_000_000)
            {
                model.IsImageValid = false;
                model.Users = UserService.FindAll();
                return View("FileUpload", model);
            }
            else
            {
                var path = Path.Combine(
                        Directory.GetCurrentDirectory(), "Uploads",
                        file.FileName);
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    file.CopyTo(stream);
                }
                UserService.UploadImageForUser(file.FileName, userid);
                model.Users = UserService.FindAll();
                return View("../User/ListUsers", model);
            }
        }
        [HttpGet("showImage")]
        public IActionResult ShowImage()
        {
            return View();
        }

    }
}
