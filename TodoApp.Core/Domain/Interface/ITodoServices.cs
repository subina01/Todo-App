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

        public  Task<IEnumerable<GetAllTasksResponseDTO>> GetAllTasks();

        public Task<GetAllTaskByIdResponseDTO> GetTaskById(int id);


        public Task AddTask(ToDo tododata);
        public Task<UpdateTaskResponseDTO> UpdateTask(int id, UpdateTaskRequestDTO updateTodoTask);
        public  Task<UpdateStatusResponseDTO> UpdateTaskStatus(int id, UpdateStatusRequestDTO newStatus);
        public Task<DeleteTaskResponseDTO> DeleteTask(int id);
    }
}
