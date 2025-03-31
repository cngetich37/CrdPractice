using CrdPractice.Data;
using CrdPractice.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CrdPractice.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TodoController : ControllerBase
    {
        private readonly TodoDbContext _context;
        public TodoController(TodoDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<IActionResult> GetTodos()
        {
            var todos = await _context.Todos.ToListAsync();
            return Ok(todos);
        }

        [HttpPost]
        public async Task<ActionResult<Todo>> CreateTodo(Todo todo)
        {
            var todoItem = new Todo
            {
                TodoItem = todo.TodoItem,
                IsCompleted = todo.IsCompleted,
            };

        await _context.Todos.AddAsync(todoItem);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(GetTodos), new { id = todoItem.Id }, todoItem);
        }
    }

}
