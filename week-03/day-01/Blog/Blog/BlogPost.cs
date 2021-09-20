using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog
{
    class BlogPost
    {
        private string authorName;
        private string title;
        private string text;
        private string publicationDate;

        public BlogPost(string authorName, string title, string text, string publicationDate)
        {
            this.authorName = authorName;
            this.title = title;
            this.text = text;
            this.publicationDate = publicationDate;
        }
        public void ShowPost()
        {
            Console.WriteLine($"The author: {this.authorName}" +
                $"\nTitle: {this.title}" +
                $"\n{this.text}" +
                $"\nDate: {this.publicationDate}");
        }
    }
}
