using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using TodoApp.Core.Domain.Interface;
using TodoApp.Core.DTO;
using TodoApp.Core.Domain.Entities;



namespace Todo.WebApi.Controllers
{

    [Route("api/todo")]
    [ApiController]
    [Authorize]
    public class ToDoController : ControllerBase
    {
        private readonly ITodoServices _services;

        public ToDoController(ITodoServices services)
        {
            _services = services;
        }

        [HttpPost]
        public async Task<IActionResult> AddTask([FromBody] ToDo TodoData)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            await _services.AddTask(TodoData);
            return Ok(new
            {
                Message = "Task Added!"
            });
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetTaskById(int id)
        {
            var GetTask = await _services.GetTaskById(id);
            return Ok(GetTask);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllTasks()
        {
            var GetAllTasks = await _services.GetAllTask();
            return Ok(GetAllTasks);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateTask(int id, [FromBody] UpdateTaskRequestDTO TodoData)
        {
            if (TodoData == null)
            {
                return BadRequest(ModelState);
            }
            var UpdateTodo = await _services.UpdateTask(id, TodoData);
            return Ok(UpdateTodo);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTask(int id)
        {
            var DeleteTasks = await _services.DeleteTask(id);
            return Ok(DeleteTasks);
        }

    }
}

