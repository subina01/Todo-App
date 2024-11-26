


using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;

using Microsoft.AspNetCore.Http;

using Microsoft.AspNetCore.Http;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;

using Microsoft.AspNetCore.Http;


using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;

using Microsoft.AspNetCore.Http;

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
                        public async Task<IActionResult> GetTaskById(int id)
                        {
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

[Route("api/todo")]
[ApiController]

    [Route("api/todo")]
    [ApiController]

    [Authorize]


    public class ToDoController : ControllerBase
{


        [Route("api/todo")]
        [ApiController]
        public class ToDoController : ControllerBase
        {


                _services = services;

        }

        [HttpPost]

        Console.WriteLine("The breakpoint has hit here");
        }

[HttpPost]
[Route("")]

public async Task<IActionResult> AddTask([FromBody] ToDo tododata)
{
        if (!ModelState.IsValid)
        {
                return BadRequest();

        }
        await _services.AddTask(tododata);

        return Ok(new
        {
                Message = "Task Added!"
        });
}


private readonly ITodoServices _services;


public ToDoController(ITodoServices services)
{


        _services = services;
        Console.WriteLine("The breakpoint has hit here");

        _services = services;

}


[HttpPost]
[Route("")]
[Authorize(Roles = "Admin,User")]
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

        if (!ModelState.IsValid)
        {
                return BadRequest();

        }
        await _services.AddTask(tododata);
        return Ok
        (new
        {
                Message = "Task Added!"




    _services = services;
        Console.WriteLine("The breakpoint has hit here");
}

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


        }



    [Route("{id}")]
    [Authorize(Roles = "Admin,User")]
            public async Task<IActionResult> GetTaskById(int id)
{
        var GetTask = await _services.GetTaskById(id);
        return Ok(GetTask);

        var GetTask = await _services.GetTaskById(id);
        return Ok(GetTask);

        [Route("{id}")]
        public async Task<IActionResult> GetTaskById(int id)
        {
                var GetTask = await _services.GetTaskById(id);
                return Ok(GetTask);

        }

        [HttpGet]
        [Route("")]

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> GetAllTasks()
        {
                var GetAllTasks = await _services.GetAllTasks();
                return Ok(GetAllTasks);
                var GetAllTasks = await _services.GetAllTasks();
                return Ok(GetAllTasks);

                [HttpPost]
                public async Task<IActionResult> AddTask([FromBody] ToDo tododata)
                {
                        if (!ModelState.IsValid)
                        {
                                return BadRequest();
                        }
                        await _services.AddTask(tododata);

                        return Ok(new
                        {
                                Message = "Task Added!"
                        });
                }

                [HttpGet("{id}")]
                [Authorize(Roles = "Admin,User")]

                return Ok(new { Message = "Task Added!" });
        }

        [HttpGet("{id}")]

        [HttpGet("{id}")]



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

public async Task<IActionResult> GetTaskById(int id)
{
        var GetTask = await _services.GetTaskById(id);
        return Ok(GetTask);
}

public async Task<IActionResult> GetAllTasks()
{
        var GetAllTasks = await _services.GetAllTasks();
        return Ok(GetAllTasks);
}

[HttpPut]
[Route("{id}")]


[Authorize(Roles = "Admin,User")]
public async Task<IActionResult> UpdateTask(int id, [FromBody] UpdateTaskRequestDTO tododata)
{

        if (tododata == null)
        {
                return BadRequest(ModelState);
        }
        var Updatetodo = await _services.UpdateTask(id, tododata);
        return Ok(Updatetodo);
        if (tododata == null)
        {
                return BadRequest(ModelState);
        }
        var Updatetodo = await _services.UpdateTask(id, tododata);
        return Ok(Updatetodo);



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
public async Task<IActionResult> DeleteTask(int id)
{

        var DeleteTasks = await _services.DeleteTask(id);
        return Ok(DeleteTasks);
        var DeleteTasks = await _services.DeleteTask(id);
        return Ok(DeleteTasks);

}

[HttpDelete]
[Route("{id}")]

public async Task<IActionResult> DeleteTask(int id)
{

        var DeleteTasks = await _services.DeleteTask(id);
        return Ok(DeleteTasks);
}

[HttpPut]
[Route("Status/{id}")]

[Authorize(Roles = "Admin,User")]
public async Task<IActionResult> UpdateTaskStatus(int id, [FromBody] UpdateStatusRequestDTO tododata)
{
        if (tododata == null)
        {
                return BadRequest();
        }
        var UpdateStatus = await _services.UpdateTaskStatus(id, tododata);
        return Ok(UpdateStatus);
}

[HttpDelete("{id}")]
public async Task<IActionResult> DeleteTask(int id)
{
        var DeleteTasks = await _services.DeleteTask(id);
        return Ok(DeleteTasks);
}


[HttpPut("Status/{id}")]
[Authorize(Roles = "Admin,User")]

[HttpPut("Status/{id}")]

public async Task<IActionResult> UpdateTaskStatus(int id, [FromBody] UpdateStatusRequestDTO tododata)
{
        if (tododata == null)
        {
                return BadRequest();
        }
        var UpdateStatus = await _services.UpdateTaskStatus(id, tododata);
        return Ok(UpdateStatus);
}

[HttpGet]

[Route("")]

public async Task<IActionResult> GetAllTasks()
{
        var GetAllTasks = await _services.GetAllTasks();
        return Ok(GetAllTasks);
}


[HttpPut("{id}")]
public async Task<IActionResult> UpdateTask(int id, [FromBody] UpdateTaskRequestDTO tododata)
{

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> UpdateTask(int id, [FromBody] UpdateTaskRequestDTO tododata)
        {


                if (tododata == null)
                {
                        return BadRequest(ModelState);
                }
                var Updatetodo = await _services.UpdateTask(id, tododata);
                return Ok(Updatetodo);

        }



        [HttpPut("Status/{id}")]
        [Authorize(Roles = "Admin,User")]


        }

[HttpDelete]
[Route("{id}")]

public async Task<IActionResult> DeleteTask(int id)
{

        var DeleteTasks = await _services.DeleteTask(id);
        return Ok(DeleteTasks);
}

[HttpPut]
[Route("Status/{id}")]

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
