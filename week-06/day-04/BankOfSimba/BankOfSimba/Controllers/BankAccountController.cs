using BankOfSimba.Models;
using BankOfSimba.ModelViews;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankOfSimba.Controllers
{
    [Route("show")]
    public class BankAccountController : Controller
    {
        private static List<BankAccount> bankAccounts;

        static BankAccountController()
        {
            bankAccounts = new List<BankAccount>() {
                new BankAccount("Simba", 2000, "lion") { IsKing = true },
                new BankAccount("Scar", 50, "lion") { IsGood = false },
                new BankAccount("Pumba", 5000, "pig"),
                new BankAccount("Rafiki", 9000000, "monkey"),
                new BankAccount("Timon", 8000, "meerkat")
            };
        }
        [HttpGet("allAccs")]
        public IActionResult BankAccTable()
        {
            return View(new BankAccountsViewModel()
            {
                BankAccounts = bankAccounts
            });
        }
        [HttpGet("account")]
        public IActionResult Index()
        {
            BankAccount account = new BankAccount("Simba", 2000, "lion") ;
            return View(account);
        }
        [HttpGet("text")]
        public string Text()
        {
            string text = "This is an<em> HTML </ em > text. < b > Enjoy yourself! </ b >";
            return text;
        }
        
       [HttpPost("addAcc/create")]
        public ActionResult AddBankAccount(BankAccount acc)
        {
            bankAccounts.Add(acc);
            return RedirectToAction("BankAccTable");
        }
        [HttpPost("increaseBalance/pay")]
        public ActionResult IncreaseBalance(int accountIndex)
        {
            if (bankAccounts[accountIndex].IsKing)
            {
                bankAccounts[accountIndex].Balance += 100;
            }
            else if (bankAccounts[accountIndex].Name == "Dan")
            {
                bankAccounts[accountIndex].Balance -= 1000;
            }
            else
            {
                bankAccounts[accountIndex].Balance += 10;
            }
            return RedirectToAction("BankAccTable");
        }
    }
}
