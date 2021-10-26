using BasicWebshop.Models;
using BasicWebshop.ModelViews;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicWebshop.Controllers
{
    [Route("webshop")]
    public class WebShop : Controller
    {
        static List<Product> allItems;
        static ListToShow products;
        static WebShop()
        {
            allItems = new List<Product>()
            {
                new Product("shoes","Clothes and Shoes", "joujoujou supr botičky", 69000, 10),
                new Product("kuřecí péro","Kuřecí Péra", "kámo to fakt potřebuješ bro", 420, 69),
                new Product("něco normálního","Abstracts", "docházej mi nápady", 5000, 2),
                new Product("nic", "Abstracts","to už došlo", 1, 0),
                new Product("botky", "Clothes and Shoes","musí tu bejt nike", 100, 5)
            };
            products = new ListToShow();
            products.AllItems = allItems;
        }

        [HttpGet("allItems")]
        public IActionResult ShopStructure()
        {
            return View(products);
        }
        [HttpPost("Avalible")]
        public ActionResult AvalibleItems()
        {
            products.AllItems = allItems.Where(l => l.InStock > 0).ToList();
            return RedirectToAction("ShopStructure");
        }
        [HttpPost("FromCheapest")]
        public ActionResult FromCheapest()
        {
            products.AllItems = allItems.OrderBy(l => l.Price).ToList();
            return RedirectToAction("ShopStructure");
        }
        [HttpPost("ContainsNike")]
        public ActionResult ContainsNike()
        {
            products.AllItems = allItems.Where(l => l.Description.Contains("Nike")).ToList();
            return RedirectToAction("ShopStructure");
        }
        [HttpPost("AvarageStock")]
        public ActionResult AvarageStock()
        {
            products.AllItems = allItems;
            return View(products);
        }
        [HttpPost("MostExpensiveAvalible")]
        public ActionResult MostExpensiveAvalible()
        {
            products.AllItems = products.AllItems = allItems.Where(l => l.InStock > 0).OrderByDescending(l => l.Price).ToList();
            return RedirectToAction("ShopStructure");
        }
        [HttpPost("Search")]
        public ActionResult Search(string hint)
        {
            if (hint != null)
            {
                products.AllItems = allItems.Where(l => l.Name.Contains(hint.ToLower()) || l.Description.Contains(hint.ToLower())).ToList();
            }
            return RedirectToAction("ShopStructure");
        }
    }
}
