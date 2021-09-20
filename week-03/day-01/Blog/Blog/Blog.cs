using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog
{
    class Blog
    {
        List<BlogPost> blog = new List<BlogPost>();

        public void Add(BlogPost blogPost)
        {
            this.blog.Add(blogPost);
        }
        public void Delete(int k)
        {
            this.blog.Remove(this.blog[k]);
        }
        public void Update(int k, BlogPost blog)
        {
            this.blog.Remove(this.blog[k]);
            this.blog.Insert(k, blog);
        }
        public void ShowBlog()
        {
            foreach (var post in this.blog)
            {
                post.ShowPost();
                Console.WriteLine();
            } 
        }
    }
}
