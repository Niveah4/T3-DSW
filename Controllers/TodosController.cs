using Microsoft.AspNetCore.Mvc;
using TodoWebService.Models;
using System.Collections.Generic;
using System.Linq;

namespace TodoWebService.Controllers
{
    [Route("api/todos")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        private static readonly List<TodoItem> _todos = new List<TodoItem>();

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_todos);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var todo = _todos.FirstOrDefault(t => t.Id == id);
            if (todo == null) return NotFound();
            return Ok(todo);
        }

        [HttpPost]
        public IActionResult Create([FromBody] TodoItem todo)
        {
            todo.Id = _todos.Any() ? _todos.Max(t => t.Id) + 1 : 1;
            _todos.Add(todo);
            return CreatedAtAction(nameof(GetById), new { id = todo.Id }, todo);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] TodoItem todo)
        {
            var existingTodo = _todos.FirstOrDefault(t => t.Id == id);
            if (existingTodo == null) return NotFound();
            existingTodo.Titulo = todo.Titulo;
            existingTodo.Descricao = todo.Descricao;
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var todo = _todos.FirstOrDefault(t => t.Id == id);
            if (todo == null) return NotFound();
            _todos.Remove(todo);
            return NoContent();
        }
    }
}