using Microsoft.AspNetCore.Mvc;
using TaskScheduling.Models;
using TaskScheduling.Services;

namespace TaskScheduling.Controllers
{
    [ApiController]
    [Route("api/tasks")]
    public class TasksController : ControllerBase
    {
        public TasksService tasksService { get; set; }

        public TasksController(TasksService tasksService)
        {
            this.tasksService = tasksService;
        }

        [HttpPost]
        public IActionResult Post([FromBody] List<Tasks> tasks)
        {
            try
            {
                for (int i = 0; i < tasks.Count; i++)
                {
                    this.tasksService.taskQueue.Enqueue(tasks[i]);
                }
                return Ok("Process succesfull!");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public IActionResult Get() {
            try
            {
                List<Tasks> list = new List<Tasks>();
                var count = this.tasksService.taskQueue.Count;

                for (int i = count; i > 0; i--)
                {
                    list.Add(this.tasksService.taskQueue.Dequeue());
                }

                return Ok(list);
            }
            catch (Exception ex)
            {
                return NoContent();
            }
        }
    }
}