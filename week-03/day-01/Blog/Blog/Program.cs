using System;

namespace Blog
{
    class Program
    {
        static void Main(string[] args)
        {
            BlogPost post1 = new BlogPost("pepa", "je", "největší", "borec");
            BlogPost post2 = new BlogPost("honza", "je", "největší", "frajer");
            BlogPost post3 = new BlogPost("luky", "je", "největší", "máslo");
            BlogPost post4 = new BlogPost("franta", "je", "největší", "knedlík");

            Blog blog = new Blog();
            blog.Add(post1);
            blog.Add(post2);
            blog.Add(post3);

            blog.Update(2, post4);
            blog.ShowBlog();

        }
    }
}
