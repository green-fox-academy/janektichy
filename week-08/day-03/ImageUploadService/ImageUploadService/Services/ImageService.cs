using ImageUploadService.Database;
using ImageUploadService.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImageUploadService.Services
{
    public class ImageService
    {
        private imageserviceContext DbContext { get; }
        public ImageService(imageserviceContext dbContext)
        {
            DbContext = dbContext;
        }
        public List<Uploadedimage> FindAll()
        {
            List<Uploadedimage> allImages = DbContext.Uploadedimages.Include(i => i.User).ToList();
            return allImages;
        }
        public void RemoveImageById(int id)
        {
            var selectedImage = DbContext.Uploadedimages.FirstOrDefault(i => i.ImageId == id);
            DbContext.Remove(selectedImage);
            DbContext.SaveChanges();
        }
        public Uploadedimage FindById(int id)
        {
            return DbContext.Uploadedimages.FirstOrDefault(i => i.ImageId == id);
        }
    }
}
