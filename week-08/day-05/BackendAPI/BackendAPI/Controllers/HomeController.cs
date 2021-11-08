using BackendAPI.ApiObjects;
using BackendAPI.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendAPI.Controllers
{
    [Route("")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        public LogService LogService { get; set; }
        public HomeController(LogService service)
        {
            LogService = service;
        }
        public IActionResult Index()
        {
            return File("index.html", "text/html");
        }

        [HttpGet("doubling")]
        public DoubledInput DoubleIt([FromQuery] int input)
        {
            if (input == 0)
            {
                return new DoubledInput(input) { Error = "Please provide an input!" };
            }
            DoubledInput doubled = new DoubledInput(input);
            string endpoint = "/doubling";
            string data = $"input={input}";
            LogService.CreateLog(endpoint, data);
            return doubled;
        }
        [HttpGet("greeter")]
        public IActionResult GreetMe([FromQuery] string name, string title)
        {
            string endpoint = "/greeter";
            string data = $"name={name};title={title}";
            LogService.CreateLog(endpoint, data);
            if (name is null && title is null)
            {
                return StatusCode(400, new Greeter() { Error = "Please provide a name and a title!" });
            }
            else if (name is null)
            {
                return StatusCode(400, new Greeter() { Error = "Please provide a name!" });
            }
            else if (title is null)
            {
                return StatusCode(400, new Greeter() { Error = "Please provide a title!" });
            }
            else
            {
                return Ok(new Greeter() { Title = title, Name = name, Welcome_message = $"Oh, hi there {name}, my dear {title}!" });
            }
        }
        [HttpGet("appenda/{appendable}")]
        public IActionResult AppendA([FromRoute] string appendable)
        {
            string endpoint = "/appenda/{appendable}";
            string data = $"appendable={appendable}";
            LogService.CreateLog(endpoint, data);
            return Ok(new Append() { Appended = appendable + 'a'});
        }
        [HttpGet("appenda")]
        public IActionResult AppendAError()
        {
            return StatusCode(404);
        }
        [HttpPost("dountil/{operation}")]
        public IActionResult DoUntil([FromBody] DoUntil doUntil, [FromRoute] string operation)
        {
            if(doUntil.Until == 0)
            {
                return Ok(new DoUntil() { Error = "Please provide a number" });
            }
            if (operation == "sum")
            {
                doUntil.result = doUntil.SumUntil(doUntil.Until);
            }
            if (operation == "factor")
            {
                doUntil.result = doUntil.MultiplyUntil(doUntil.Until);
            }
            string endpoint = "/dountil/{operation}";
            string data = $"operation={operation};until={doUntil.Until}";
            LogService.CreateLog(endpoint, data);
            return Ok(doUntil);
        }
        [HttpPost("arrays")]
        public IActionResult Calculate([FromBody] NumbersCount numbers)
        {
            if (numbers.Numbers is null || numbers.What is null)
            {
                numbers.Error = "Please provide what to do with the numbers!";
                return Ok(numbers);
            }
            if (numbers.What == "sum")
            {
                numbers.result = numbers.Sum(numbers.Numbers);
            }
            if (numbers.What == "multiply")
            {
                numbers.result = numbers.Multiply(numbers.Numbers);
            }
            if (numbers.What == "double")
            {
                return Ok(new NumbersArr() { result = numbers.GetDoubled(numbers.Numbers) });
            }
            string endpoint = "/arrays";
            string data = $"array={numbers.Numbers.ToString()};operation={numbers.What}";
            LogService.CreateLog(endpoint, data);
            return Ok(numbers);
        }
        [HttpPost("sith")]
        public IActionResult Reverse([FromBody] SithTextGenerator textGenerator)
        {
            textGenerator.Sith_text = textGenerator.GenerateSithText(textGenerator.Text);
            return Ok(textGenerator);
        }
        [HttpPost("translate")]
        public IActionResult Translate([FromBody] Translator translator)
        {
            translator.Translated = translator.TranslateFromHungarian(translator.Text);
            return Ok(translator);
        }
        [HttpGet("log")]
        public IActionResult ShowLogs([FromQuery] int count, [FromQuery] int page, [FromQuery] string search)
        {
            if (count == 0 && page == 0 && search is null)
            {
                return Ok(LogService.FindAll());
            }
            else
            {
                if (count > 0)
                {
                    return Ok(LogService.FindAll().Take(count));
                }
                else if (page > 0)
                {
                    return Ok(LogService.FindAll().Skip(page * 10).Take(count));
                }
                else
                {
                    return Ok(LogService.FindAll().Where(l => l.Data.Contains(search) || l.Endpoint.Contains(search)));
                }
            }

            
        }
    }
}
