using ImageUploadService.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImageUploadService.Models
{
    public class ImageViewModel
    {
        public Uploadedimage Image { get; set; }
        public List<Uploadedimage> Images { get; set; }

        public ImageViewModel()
        {
            Images = new List<Uploadedimage>();
        }
    }
}
