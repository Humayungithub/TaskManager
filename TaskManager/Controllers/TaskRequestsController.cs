using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TaskManager.DTO.TaskRequestsDto;
using TaskManager.Models;
using TaskManager.Repositories;

namespace TaskManager.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskRequestsController : ControllerBase
    {
        private readonly MainDbContext _context;
        private readonly IMapper mapper;

        public TaskRequestsController(MainDbContext context, IMapper mapper)
        {
            _context = context;
            this.mapper = mapper;
        }

        // GET: api/TaskRequests
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TaskRequestsReadOnlyDto>>> GetTasks()
        {
            var tasks = await _context.Tasks.ToListAsync();
            var tasksDto = mapper.Map <IEnumerable<TaskRequestsReadOnlyDto>>(tasks);
            return Ok(tasksDto);
        }

        // GET: api/TaskRequests/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TaskRequests>> GetTaskRequests(int id)
        {
            var taskRequests = await _context.Tasks.FindAsync(id);

            if (taskRequests == null)
            {
                return NotFound();
            }

            return taskRequests;
        }

        // PUT: api/TaskRequests/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTaskRequests(int id, TaskRequests taskRequests)
        {
            if (id != taskRequests.TaskId)
            {
                return BadRequest();
            }

            _context.Entry(taskRequests).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TaskRequestsExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/TaskRequests
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CreateTaskRequestsDto>> PostTaskRequests(CreateTaskRequestsDto taskRequestsDto)
        {
            var taskRequests = mapper.Map<TaskRequests>(taskRequestsDto);
            await _context.Tasks.AddAsync(taskRequests);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTaskRequests", new { id = taskRequests.TaskId }, taskRequests);
        }

        // DELETE: api/TaskRequests/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTaskRequests(int id)
        {
            var taskRequests = await _context.Tasks.FindAsync(id);
            if (taskRequests == null)
            {
                return NotFound();
            }

            _context.Tasks.Remove(taskRequests);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TaskRequestsExists(int id)
        {
            return _context.Tasks.Any(e => e.TaskId == id);
        }
    }
}
