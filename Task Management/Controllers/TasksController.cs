using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using Task_Management.Data;
using Task_Management.Models;

namespace Task_Management.Controllers
{
    public class TasksController : Controller
    {
        private readonly TaskData _context;

        public TasksController(TaskData context)
        {
            _context = context;
        }

        // GET: api/task
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TaskItems>>> GetTasks()
        {
            return await _context.Tasks.Include(t => t.User).ToListAsync();
        }

        // GET: api/task/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TaskItems>> GetTask(int id)
        {
            var task = await _context.Tasks.Include(t => t.User).FirstOrDefaultAsync(t => t.Id == id);

            if (task == null)
                return NotFound();

            return task;
        }

        // POST: api/task
        [HttpPost]
        public async Task<ActionResult<TaskItems>> CreateTask(TaskItems task)
        {
            task.CreatedAt = DateTime.UtcNow;

            _context.Tasks.Add(task);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetTask), new { id = task.Id }, task);
        }

        // PUT: api/task/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateTask(int id, TaskItems task)
        {
            if (id != task.Id)
                return BadRequest();

            _context.Entry(task).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.Tasks.Any(t => t.Id == id))
                    return NotFound();
                else
                    throw;
            }

            return NoContent();
        }

        // DELETE: api/task/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTask(int id)
        {
            var task = await _context.Tasks.FindAsync(id);
            if (task == null)
                return NotFound();

            _context.Tasks.Remove(task);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
