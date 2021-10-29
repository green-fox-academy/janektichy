using FoxClub.Services;
using Microsoft.AspNetCore.Mvc;
using NodaTime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoxClub.Controllers
{
    [Route("greenfox")]
    public class HomeController : Controller
    {
        public AllFoxes RegistredFoxes { get; set; }
        public HomeController(AllFoxes foxes)
        {
            RegistredFoxes = foxes;                     
        }
        [HttpGet("foxInfo")]
        public IActionResult Index(string Name)
        {
            if (Name is not null)
            {
                RegistredFoxes.Foxes.Add(new Fox(Name));
                Fox choosenFox = RegistredFoxes.Foxes.Find(f => f.Name == Name);
                return View("Index", choosenFox);
            }
            return View("Index", RegistredFoxes.Foxes[0]);

        }
        [HttpGet("login")]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost("addFox")]
        public IActionResult GetName(string name)
        {
            return RedirectToAction("Index", new { Name = name });
        }
        [HttpGet("nutritionStore")]
        public IActionResult SetNutrition(string Name)
        {
            if (Name is not null)
            {
                Fox choosenFox = RegistredFoxes.Foxes.Find(f => f.Name == Name);
                return View("SetNutrition", choosenFox);
            }
            return View("SetNutrition", RegistredFoxes.Foxes[0]);
        }
        [HttpPost("setNutrition")]
        public IActionResult SetNutrition(string Name, string food, string drink)
        {
            Fox choosenFox = RegistredFoxes.Foxes.Find(f => f.Name == Name);
            choosenFox.Food = food;
            choosenFox.Drink = drink;
            StringBuilder builder = new StringBuilder();
            builder.Append(DateTime.Now);
            builder.Append($" Food has been changed to {food} and drink has been changed to {drink}");
            string action = builder.ToString();
            choosenFox.ActionHistory.Add(action);
            return RedirectToAction("Index", choosenFox);
        }
        [HttpGet("trickCenter")]
        public IActionResult LearnTricks(string Name)
        {
            if (Name is not null)
            {
                Fox choosenFox = RegistredFoxes.Foxes.Find(f => f.Name == Name);
                return View("LearnTricks", choosenFox);
            }
            return View("LearnTricks", RegistredFoxes.Foxes[0]);
        }
        [HttpPost("learnATrick")]
        public IActionResult LearnTrick(string Name, string trick)
        {
            Fox choosenFox = RegistredFoxes.Foxes.Find(f => f.Name == Name);
            choosenFox.Tricks.Add(trick);
            StringBuilder builder = new StringBuilder();
            builder.Append(DateTime.Now);
            builder.Append($" Learned to: {trick}");
            string action = builder.ToString();
            choosenFox.ActionHistory.Add(action);
            return RedirectToAction("Index", choosenFox);
        }
        [HttpGet("actionHistory")]
        public IActionResult ActionHistory(string Name)
        {
            Fox choosenFox = RegistredFoxes.Foxes.Find(f => f.Name == Name);
            return View("ActionHistory", choosenFox);
        }
    }
}
