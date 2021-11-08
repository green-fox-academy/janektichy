using RedditClone.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedditClone.Models
{
    public class RedditViewModel
    {
        public List<RedditPost> Posts { get; set; }
        public RedditPost Post { get; set; }
    }
}
