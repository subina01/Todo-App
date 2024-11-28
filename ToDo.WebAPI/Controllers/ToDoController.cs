<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
=======
﻿using Microsoft.AspNetCore.Http;
>>>>>>> d1de45d (refactor(controller): update controller methods to integrate request and response DTOs)
=======
﻿using Microsoft.AspNetCore.Http;
>>>>>>> 7f01e22 (feat(ui): add CRUD APIs with constructor-based dependency injection)
=======
﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
>>>>>>> 5783ca4 (feat(auth): Add jwt based authentication)
=======
﻿using Microsoft.AspNetCore.Http;
>>>>>>> 3cfe03a (refactor(controller): update controller methods to integrate request and response DTOs)
=======
﻿using Microsoft.AspNetCore.Http;
>>>>>>> 87b39c6 (feat(ui): add CRUD APIs with constructor-based dependency injection)
=======
﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
>>>>>>> 86a57ab (feat(auth): Add jwt based authentication)
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
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
        }

        [HttpPost]
=======
=======
>>>>>>> 7f01e22 (feat(ui): add CRUD APIs with constructor-based dependency injection)
            Console.WriteLine("The breakpoint has hit here");
        }
       
        
        [HttpPost]
        [Route("")]
<<<<<<< HEAD
<<<<<<< HEAD
>>>>>>> d1de45d (refactor(controller): update controller methods to integrate request and response DTOs)
=======
>>>>>>> 7f01e22 (feat(ui): add CRUD APIs with constructor-based dependency injection)
=======
        [Authorize(Roles = "Admin,User")]
>>>>>>> 5783ca4 (feat(auth): Add jwt based authentication)
=======
=======
>>>>>>> 87b39c6 (feat(ui): add CRUD APIs with constructor-based dependency injection)
            Console.WriteLine("The breakpoint has hit here");
        }
       
        
        [HttpPost]
        [Route("")]
<<<<<<< HEAD
<<<<<<< HEAD
>>>>>>> 3cfe03a (refactor(controller): update controller methods to integrate request and response DTOs)
=======
>>>>>>> 87b39c6 (feat(ui): add CRUD APIs with constructor-based dependency injection)
=======
        [Authorize(Roles = "Admin,User")]
>>>>>>> 86a57ab (feat(auth): Add jwt based authentication)
        public async Task<IActionResult> AddTask([FromBody] ToDo tododata)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
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
<<<<<<< HEAD
>>>>>>> 78b8029 (refactor: updated sln file with updatedfeatures)
=======
=======
=======
>>>>>>> 7f01e22 (feat(ui): add CRUD APIs with constructor-based dependency injection)
=======
>>>>>>> 3cfe03a (refactor(controller): update controller methods to integrate request and response DTOs)
=======
>>>>>>> 87b39c6 (feat(ui): add CRUD APIs with constructor-based dependency injection)

            }
            await _services.AddTask(tododata);
            return Ok
            (new
            {
                Message = "Task Added!"
            });

        }

        [HttpGet]
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
       
        [Route("{id}")]
<<<<<<< HEAD
<<<<<<< HEAD
>>>>>>> d1de45d (refactor(controller): update controller methods to integrate request and response DTOs)
<<<<<<< HEAD
>>>>>>> 3702509 (refactor(controller): update controller methods to integrate request and response DTOs)
=======
=======
>>>>>>> 7f01e22 (feat(ui): add CRUD APIs with constructor-based dependency injection)
<<<<<<< HEAD
>>>>>>> d45a2c9 (feat(ui): add CRUD APIs with constructor-based dependency injection)
=======
=======
        [Authorize(Roles = "Admin,User")]
>>>>>>> 5783ca4 (feat(auth): Add jwt based authentication)
<<<<<<< HEAD
>>>>>>> 0ac0018 (feat(auth): Add jwt based authentication)
=======
=======
        [Route("{id}")]
>>>>>>> 3cfe03a (refactor(controller): update controller methods to integrate request and response DTOs)
<<<<<<< HEAD
>>>>>>> 9daf4e7 (refactor(controller): update controller methods to integrate request and response DTOs)
=======
=======
        [Route("{id}")]
>>>>>>> 87b39c6 (feat(ui): add CRUD APIs with constructor-based dependency injection)
<<<<<<< HEAD
>>>>>>> f6af1a7 (feat(ui): add CRUD APIs with constructor-based dependency injection)
=======
=======
       
        [Route("{id}")]
        [Authorize(Roles = "Admin,User")]
>>>>>>> 86a57ab (feat(auth): Add jwt based authentication)
>>>>>>> 42f30ab (feat(auth): Add jwt based authentication)
        public async Task<IActionResult> GetTaskById(int id)
        {
            var GetTask = await _services.GetTaskById(id);
            return Ok(GetTask);
        }

        [HttpGet]
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
        [Route("")]
<<<<<<< HEAD
<<<<<<< HEAD
>>>>>>> d1de45d (refactor(controller): update controller methods to integrate request and response DTOs)
=======
        [Route("")]
