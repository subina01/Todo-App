using Azure.Messaging;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using Todo.Infrastructure.Database;
using TodoApp.Core.Domain.Entities;
using TodoApp.Core.Domain.Interface;
using TodoApp.Core.DTO;

namespace Todo.Infrastructure.Services
{
    public class TodoServices : ITodoServices
    {
        private readonly ApplicationDbContext _context;

        public TodoServices(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddTask(ToDo tododata)
        {
            await _context.AddAsync(tododata);
            await _context.SaveChangesAsync();


        }

        public async Task<string> DeleteTask(int id)
        {
            var taskToDelete = _context.TodoData.FirstOrDefault(x => x.Id == id);

            if (taskToDelete == null)
            {
                throw new Exception("No Task Found");
            }

            _context.TodoData.Remove(taskToDelete);
            await _context.SaveChangesAsync();

            return "This task has been deleted";

        }
        public async Task<TodoResponseDTO> GetTaskById(int id)
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

            return new TodoResponseDTO
            {
                Id = task.Id,
                UserName = task.UserName,
                TaskType = task.TaskType,
                Description = task.Description,
                StartDate = task.StartDate,
                DueDate = task.DueDate,
                CompletionDate = task.CompletionDate,
                Status = task.Status
            };
        }
        public async Task<IEnumerable<TodoResponseDTO>> GetAllTasks()
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


            return tasks;

        }



        public async Task<string> UpdateTask(int id, TodoResponseDTO updateTodoDATA)
        {
            var taskUpdate = _context.TodoData.FirstOrDefault(x => x.Id == id);

            if (taskUpdate == null) {

                throw new Exception("NO TASK  UPDATE FOUND");
                
            }


            taskUpdate.UserName = updateTodoDATA.UserName;
            taskUpdate.TaskType = updateTodoDATA.TaskType;
            taskUpdate.Description = updateTodoDATA.Description;
            taskUpdate.StartDate = updateTodoDATA.StartDate;
            taskUpdate.DueDate = updateTodoDATA.DueDate;
            taskUpdate.CompletionDate = updateTodoDATA.CompletionDate;

            await _context.SaveChangesAsync();

            return "Your Task Has Been Updated";
        }

        public async Task<string> UpdateTaskStatus(int id, TodoResponseDTO newstatus)
        {
            var UpdatetheStatus = _context.TodoData.FirstOrDefault(x => x.Id == id);

            if (UpdatetheStatus == null)
            {

                throw new Exception("NO STATUS  UPDATE FOUND");
            }
            if (newstatus.Status.ToLower() == "review") {
                UpdatetheStatus.Status = "Review";
            }
            else if(newstatus.Status.ToLower() == "completed")
            {
                UpdatetheStatus.Status = "Completed";
            }
            else  if(newstatus.Status.ToLower() == "progress")
            {
                UpdatetheStatus.Status = "Progress";

            }
            else
            {
                UpdatetheStatus.Status = "Start";
            }
            await _context.SaveChangesAsync();

            return "Your status has been Updated";
        }
    }
}
