using BasicWebshop.Models;
using BasicWebshop.ModelViews;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicWebshop.Controllers
{
    [Route("more-filters")]
    public class MoreFiltersController : Controller
    {
        static List<Product> allItems;
        static ListToShow products;
        static MoreFiltersController()
        {
            allItems = new List<Product>()
            {
                new Product("Shoes","Clothes and Shoes", "joujoujou supr botičky", 69000, 10),
                new Product("kuřecí péro","Kuřecí Péra", "kámo to fakt potřebuješ bro", 420, 69),
                new Product("něco normálního","Abstracts", "docházej mi nápady", 5000, 2),
                new Product("nic", "Abstracts","to už došlo", 1, 0),
                new Product("Botky", "Clothes and Shoes","musí tu bejt Nike", 100, 5)
            };
            products = new ListToShow();
            products.AllItems = allItems;
        }
        [HttpGet("")]
        public IActionResult MoreFilters()
        {
            return View(products);
        }
        [HttpPost("Clothes&Shoes")]
        public ActionResult ClothesAndShoes()
        {
            products.AllItems = allItems.Where(l => l.Type == "Clothes and Shoes").ToList();
            return RedirectToAction("MoreFilters");
        }
        [HttpPost("KureciPera")]
        public ActionResult KureciPera()
        {
            products.AllItems = allItems.Where(l => l.Type == "Kuřecí Péra").ToList();
            return RedirectToAction("MoreFilters");
        }
        [HttpPost("Abstracts")]
        public ActionResult Abstracts()
        {
            products.AllItems = allItems.Where(l => l.Type == "Abstracts").ToList();
            return RedirectToAction("MoreFilters");
        }
        [HttpPost("Euro")]
        public ActionResult Euro()
        {
            for (int i = 0; i < allItems.Count; i++)
            {
                allItems[i].Price = allItems[i].PriceInEur;
            }
            return RedirectToAction("MoreFilters");
        }
        [HttpPost("OriginalCurrency")]
        public ActionResult OriginalCurrency()
        {
            for (int i = 0; i < allItems.Count; i++)
            {
                allItems[i].Price = allItems[i].PriceInCzk;
            }
            return RedirectToAction("MoreFilters");
        }
        [HttpPost("FilterByPrice")]
        public ActionResult FilterByPrice(string button, int price)
        {
            if (button.ToLower() == "above")
            {
                products.AllItems = allItems.Where(l => l.Price > price).ToList();
            }
            else if (button.ToLower() == "below")
            {
                products.AllItems = allItems.Where(l => l.Price < price).ToList();
            }
            else if (button.ToLower() == "exactly")
            {
                products.AllItems = allItems.Where(l => l.Price == price).ToList();
            }
            return RedirectToAction("MoreFilters");
        }
    }
}
