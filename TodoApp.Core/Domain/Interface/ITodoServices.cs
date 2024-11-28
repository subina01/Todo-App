using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.Core.Domain.Entities;
using TodoApp.Core.DTO;

namespace TodoApp.Core.Domain.Interface

{
    public interface ITodoServices
    {

        public  Task<IEnumerable<TodoResponseDTO>> GetAllTasks();

        Task<TodoResponseDTO> GetTaskById(int id);


        Task AddTask(ToDo tododata);
        Task<string> UpdateTask(int id, TodoResponseDTO updateTodoTask);
        Task<string> UpdateTaskStatus(int id, TodoResponseDTO newStatus);
        Task<string> DeleteTask(int id);
    }
}
