using ImageUploadService.Models;
using ImageUploadService.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImageUploadService.Controllers
{
    [Route("images")]
    public class ImageController : Controller
    {
        public ImageService ImageService { get; set; }
        public ImageController(ImageService service)
        {
            ImageService = service;
        }
        [HttpGet("list")]
        public IActionResult ListImages()
        {
            ImageViewModel model = new ImageViewModel();
            model.Images = ImageService.FindAll();
            return View(model);
        }
        [HttpPost("remove")]
        public IActionResult RemoveImage(int removeId)
        {
            var selectedImage = ImageService.FindById(removeId);
            ImageService.RemoveImageById(removeId);
            ImageViewModel model = new ImageViewModel();
            model.Images = ImageService.FindAll().Where(i => i.UserId == selectedImage.UserId).ToList();
            return View("ListImages", model);
        }
    }
}
