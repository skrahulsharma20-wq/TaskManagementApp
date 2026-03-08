using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TaskManagementApp.Data;
using TaskManagementApp.Models;

namespace TaskManagementApp.Controllers
{
    public class TasksController : Controller
    {
        private readonly AppDbContext _context;

        public TasksController(AppDbContext context)
        {
            _context = context;
        }

        // READ + SEARCH
        public async Task<IActionResult> Index(string searchString)
        {
            var tasks = from t in _context.Tasks
                        select t;

            if (!string.IsNullOrEmpty(searchString))
            {
                tasks = tasks.Where(t =>
                    t.Title.Contains(searchString) ||
                    t.Description.Contains(searchString));
            }

            return View(await tasks.ToListAsync());
        }

        // CREATE GET
        public IActionResult Create()
        {
            return View();
        }

        // CREATE POST
        [HttpPost]
        public async Task<IActionResult> Create(TaskItem task)
        {
            if (ModelState.IsValid)
            {
                task.CreatedOn = DateTime.Now;
                task.CreatedById = 1;
                task.CreatedByName = "Rahul";

                _context.Add(task);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(task);
        }

        // EDIT GET
        public async Task<IActionResult> Edit(int id)
        {
            var task = await _context.Tasks.FindAsync(id);
            if (task == null) return NotFound();
            return View(task);
        }

        // EDIT POST
        [HttpPost]
        public async Task<IActionResult> Edit(int id, TaskItem model)
        {
            if (id != model.Id)
                return NotFound();

            if (ModelState.IsValid)
            {
                var existingTask = await _context.Tasks.FindAsync(id);

                if (existingTask == null)
                    return NotFound();

                // Only update editable fields
                existingTask.Title = model.Title;
                existingTask.Description = model.Description;
                existingTask.DueDate = model.DueDate;
                existingTask.Status = model.Status;
                existingTask.Remarks = model.Remarks;

                existingTask.LastUpdatedOn = DateTime.Now;
                existingTask.LastUpdatedById = 1;
                existingTask.LastUpdatedByName = "Rahul";

                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(model);
        }
        // DELETE
        public async Task<IActionResult> Delete(int id)
        {
            var task = await _context.Tasks.FindAsync(id);
            if (task != null)
            {
                _context.Tasks.Remove(task);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}