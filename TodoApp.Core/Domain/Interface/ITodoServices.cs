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
                public Task AddTask(ToDo ToDoData);
                public Task<UpdateTaskResponseDTO> UpdateTask(int id, UpdateTaskRequestDTO updateTodoTask);
                public Task<GetAllTaskResponseDTO> GetAllTask();
                public Task<GetTaskByIdResponseDTO> GetTaskById(int id);


                public Task<DeleteTaskResponseDTO> DeleteTask(int id);

        }

}
