using RedditClone.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedditClone.Models
{
    public class UserViewModel
    {
        public User loggedUser { get; set; }
        public List<User> AllUsers { get; set; }

        public bool Error { get; set; }
    }
}
