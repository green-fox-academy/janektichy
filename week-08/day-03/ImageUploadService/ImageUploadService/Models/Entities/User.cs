using System;
using System.Collections.Generic;

#nullable disable

namespace ImageUploadService.Models.Entities
{
    public partial class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public int? Age { get; set; }
        public List<Uploadedimage> AllImages { get; set; }
    }
}