>>>>>>> 7f01e22 (feat(ui): add CRUD APIs with constructor-based dependency injection)
=======
        [Authorize(Roles = "Admin")]
>>>>>>> 5783ca4 (feat(auth): Add jwt based authentication)
=======
        [Route("")]
>>>>>>> 3cfe03a (refactor(controller): update controller methods to integrate request and response DTOs)
=======
        [Route("")]
>>>>>>> 87b39c6 (feat(ui): add CRUD APIs with constructor-based dependency injection)
=======
        [Authorize(Roles = "Admin")]
>>>>>>> 86a57ab (feat(auth): Add jwt based authentication)
        public async Task<IActionResult> GetAllTasks()
        {
            var GetAllTasks = await _services.GetAllTasks();
            return Ok(GetAllTasks);
        }

<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateTask(int id, [FromBody] UpdateTaskRequestDTO tododata)
        {
=======
=======
>>>>>>> 7f01e22 (feat(ui): add CRUD APIs with constructor-based dependency injection)
        [HttpPut]
        [Route("{id}")]
        [Authorize(Roles = "Admin,User")]
        public async Task<IActionResult> UpdateTask(int id, [FromBody] UpdateTaskRequestDTO tododata)
        {

<<<<<<< HEAD
>>>>>>> d1de45d (refactor(controller): update controller methods to integrate request and response DTOs)
=======
>>>>>>> 7f01e22 (feat(ui): add CRUD APIs with constructor-based dependency injection)
=======
=======
>>>>>>> 87b39c6 (feat(ui): add CRUD APIs with constructor-based dependency injection)
        [HttpPut]
        [Route("{id}")]
        [Authorize(Roles = "Admin,User")]
        public async Task<IActionResult> UpdateTask(int id, [FromBody] UpdateTaskRequestDTO tododata)
        {

<<<<<<< HEAD
>>>>>>> 3cfe03a (refactor(controller): update controller methods to integrate request and response DTOs)
=======
>>>>>>> 87b39c6 (feat(ui): add CRUD APIs with constructor-based dependency injection)
            if (tododata == null)
            {
                return BadRequest(ModelState);
            }
            var Updatetodo = await _services.UpdateTask(id, tododata);
            return Ok(Updatetodo);
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTask(int id)
        {
            var DeleteTasks = await _services.DeleteTask(id);
            return Ok(DeleteTasks);
        }
<<<<<<< HEAD

        [HttpPut("Status/{id}")]
<<<<<<< HEAD
        [Authorize(Roles = "Admin,User")]
=======
        [HttpPut("Status/{id}")]
>>>>>>> 78b8029 (refactor: updated sln file with updatedfeatures)
=======
=======
=======
>>>>>>> 7f01e22 (feat(ui): add CRUD APIs with constructor-based dependency injection)
=======
>>>>>>> 3cfe03a (refactor(controller): update controller methods to integrate request and response DTOs)
=======
>>>>>>> 87b39c6 (feat(ui): add CRUD APIs with constructor-based dependency injection)

        }

        [HttpDelete]
        [Route("{id}")]
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
        [Authorize(Roles = "Admin,User")]
=======

>>>>>>> 3cfe03a (refactor(controller): update controller methods to integrate request and response DTOs)
=======

>>>>>>> 87b39c6 (feat(ui): add CRUD APIs with constructor-based dependency injection)
=======
        [Authorize(Roles = "Admin,User")]
>>>>>>> 86a57ab (feat(auth): Add jwt based authentication)
        public async Task<IActionResult> DeleteTask(int id)
        {

            var DeleteTasks = await _services.DeleteTask(id);
            return Ok(DeleteTasks);
        }

        [HttpPut]
        [Route("Status/{id}")]
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
>>>>>>> d1de45d (refactor(controller): update controller methods to integrate request and response DTOs)
<<<<<<< HEAD
>>>>>>> 3702509 (refactor(controller): update controller methods to integrate request and response DTOs)
=======
=======
>>>>>>> 7f01e22 (feat(ui): add CRUD APIs with constructor-based dependency injection)
<<<<<<< HEAD
>>>>>>> d45a2c9 (feat(ui): add CRUD APIs with constructor-based dependency injection)
=======
=======
        [Authorize(Roles = "Admin,User")]
>>>>>>> 5783ca4 (feat(auth): Add jwt based authentication)
<<<<<<< HEAD
>>>>>>> 0ac0018 (feat(auth): Add jwt based authentication)
=======
=======
>>>>>>> 3cfe03a (refactor(controller): update controller methods to integrate request and response DTOs)
<<<<<<< HEAD
>>>>>>> 9daf4e7 (refactor(controller): update controller methods to integrate request and response DTOs)
=======
=======
>>>>>>> 87b39c6 (feat(ui): add CRUD APIs with constructor-based dependency injection)
<<<<<<< HEAD
>>>>>>> f6af1a7 (feat(ui): add CRUD APIs with constructor-based dependency injection)
=======
=======
        [Authorize(Roles = "Admin,User")]
>>>>>>> 86a57ab (feat(auth): Add jwt based authentication)
>>>>>>> 42f30ab (feat(auth): Add jwt based authentication)
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
