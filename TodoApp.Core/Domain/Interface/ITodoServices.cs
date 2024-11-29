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

<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> 0f689a6 (feat(core): complete core layer implementation)
        public  Task<IEnumerable<GetAllTasksResponseDTO>> GetAllTasks();

        public Task<GetAllTaskByIdResponseDTO> GetTaskById(int id);


        public Task AddTask(ToDo tododata);
        public Task<UpdateTaskResponseDTO> UpdateTask(int id, UpdateTaskRequestDTO updateTodoTask);
        public  Task<UpdateStatusResponseDTO> UpdateTaskStatus(int id, UpdateStatusRequestDTO newStatus);
        public Task<DeleteTaskResponseDTO> DeleteTask(int id);
<<<<<<< HEAD
=======
        public  Task<IEnumerable<TodoResponseDTO>> GetAllTasks();
=======
        public  Task<IEnumerable<GetAllTasksResponseDTO>> GetAllTasks();
>>>>>>> e8c83a0 (feat(dto):add request and response DTOs for updating, deleting, and retrieving tasks)

        public Task<GetAllTaskByIdResponseDTO> GetTaskById(int id);


<<<<<<< HEAD
        Task AddTask(ToDo tododata);
        Task<string> UpdateTask(int id, TodoResponseDTO updateTodoTask);
        Task<string> UpdateTaskStatus(int id, TodoResponseDTO newStatus);
        Task<string> DeleteTask(int id);
>>>>>>> d8c1fe9 (feat(core): complete core layer implementation)
=======
        public Task AddTask(ToDo tododata);
        public Task<UpdateTaskResponseDTO> UpdateTask(int id, UpdateTaskRequestDTO updateTodoTask);
        public  Task<UpdateStatusResponseDTO> UpdateTaskStatus(int id, UpdateStatusRequestDTO newStatus);
        public Task<DeleteTaskResponseDTO> DeleteTask(int id);
>>>>>>> e8c83a0 (feat(dto):add request and response DTOs for updating, deleting, and retrieving tasks)
=======
>>>>>>> 0f689a6 (feat(core): complete core layer implementation)
    }
}
