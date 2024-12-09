using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using TodoApp.Core.Domain.Interface;
using TodoApp.Core.DTO;
using TodoApp.Core.Domain.Entities;
using Microsoft.AspNetCore.Http.HttpResults;
using System.Net;



namespace Todo.WebApi.Controllers
{

    [Route("api/todo")]
    [ApiController]
    [Authorize]
    public class ToDoController : ControllerBase
    {
        private readonly ITodoServices _services;
        /// <summary>
        /// Sets up the controller with the necessary task service.
        /// </summary>
        /// <param name="services">The service used to manage tasks.</param>
        public ToDoController(ITodoServices services)
        {
            _services = services;
        }
        // <summary>
        /// Adds a new task.
        /// </summary>
        /// <param name="TodoData">The details of the task to be added.</param>
        /// <returns>A success message if the task is added or an error message if something goes wrong.</returns>
        [HttpPost]
        public async Task<IActionResult> AddTask([FromBody] TodoRequestDTO TodoData)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest((new
                {
                    error = new
                    {
                        key = HttpStatusCode.BadRequest,
                        message = "The model is invalid"
                    }
                }));
            }
            await _services.AddTask(TodoData);
            return Ok(new
            {

                Message = "Task Added!"
            });
        }
        /// <summary>
        /// Gets the details of a specific task by its ID.
        /// </summary>
        /// <param name="id">The id of the task.</param>
        /// <returns>The task details if found, otherwise an error message.</returns>
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
                return NotFound(new
                {
                    error = new
                    {
                        key = HttpStatusCode.NotFound,
                        message = ex.Message
                    }
                });
            }
        }
        /// <summary>
        /// Gets a list of all tasks.
        /// </summary>
        /// <returns>A list of tasks or an error message if task not found.</returns>
        [HttpGet]
        public async Task<IActionResult> GetAllTasks()
        {
            try
            {
                var GetAllTasks = await _services.GetAllTask();
                return Ok(GetAllTasks);
            }
            catch (Exception ex)
            {
                return NotFound(new
                {
                    error = new
                    {
                        key = HttpStatusCode.NotFound,
                        message = ex.Message
                    }
                });
            }
        }
        /// <summary>
        /// Updates an existing task by its ID.
        /// </summary>
        /// <param name="id">The id of the task to update.</param>
        /// <param name="TodoData">The updated task details.</param>
        /// <returns>The updated task details or an error message if the task not found.</returns>
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
                return NotFound(new
                {
                    error = new
                    {
                        key = HttpStatusCode.NotFound,
                        message = ex.Message
                    }
                });
            }
        }
        /// <summary>
        /// Deletes a task by its ID.
        /// </summary>
        /// <param name="id">The id of the task to delete.</param>
        /// <returns>A success message if the task is deleted or an error message if task not found.</returns>
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
                return NotFound(new
                {
                    error = new
                    {
                        key = HttpStatusCode.NotFound,
                        message = ex.Message
                    }
                });
            }
        }

    }
}
