<<<<<<< HEAD
<<<<<<< HEAD



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
=======
﻿using Microsoft.AspNetCore.Http;
>>>>>>> d1de45d (refactor(controller): update controller methods to integrate request and response DTOs)
=======
﻿using Microsoft.AspNetCore.Http;
>>>>>>> 7f01e22 (feat(ui): add CRUD APIs with constructor-based dependency injection)
using Microsoft.AspNetCore.Mvc;
using TodoApp.Core.Domain.Entities;
using TodoApp.Core.Domain.Interface;
using TodoApp.Core.DTO;

namespace todo.WebAPI.Controllers
{
<<<<<<< HEAD

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



                [HttpPost]
                [Route("")]

                [HttpPost]
                [Route("")]


                [HttpPost]
                [Route("")]
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
                var GetTask = await _services.GetTaskById(id);
                        return Ok(GetTask);
        }

        [HttpGet]
        [Route("")]




        [Authorize(Roles = "Admin")]
             {
                        var GetAllTasks = await _services.GetAllTasks();
                        return Ok(GetAllTasks);
}

[HttpPut]
[Route("{id}")]




[Authorize(Roles = "Admin,User")]




[Authorize(Roles = "Admin,User")]
{
        if (tododata == null)
        {
                return BadRequest();
        }
        var UpdateStatus = await _services.UpdateTaskStatus(id, tododata);
        return Ok(UpdateStatus);
}
        }

    [Route("api/todo")]
[ApiController]
public class ToDoController : ControllerBase
{
=======
    [Route("api/todo")]
    [ApiController]
    public class ToDoController : ControllerBase
    {
>>>>>>> 7f01e22 (feat(ui): add CRUD APIs with constructor-based dependency injection)
        private readonly ITodoServices _services;

        public ToDoController(ITodoServices services)
        {
<<<<<<< HEAD
                _services = services;
                Console.WriteLine("The breakpoint has hit here");
=======
            _services = services;
            Console.WriteLine("The breakpoint has hit here");
>>>>>>> 7f01e22 (feat(ui): add CRUD APIs with constructor-based dependency injection)
        }

        [HttpPost]
        [Route("")]
        public async Task<IActionResult> AddTask([FromBody] ToDo tododata)
        {
<<<<<<< HEAD
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
=======
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
>>>>>>> 7f01e22 (feat(ui): add CRUD APIs with constructor-based dependency injection)

        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetTaskById(int id)
        {
<<<<<<< HEAD
                var GetTask = await _services.GetTaskById(id);
                return Ok(GetTask);
=======
            var GetTask = await _services.GetTaskById(id);
            return Ok(GetTask);
>>>>>>> 7f01e22 (feat(ui): add CRUD APIs with constructor-based dependency injection)
        }

        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetAllTasks()
        {
<<<<<<< HEAD
                var GetAllTasks = await _services.GetAllTasks();
                return Ok(GetAllTasks);
=======
            var GetAllTasks = await _services.GetAllTasks();
            return Ok(GetAllTasks);
>>>>>>> 7f01e22 (feat(ui): add CRUD APIs with constructor-based dependency injection)
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> UpdateTask(int id, [FromBody] UpdateTaskRequestDTO tododata)
        {

<<<<<<< HEAD
                if (tododata == null)
                {
                        return BadRequest(ModelState);
                }
                var Updatetodo = await _services.UpdateTask(id, tododata);
                return Ok(Updatetodo);
=======
            if (tododata == null)
            {
                return BadRequest(ModelState);
            }
            var Updatetodo = await _services.UpdateTask(id, tododata);
            return Ok(Updatetodo);
>>>>>>> 7f01e22 (feat(ui): add CRUD APIs with constructor-based dependency injection)

        }

        [HttpDelete]
        [Route("{id}")]

        public async Task<IActionResult> DeleteTask(int id)
        {

<<<<<<< HEAD
                var DeleteTasks = await _services.DeleteTask(id);
                return Ok(DeleteTasks);
=======
            var DeleteTasks = await _services.DeleteTask(id);
            return Ok(DeleteTasks);
>>>>>>> 7f01e22 (feat(ui): add CRUD APIs with constructor-based dependency injection)
        }

        [HttpPut]
        [Route("Status/{id}")]
        public async Task<IActionResult> UpdateTaskStatus(int id, [FromBody] UpdateStatusRequestDTO tododata)
        {
<<<<<<< HEAD
                if (tododata == null)
                {
                        return BadRequest();
                }
                var UpdateStatus = await _services.UpdateTaskStatus(id, tododata);
                return Ok(UpdateStatus);
        }
=======
            if (tododata == null)
            {
                return BadRequest();
            }
            var UpdateStatus = await _services.UpdateTaskStatus(id, tododata);
            return Ok(UpdateStatus);
        }
    }
>>>>>>> 7f01e22 (feat(ui): add CRUD APIs with constructor-based dependency injection)
}
