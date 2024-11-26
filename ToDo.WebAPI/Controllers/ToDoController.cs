
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

            }
            await _services.AddTask(tododata);
return Ok
(new
{
        Message = "Task Added!"
});
>>>>>>> bba28cd(refactor(controller): update controller methods to integrate request and response DTOs)

        }

        [HttpGet]


[Route("{id}")]
[Authorize(Roles = "Admin,User")]
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

[HttpPut]
[Route("{id}")]
[Authorize(Roles = "Admin,User")]
public async Task<IActionResult> UpdateTask(int id, [FromBody] UpdateTaskRequestDTO tododata)
{
        return BadRequest(ModelState);
}
var Updatetodo = await _services.UpdateTask(id, tododata);
return Ok(Updatetodo);

[HttpDelete("{id}")]
public async Task<IActionResult> DeleteTask(int id)
{
        var DeleteTasks = await _services.DeleteTask(id);
        return Ok(DeleteTasks);
}
[HttpPut("Status/{id}")]
[HttpPut("Status/{id}")]

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
        [HttpPut]
        [Route("{id}")]
        [Authorize(Roles = "Admin,User")]
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
public async Task<IActionResult> DeleteTask(int id)
{

        var DeleteTasks = await _services.DeleteTask(id);
        return Ok(DeleteTasks);
}

[HttpPut]

tododata)
       [Route("Status/{id}")]

[Authorize(Roles = "Admin,User")]
{
        if (tododata == null)
        {
                return BadRequest();
        }
        var UpdateStatus = await _services.UpdateTaskStatus(id, tododata);
        return Ok(UpdateStatus);
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


[Authorize(Roles = "Admin,User")]


        }

        [HttpDelete]
[Route("{id}")]
[Authorize(Roles = "Admin,User")]

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
