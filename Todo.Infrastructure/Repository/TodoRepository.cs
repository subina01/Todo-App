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

        /// <summary>
        /// Sets up the repository to interact with the database and map data between entities and DTOs.
        /// </summary>
        /// <param name="context">The database context for managing tasks.</param>
        /// <param name="mapper">The mapping service for converting between models and DTOs.</param>

        public TodoRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        /// <summary>
        /// Adds a new task to the database.
        /// </summary>
        /// <param name="TodoData">The task details to be added.</param>
        /// <returns>A task that represents the asynchronous save operation.</returns>

        public async Task AddTask(TodoRequestDTO TodoData)
        {
            var TodoInput = _mapper.Map<ToDo>(TodoData);
            await _context.AddAsync(TodoInput);
            await _context.SaveChangesAsync();
        }
        /// <summary>
        /// Removes a task from the database based on its id.
        /// </summary>
        /// <param name="id">The id of the task to delete.</param>
        /// <returns>A response with a success message confirming the task was deleted.</returns>
        /// <exception cref="Exception">Throws if the task with the given ID is not found.</exception>

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
        /// <summary>
        /// Fetches the details of a specific task using its ID.
        /// </summary>
        /// <param name="id">The ID of the task to retrieve.</param>
        /// <returns>A detailed response containing the task information.</returns>
        /// <exception cref="Exception">Throws if no task is found with the provided ID.</exception>

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
        /// <summary>
        /// Retrieves all tasks stored in the database.
        /// </summary>
        /// <returns>A response containing a list of all tasks and the total count of tasks.</returns>
        /// <exception cref="Exception">Throws if something goes wrong while fetching the tasks.</exception>

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
        /// <summary>
        /// Updates an existing task in the database with new information.
        /// </summary>
        /// <param name="id">The ID of the task to update.</param>
        /// <param name="updateTodoData">The updated task details.</param>
        /// <returns>A response with a success message and the updated task details.</returns>
        /// <exception cref="Exception">Throws if no task is found with the provided ID.</exception>

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