using firstORM.Database;
using firstORM.Todos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace firstORM.Services
{
    public class TodoService
    {
        private ApplicationDbContext DbContext { get; }
        
        public TodoService(ApplicationDbContext dbContext)
        {
            DbContext = dbContext;
        }
        public Todo FindById(long id)
        {
            return DbContext.Todos.Find(id);
        }
        public Todo AddTodo(Todo todo)
        {
            var savedTodo = DbContext.Todos.Add(todo).Entity;
            DbContext.SaveChanges();
            return savedTodo;
        }
        public List<Todo> FindAll()
        {
            List<Todo> allTodos = new List<Todo>();
            foreach (var item in DbContext.Todos)
            {
                allTodos.Add(item);
            }
            return allTodos;
        }
        public void RemoveTodo(Todo todo)
        {
            DbContext.Todos.Remove(todo);
            DbContext.SaveChanges();
        }
        public void EditTodo(long id, string title, bool isUrgent, bool isDone)
        {
            Todo selectedTodo = DbContext.Todos.FirstOrDefault(t => t.Id == id);
            if (title is not null)
            {
                selectedTodo.Title = title;
            }
            selectedTodo.IsUrgent = isUrgent;
            selectedTodo.IsDone = isDone;
            DbContext.SaveChanges();
        }
    }
}
