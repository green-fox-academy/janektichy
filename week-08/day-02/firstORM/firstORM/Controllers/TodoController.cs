using firstORM.Models;
using firstORM.Services;
using firstORM.Todos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace firstORM.Controllers
{
    [Route("todo")]
    public class TodoController : Controller
    {
        public TodoService TodoService { get; set; }
        public TodoController(TodoService service)
        {
            TodoService = service;
        }
        [HttpGet("")]
        [HttpGet("list")]
        public IActionResult List()
        {
            ListViewModel model = new ListViewModel();
            model.Todos = TodoService.FindAll().Where(t => !t.IsDone).ToList();
            return View(model);
        }
        [HttpGet("addTodo")]
        public IActionResult AddTodo()
        {
            return View();
        }
        [HttpPost("add")]
        public IActionResult AddTodo(string task, bool isUrgent)
        {
            Todo newTodo = new Todo(task) { IsUrgent = isUrgent};
            TodoService.AddTodo(newTodo);
            return RedirectToAction("List");
        }
        [HttpGet("{id=id}/delete")]
        public IActionResult DeleteTodo([FromRoute] long id)
        {
            Todo selectedTodo = TodoService.FindById(id);
            TodoService.RemoveTodo(selectedTodo);
            return RedirectToAction("List");
        }
        [HttpGet("{id=id}/edit")]
        public IActionResult EditTodo([FromRoute] long id)
        {
            Todo selectedTodo = TodoService.FindById(id);
            ListViewModel model = new ListViewModel();
            model.Todo = selectedTodo;
            return View("EditTodo", model);
        }
        [HttpPost("{id=id}/edit")]
        public IActionResult EditTodo([FromRoute] long id, string title, bool isUrgent, bool isDone)
        {
            TodoService.EditTodo(id, title, isUrgent, isDone);
            return RedirectToAction("List");
        }
    }
}
