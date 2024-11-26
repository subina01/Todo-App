using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp.Core.DTO
{
    public class TodoResponseDTO
    {
        public int Id { get; set; }
<<<<<<< HEAD
<<<<<<< HEAD
=======

>>>>>>> d8c1fe9 (feat(core): complete core layer implementation)
=======
>>>>>>> e8c83a0 (feat(dto):add request and response DTOs for updating, deleting, and retrieving tasks)
        public string? UserName { get; set; }
        public string? TaskType { get; set; }

        public string? Description { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime DueDate { get; set; }

        public DateTime CompletionDate { get; set; }

        public string? Status { get; set; }

    }
}
