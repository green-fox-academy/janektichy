using Microsoft.EntityFrameworkCore;
using RedditClone.Database;
using RedditClone.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedditClone.Services
{
    public class PostService
    {
        private ApplicationDbContext DbContext { get; }
        public PostService(ApplicationDbContext dbContext)
        {
            DbContext = dbContext;
        }
        public RedditPost AddPost(RedditPost post)
        {
            DbContext.Posts.Add(post);
            DbContext.SaveChanges();
            return post;
        }
        public List<RedditPost> FindAll()
        {
            return DbContext.Posts.Include(p => p.User).ToList();
        }
        public RedditPost FindById(int id)
        {
            return DbContext.Posts.Include(p => p.User).FirstOrDefault(p => p.Id == id);
        }
        public RedditPost EditById(int id, string like)
        {
            RedditPost selected = DbContext.Posts.Include(p => p.User).FirstOrDefault(p => p.Id == id);
            if (like == "+")
            {
                selected.Likes+=1;
            }
            if (like == "-" && selected.Likes > 0)
            {
                selected.Likes--;
            }
            DbContext.SaveChanges();
            return selected;
        }
    }
}
