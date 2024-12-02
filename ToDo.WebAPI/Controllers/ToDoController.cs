


using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
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

        public class ToDoController : ControllerBase
        {
                private readonly ITodoServices _services;

                public ToDoController(ITodoServices services)
                {
                        _services = services;
                        Console.WriteLine("The breakpoint has hit here");
                }





                [HttpPost]
                [Route("")]

                [Authorize(Roles = "Admin,User")]


=======
        [HttpPost]
        [Route("")]
>>>>>>> 3cfe03a (refactor(controller): update controller methods to integrate request and response DTOs)
=======
        [HttpPost]
        [Route("")]
>>>>>>> 87b39c6 (feat(ui): add CRUD APIs with constructor-based dependency injection)
=======
       
        
        [HttpPost]
        [Route("")]
        [Authorize(Roles = "Admin,User")]
>>>>>>> 86a57ab (feat(auth): Add jwt based authentication)
=======
        [Authorize]
>>>>>>> 6af2c4c (feat(auth): implement authentication and authorization using jwt)
                public async Task<IActionResult> AddTask([FromBody] ToDo tododata)
                {
                        if (!ModelState.IsValid)
                        {
                                return BadRequest();

                        }
                        await _services.AddTask(tododata);
                        return Ok
                        (new
                        {
                                Message = "Task Added!"
                        });

                }

                [HttpGet]




                [Route("{id}")]

                [Authorize(Roles = "Admin,User")]
=======
        [Route("{id}")]
>>>>>>> 3cfe03a (refactor(controller): update controller methods to integrate request and response DTOs)
=======
        [Route("{id}")]
>>>>>>> 87b39c6 (feat(ui): add CRUD APIs with constructor-based dependency injection)
=======
       
        [Route("{id}")]
        [Authorize(Roles = "Admin,User")]
>>>>>>> 86a57ab (feat(auth): Add jwt based authentication)
=======
        [Authorize]
>>>>>>> 6af2c4c (feat(auth): implement authentication and authorization using jwt)
                public async Task<IActionResult> GetTaskById(int id)
                {
                        var GetTask = await _services.GetTaskById(id);
                        return Ok(GetTask);
                }

                [HttpGet]
                [Route("")]




                [Authorize(Roles = "Admin")]
=======
>>>>>>> 3cfe03a (refactor(controller): update controller methods to integrate request and response DTOs)
=======
>>>>>>> 87b39c6 (feat(ui): add CRUD APIs with constructor-based dependency injection)
=======
        [Authorize(Roles = "Admin")]
>>>>>>> 86a57ab (feat(auth): Add jwt based authentication)
=======
        [Authorize]
>>>>>>> 6af2c4c (feat(auth): implement authentication and authorization using jwt)
                public async Task<IActionResult> GetAllTasks()
                {
                        var GetAllTasks = await _services.GetAllTasks();
                        return Ok(GetAllTasks);
                }

                [HttpPut]
                [Route("{id}")]




                [Authorize(Roles = "Admin,User")]
=======
>>>>>>> 3cfe03a (refactor(controller): update controller methods to integrate request and response DTOs)
=======
>>>>>>> 87b39c6 (feat(ui): add CRUD APIs with constructor-based dependency injection)
=======
        [Authorize(Roles = "Admin,User")]
>>>>>>> 86a57ab (feat(auth): Add jwt based authentication)
=======
        [Authorize]
>>>>>>> 6af2c4c (feat(auth): implement authentication and authorization using jwt)
                public async Task<IActionResult> UpdateTask(int id, [FromBody] UpdateTaskRequestDTO tododata)
                {

                        if (tododata == null)
                        {
                                return BadRequest(ModelState);
                        }
                        var Updatetodo = await _services.UpdateTask(id, tododata);
                        return Ok(Updatetodo);

                }

                [HttpDelete]
                [Route("{id}")]




                [Authorize(Roles = "Admin,User")]


=======
>>>>>>> 3cfe03a (refactor(controller): update controller methods to integrate request and response DTOs)
=======
>>>>>>> 87b39c6 (feat(ui): add CRUD APIs with constructor-based dependency injection)
=======
        [Authorize(Roles = "Admin,User")]
>>>>>>> 86a57ab (feat(auth): Add jwt based authentication)
=======
        [Authorize]
>>>>>>> 6af2c4c (feat(auth): implement authentication and authorization using jwt)
                public async Task<IActionResult> DeleteTask(int id)
                {

                        var DeleteTasks = await _services.DeleteTask(id);
                        return Ok(DeleteTasks);
                }

                [HttpPut]
                [Route("Status/{id}")]




                [Authorize(Roles = "Admin,User")]
=======
>>>>>>> 3cfe03a (refactor(controller): update controller methods to integrate request and response DTOs)
=======
>>>>>>> 87b39c6 (feat(ui): add CRUD APIs with constructor-based dependency injection)
=======
        [Authorize(Roles = "Admin,User")]
>>>>>>> 86a57ab (feat(auth): Add jwt based authentication)
=======
        [Authorize]
>>>>>>> 6af2c4c (feat(auth): implement authentication and authorization using jwt)
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
