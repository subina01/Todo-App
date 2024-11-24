using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TodoApp.Core.Domain.Entities;
using TodoApp.Core.Domain.Interface;
using TodoApp.Core.DTO;

namespace TodoApp.UI.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoController : ControllerBase
    {
        private readonly ITodoServices _services;

        public ToDoController(ITodoServices services)  
        {
            _services = services;
            Console.WriteLine("The breakpoint has hit here");
        }

        [HttpPost]
        [Route("AddTask")]
        public async Task<IActionResult> AddTask([FromBody] ToDo tododata)
        {
            if (!ModelState.IsValid) {
                return BadRequest();

            }
           await _services.AddTask(tododata);
            return Ok
            (new {
                Message = "Task Added!"
            });

        }

        [HttpGet]
        [Route("GetTaskById/{id}")]
        public async  Task<IActionResult> GetTaskById(int id )
        {
            var GetTask = await _services.GetTaskById(id);
            return Ok(GetTask);
        }

        [HttpGet]
        [Route("GetAllTask")]
        public async Task<IActionResult> GetAllTasks()
        {
            var GetAllTasks = await _services.GetAllTasks();
            return Ok(GetAllTasks);
        }

        [HttpPut]
        [Route("UpdateTask/{id}")]
        public async Task<IActionResult> UpdateTask(int id, [FromBody] TodoResponseDTO tododata) {

            if (tododata == null)
            {
                return BadRequest(ModelState);
            }
            var Updatetodo = await _services.UpdateTask(id, tododata);
            return Ok(Updatetodo);

        }

        [HttpDelete]
        [Route("DeleteTask/{id}")]

        public async  Task<IActionResult> DeleteTask(int id) 
        {

          var DeleteTasks = await _services.DeleteTask(id);
            return Ok(DeleteTasks);
        }

        [HttpPut]
        [Route("UpdateTaskStatus/{id}")]
        public async Task<IActionResult> UpdateTaskStatus( int id, [FromBody] TodoResponseDTO tododata)
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
