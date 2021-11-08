using System;
using System.Collections.Generic;

#nullable disable

namespace ImageUploadService.Models.Entities
{
    public partial class Uploadedimage
    {
        public int ImageId { get; set; }
        public int? UserId { get; set; }
        public string ImageName { get; set; }
        public User User { get; set; }
    }
}
