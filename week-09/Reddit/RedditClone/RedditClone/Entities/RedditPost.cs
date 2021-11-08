using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RedditClone.Entities
{
    public class RedditPost
    {

        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string URL { get; set; }
        public int Likes { get; set; }
        public string DateAndTime { get; set; }
        public User User { get; set; }
        public int Userid { get; set; }

        public RedditPost()
        {
            Likes = 0;
            DateAndTime = DateTime.Now.ToString();
        }
    }
}
