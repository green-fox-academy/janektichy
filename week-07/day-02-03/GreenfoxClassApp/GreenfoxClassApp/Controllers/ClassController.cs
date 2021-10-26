using GreenfoxClassApp.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreenfoxClassApp.Controllers
{
    [Route("gfa")]
    public class ClassController : Controller
    {
        public StudentList StudentService { get; set; }
        public ClassController(StudentList service)
        {
            StudentService = service;
        }
        public IActionResult MainPage()
        {
            int count = StudentService.Count();
            return View("MainPage", count);
        }
        [HttpGet("list")]
        public IActionResult ListStudents()
        {
            List<string> names = StudentService.FindAll();
            return View("ListStudents", names);
        }
        [HttpGet("add")]
        public IActionResult AddStudent()
        {
            return View();
        }
        [HttpGet("save")]
        public IActionResult AddStudent([FromQuery] string name)
        {
            StudentService.AddStudent(name);
            return RedirectToAction("ListStudents");
        }
        [HttpGet("check")]
        public IActionResult CheckStudent([FromQuery] string name)
        {
            int doesStudentExist;
            List<string> names = StudentService.FindAll();
            if (name is not null)
            {
                if (names.Contains(name))
                {
                    doesStudentExist = 1;
                }
                else
                {
                    doesStudentExist = 2;
                }
            }
            else
            {
                doesStudentExist = 3;
            }
            return View("CheckStudent", doesStudentExist);
        }
    }
}
