using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UsefulUtilities.RandomColorDependency;

namespace UsefulUtilities.Controllers
{
    [Route("useful")]
    public class UtilitiesController : Controller
    {
        public CeaserService CeaserService { get; set; }
        public UtilityService UtilityService { get; set; }
        public UtilitiesController(UtilityService utility, CeaserService ceaser)
        {
            UtilityService = utility;
            CeaserService = ceaser;
        }
        [HttpGet("")]
        public IActionResult MainPage()
        {
            return View();
        }
        [HttpGet("colored")]
        public IActionResult RandomColoredPage()
        {
            string color = UtilityService.RandomColor();
            return View("RandomColoredPage", color);
        }
        [HttpGet("email")]
        public IActionResult ValidateEmail([FromQuery] string email)
        {
            bool isValid = UtilityService.ValidateEmail(email);
            return View("ValidateEmail", isValid);
        }
        [HttpPost("encodeOrDecode")]
        public IActionResult DecodeText(string encodeOrDecode, int encodeBy, string toEncode)
        {
            string result = "";
            if (encodeOrDecode == "encode")
            {
                result = CeaserService.Caesar(toEncode, encodeBy);
            }
            else if (encodeOrDecode == "decode")
            {
                result = CeaserService.Caesar(toEncode, -encodeBy);
            }
            
            return View("EncodeOrDecodeText", result);
        }
    }
}
