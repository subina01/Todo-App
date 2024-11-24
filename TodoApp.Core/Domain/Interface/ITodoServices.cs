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
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> 0f689a6 (feat(core): complete core layer implementation)
=======
<<<<<<< HEAD
>>>>>>> 6af2c4cf890176350c27058ed130352aecbf6b7c
=======
>>>>>>> ca4de06 (feat(core): complete core layer implementation)
>>>>>>> c21a00c (feat(core): complete core layer implementation)
        public  Task<IEnumerable<GetAllTasksResponseDTO>> GetAllTasks();

        public Task<GetAllTaskByIdResponseDTO> GetTaskById(int id);


        public Task AddTask(ToDo tododata);
        public Task<UpdateTaskResponseDTO> UpdateTask(int id, UpdateTaskRequestDTO updateTodoTask);
        public  Task<UpdateStatusResponseDTO> UpdateTaskStatus(int id, UpdateStatusRequestDTO newStatus);
        public Task<DeleteTaskResponseDTO> DeleteTask(int id);
<<<<<<< HEAD
<<<<<<< HEAD
=======
        public  Task<IEnumerable<TodoResponseDTO>> GetAllTasks();
=======
        public  Task<IEnumerable<GetAllTasksResponseDTO>> GetAllTasks();
>>>>>>> e8c83a0 (feat(dto):add request and response DTOs for updating, deleting, and retrieving tasks)

        public Task<GetAllTaskByIdResponseDTO> GetTaskById(int id);


<<<<<<< HEAD
=======
        public  Task<IEnumerable<TodoResponseDTO>> GetAllTasks();
=======
        public  Task<IEnumerable<GetAllTasksResponseDTO>> GetAllTasks();
>>>>>>> 83c617e (feat(dto):add request and response DTOs for updating, deleting, and retrieving tasks)

        public Task<GetAllTaskByIdResponseDTO> GetTaskById(int id);


<<<<<<< HEAD
>>>>>>> 3d1dbd0 (refactor: updated sln file with updatedfeatures)
=======
        public  Task<IEnumerable<TodoResponseDTO>> GetAllTasks();

        Task<TodoResponseDTO> GetTaskById(int id);


>>>>>>> d8c1fe9 (feat(core): complete core layer implementation)
        Task AddTask(ToDo tododata);
        Task<string> UpdateTask(int id, TodoResponseDTO updateTodoTask);
        Task<string> UpdateTaskStatus(int id, TodoResponseDTO newStatus);
        Task<string> DeleteTask(int id);
<<<<<<< HEAD
<<<<<<< HEAD
>>>>>>> d8c1fe9 (feat(core): complete core layer implementation)
=======
=======
>>>>>>> 83c617e (feat(dto):add request and response DTOs for updating, deleting, and retrieving tasks)
        public Task AddTask(ToDo tododata);
        public Task<UpdateTaskResponseDTO> UpdateTask(int id, UpdateTaskRequestDTO updateTodoTask);
        public  Task<UpdateStatusResponseDTO> UpdateTaskStatus(int id, UpdateStatusRequestDTO newStatus);
        public Task<DeleteTaskResponseDTO> DeleteTask(int id);
<<<<<<< HEAD
>>>>>>> e8c83a0 (feat(dto):add request and response DTOs for updating, deleting, and retrieving tasks)
=======
>>>>>>> 0f689a6 (feat(core): complete core layer implementation)
=======
<<<<<<< HEAD
>>>>>>> 6af2c4cf890176350c27058ed130352aecbf6b7c
=======
>>>>>>> 3d1dbd0 (refactor: updated sln file with updatedfeatures)
<<<<<<< HEAD
>>>>>>> 78b8029 (refactor: updated sln file with updatedfeatures)
=======
=======
>>>>>>> 83c617e (feat(dto):add request and response DTOs for updating, deleting, and retrieving tasks)
<<<<<<< HEAD
>>>>>>> 76a6841 (Removed unused files and assemblies)
=======
=======
>>>>>>> ca4de06 (feat(core): complete core layer implementation)
<<<<<<< HEAD
>>>>>>> c21a00c (feat(core): complete core layer implementation)
=======
=======
>>>>>>> d8c1fe9 (feat(core): complete core layer implementation)
>>>>>>> e4238f5 (feat(core): complete core layer implementation)
    }
}
