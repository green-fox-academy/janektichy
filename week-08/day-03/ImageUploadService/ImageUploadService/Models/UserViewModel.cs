using ImageUploadService.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImageUploadService.Models
{
    public class UserViewModel
    {
        public User User { get; set; }
        public List<User> Users {get; set;}
        public bool IsImageValid { get; set; } //Neni to uplně ideální místo pro takovej boolean, ale momentálně je to nejjednodušší cesta, takže ho sem prostě šoupnu, i když je to bad practice:)

        public UserViewModel()
        {
            IsImageValid = true;
            Users = new List<User>();
        }
    }
}
