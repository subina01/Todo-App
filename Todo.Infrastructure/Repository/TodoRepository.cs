using Microsoft.EntityFrameworkCore;
using Todo.Infrastructure.Database;
using TodoApp.Core.Domain.Entities;
using TodoApp.Core.Domain.Interface;
using TodoApp.Core.DTO;

namespace Todo.Infrastructure.Services
{
    public class TodoRepository : ITodoServices
    {
        private readonly ApplicationDbContext _context;

        public TodoRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddTask(ToDo tododata)
        {
            await _context.AddAsync(tododata);
            await _context.SaveChangesAsync();


        }

        public async Task<DeleteTaskResponseDTO> DeleteTask(int id)
        {
            var taskToDelete = _context.TodoData.FirstOrDefault(x => x.Id == id);

            if (taskToDelete == null)
            {
                return new DeleteTaskResponseDTO
                {
                 Message = "No Task Found with the given Id."
                };
            }

            _context.TodoData.Remove(taskToDelete);
            await _context.SaveChangesAsync();

            return new DeleteTaskResponseDTO
            {
                Message = "The task has been successfully deleted."
            };

        }
        public async Task<GetAllTaskByIdResponseDTO> GetTaskById(int id)
        {
            var task = await _context.TodoData
                .Where(x => x.Id == id)
                .Select(task => new TodoResponseDTO
                {
                   Id = task.Id, 
                    UserName = task.UserName,
                    TaskType = task.TaskType,
                    Description = task.Description,
                    StartDate = task.StartDate,
                    DueDate = task.DueDate,
                    CompletionDate = task.CompletionDate,
                    Status = task.Status
                }).FirstOrDefaultAsync();

            return new GetAllTaskByIdResponseDTO
            {
              
                Task = task,
            };
        }
        public async Task<IEnumerable<GetAllTasksResponseDTO>> GetAllTasks()
        {
            var tasks = await _context.TodoData
           .Select(task => new TodoResponseDTO
           {
               Id = task.Id,
               UserName = task.UserName,
               TaskType = task.TaskType,
               Description = task.Description,
               StartDate = task.StartDate,
               DueDate = task.DueDate,
               CompletionDate = task.CompletionDate,
               Status = task.Status
           }).ToListAsync();


            var response = new GetAllTasksResponseDTO
            {
                Tasks = tasks,
                TotalTask = tasks.Count
            };

            return new List<GetAllTasksResponseDTO> { response };

        }



        public async Task<UpdateTaskResponseDTO> UpdateTask(int id, UpdateTaskRequestDTO updateTodoData)
        {
            var taskUpdate = _context.TodoData.FirstOrDefault(x => x.Id == id);

            if (taskUpdate == null) {

                throw new Exception("NO TASK  UPDATE FOUND");
                
            }
            if (updateTodoData.UserName != null)
                taskUpdate.UserName = updateTodoData.UserName;
            if (updateTodoData.TaskType != null)
                taskUpdate.TaskType = updateTodoData.TaskType;
            if (updateTodoData.Description != null)
                taskUpdate.Description = updateTodoData.Description;
            if (updateTodoData.StartDate.HasValue)
                taskUpdate.StartDate = updateTodoData.StartDate.Value;
            if (updateTodoData.DueDate.HasValue)
                taskUpdate.DueDate = updateTodoData.DueDate.Value;
            if (updateTodoData.CompletionDate.HasValue)
                taskUpdate.CompletionDate = updateTodoData.CompletionDate.Value;
            if (updateTodoData.UserName != null)
                taskUpdate.Status = updateTodoData.UserName;

            await _context.SaveChangesAsync();

            return new UpdateTaskResponseDTO
            {
                Message = "Your Task Has Been Updated",
                UserName = taskUpdate.UserName,
                TaskType = taskUpdate.TaskType,
                Description = taskUpdate.Description,
                StartDate = taskUpdate.StartDate,
                DueDate = taskUpdate.DueDate,
                CompletionDate = taskUpdate.CompletionDate
            };
        }

        public async Task<UpdateStatusResponseDTO> UpdateTaskStatus(int id, UpdateStatusRequestDTO newstatus)
        {
            var UpdatetheStatus = _context.TodoData.FirstOrDefault(x => x.Id == id);

            if (UpdatetheStatus == null)
            {

                throw new Exception("NO STATUS  UPDATE FOUND");
            }
            if (newstatus.Status.ToLower() == "review") {
                newstatus.Status = "Review";
            }
            else if(newstatus.Status.ToLower() == "completed")
            {
                newstatus.Status = "Completed";
            }
            else  if(newstatus.Status.ToLower() == "progress")
            {
                newstatus.Status = "Progress";

            }
            else
            {
                newstatus.Status = "Start";
            }
            UpdatetheStatus.Status = newstatus.Status;
            await _context.SaveChangesAsync();

            return new UpdateStatusResponseDTO
            {
                Message = "Your Status Has Been Updated",
                UpdatedStatus = UpdatetheStatus.Status
            };
        }
    }
}
