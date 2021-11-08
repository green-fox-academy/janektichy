using ImageUploadService.Database;
using ImageUploadService.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImageUploadService.Services
{
    public class UserService
    {
        private imageserviceContext DbContext { get; }
        public UserService(imageserviceContext dbContext)
        {
            DbContext = dbContext;
        }
        public List<User> FindAll()
        {
            List<User> allUsers = DbContext.Users.Include(u => u.AllImages).ToList();
            return allUsers;
        }
        public User FindById(int id)
        {
            User selectedUser = DbContext.Users.Include(u => u.AllImages).FirstOrDefault(u => u.UserId == id);
            return selectedUser;
        }
        public void UploadImageForUser(string name, int userid)
        {
            Uploadedimage newImage = new Uploadedimage() { ImageName = name };
            if (userid > 0)
            {
                newImage.UserId = userid;
            }
            DbContext.Uploadedimages.Add(newImage);
            DbContext.SaveChanges();
        }
    }
}
