using BasicWebshop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicWebshop.ModelViews
{
    public class ListToShow
    {
        public List<Product> AllItems { get; set; }
        public ListToShow()
        {
            AllItems = new List<Product>();
        }
    }
}
