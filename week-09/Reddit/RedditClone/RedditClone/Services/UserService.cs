using Microsoft.EntityFrameworkCore;
using RedditClone.Database;
using RedditClone.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedditClone.Services
{
    public class UserService
    {
        private ApplicationDbContext DbContext { get; }
        public UserService(ApplicationDbContext dbContext)
        {
            DbContext = dbContext;
        }
        public User RegisterNewUser(string username, string password)
        {
            User user = new User() { Username = username, Password = password };
            DbContext.Users.Add(user);
            DbContext.SaveChanges();
            return user;
        }
        public User FindById(int id)
        {
            return DbContext.Users.Include(u => u.Posts).FirstOrDefault(u => u.Id == id);
        }
        public List<User> FindAll()
        {
            return DbContext.Users.Include(u => u.Posts).ToList();
        }
        public User FindByName(string username)
        {
            return DbContext.Users.Include(u => u.Posts).FirstOrDefault(u => u.Username == username);
        }
    }
}
