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
=======

>>>>>>> d8c1fe9 (feat(core): complete core layer implementation)
        public string? UserName { get; set; }
        public string? TaskType { get; set; }

        public string? Description { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime DueDate { get; set; }

        public DateTime CompletionDate { get; set; }

        public string? Status { get; set; }

    }
}
