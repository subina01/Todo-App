using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using TodoApp.Core.Domain.Interface;
using TodoApp.Core.DTO;
using TodoApp.Core.Domain.Entities;
using Microsoft.AspNetCore.Http.HttpResults;



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
        public async Task<IActionResult> AddTask([FromBody] TodoRequestDTO TodoData)
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
            try
            {
                var GetTask = await _services.GetTaskById(id);
                return Ok(GetTask);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetAllTasks()
        { try
            {
                var GetAllTasks = await _services.GetAllTask();
                return Ok(GetAllTasks);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateTask(int id, [FromBody] UpdateTaskRequestDTO TodoData)
        {
            try
            {
                var UpdateTodo = await _services.UpdateTask(id, TodoData);
                return Ok(UpdateTodo);
            }
            catch (Exception ex)
            { 
                return BadRequest(ex.Message); 
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTask(int id)
        {
            try
            {
                var DeleteTasks = await _services.DeleteTask(id);
                return Ok(DeleteTasks);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
