using TodoApp.Core.Domain.Entities;
using TodoApp.Core.DTO;
namespace TodoApp.Core.Domain.Interface
{
	public interface ITodoServices
	{
		public Task AddTask(ToDo ToDoData);
		public Task<UpdateTaskResponseDTO> UpdateTask(int id, UpdateTaskRequestDTO updateTodoTask);
		public Task<GetAllTasksResponseDTO> GetAllTask();
		public Task<GetAllTaskByIdResponseDTO> GetTaskById(int id);

		public Task<DeleteTaskResponseDTO> DeleteTask(int id);
	}

}