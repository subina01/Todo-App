using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using TodoApp.Core.Domain.Entities;
using TodoApp.Core.Domain.Interface;
using TodoApp.Core.DTO;
using TodoApp.Infrastructure.Database;

namespace TodoApp.Infrastructure.Repository
{
    public class TodoRepository : ITodoServices
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public TodoRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        public async Task AddTask(TodoRequestDTO TodoData)
        {
            var TodoInput = _mapper.Map<ToDo>(TodoData);
            await _context.AddAsync(TodoInput);
            await _context.SaveChangesAsync();
        }

        public async Task<DeleteTaskResponseDTO> DeleteTask(int id)
        {

            var TaskToDelete = await _context.TodoData.FirstOrDefaultAsync(x => x.Id == id);

            if (TaskToDelete == null)
            {

                throw new Exception("An unexpected error occurred while deleting the task.");
            }

            _context.TodoData.Remove(TaskToDelete);
            await _context.SaveChangesAsync();

            return new DeleteTaskResponseDTO
            {
                Message = "The task has been successfully deleted."

            };      
            }

        public async Task<GetAllTaskByIdResponseDTO> GetTaskById(int id)
        {
           
                var TaskById = await _context.TodoData
                    .Where(x => x.Id == id)
                    .Select(task => new TodoResponseDTO
                    {
                        Id = task.Id,
                        TaskAssignedTo = task.TaskAssignedTo,
                        TaskType = task.TaskType,
                        Description = task.Description,
                        StartDate = task.StartDate,
                        DueDate = task.DueDate,
                        CompletionDate = task.CompletionDate,
                        Status = task.Status
                    }).FirstOrDefaultAsync();

                if (TaskById == null)
                {

                throw new Exception("An unexpected error occurred while fetching the task.");
                 }

                return new GetAllTaskByIdResponseDTO
                {
                    Task = TaskById,
                };
            
        }

        public async Task<GetAllTasksResponseDTO> GetAllTask()
        {
          
                var TaskList = await _context.TodoData
                    .Select(task => new TodoResponseDTO
                    {
                        Id = task.Id,
                        TaskAssignedTo = task.TaskAssignedTo,
                        TaskType = task.TaskType,
                        Description = task.Description,
                        StartDate = task.StartDate,
                        DueDate = task.DueDate,
                        CompletionDate = task.CompletionDate,
                        Status = task.Status
                    }).ToListAsync();
                if (TaskList == null)
                {

                    throw new Exception("An unexpected error occurred while fetching all tasks.");
                }
                return new GetAllTasksResponseDTO
                {
                    Tasks = TaskList,
                    TotalTask = TaskList.Count(),
                };
            
        }

        public async Task<UpdateTaskResponseDTO> UpdateTask(int id, UpdateTaskRequestDTO updateTodoData)
        {
          
                var TaskToUpdate = await _context.TodoData.FirstOrDefaultAsync(x => x.Id == id);

                if (TaskToUpdate == null)
                {
                    throw new Exception("An unexpected error occurred while updating the task.");
                }

                _mapper.Map(updateTodoData, TaskToUpdate);

                await _context.SaveChangesAsync();

                var updatedTaskResponse = _mapper.Map<TodoResponseDTO>(TaskToUpdate);

                return new UpdateTaskResponseDTO
                {
                    Message = "Your Task Has Been Updated",
                    UpdatedTask = updatedTaskResponse
                };
            
            
        }

    }
}