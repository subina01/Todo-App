using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TodoApp.Core.Domain.Entities;
using TodoApp.Core.Domain.Interface;
using TodoApp.Core.DTO;

namespace todo.WebAPI.Controllers
{
    [Route("api/todo")]
    [ApiController]
<<<<<<< HEAD
    [Authorize]
=======
>>>>>>> 78b8029 (refactor: updated sln file with updatedfeatures)
    public class ToDoController : ControllerBase
    {
        private readonly ITodoServices _services;

        public ToDoController(ITodoServices services)
        {
            _services = services;
        }

        [HttpPost]
        public async Task<IActionResult> AddTask([FromBody] ToDo tododata)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            await _services.AddTask(tododata);
<<<<<<< HEAD
            return Ok(new
            {
                Message = "Task Added!"
            });
        }

        [HttpGet("{id}")]
        [Authorize(Roles = "Admin,User")]
=======
            return Ok(new { Message = "Task Added!" });
        }

        [HttpGet("{id}")]
>>>>>>> 78b8029 (refactor: updated sln file with updatedfeatures)
        public async Task<IActionResult> GetTaskById(int id)
        {
            var GetTask = await _services.GetTaskById(id);
            return Ok(GetTask);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllTasks()
        {
            var GetAllTasks = await _services.GetAllTasks();
            return Ok(GetAllTasks);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateTask(int id, [FromBody] UpdateTaskRequestDTO tododata)
        {
            if (tododata == null)
            {
                return BadRequest(ModelState);
            }
            var Updatetodo = await _services.UpdateTask(id, tododata);
            return Ok(Updatetodo);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTask(int id)
        {
            var DeleteTasks = await _services.DeleteTask(id);
            return Ok(DeleteTasks);
        }
<<<<<<< HEAD

        [HttpPut("Status/{id}")]
        [Authorize(Roles = "Admin,User")]
=======
        [HttpPut("Status/{id}")]
>>>>>>> 78b8029 (refactor: updated sln file with updatedfeatures)
        public async Task<IActionResult> UpdateTaskStatus(int id, [FromBody] UpdateStatusRequestDTO tododata)
        {
            if (tododata == null)
            {
                return BadRequest();
            }
            var UpdateStatus = await _services.UpdateTaskStatus(id, tododata);
            return Ok(UpdateStatus);
        }
    }
}
