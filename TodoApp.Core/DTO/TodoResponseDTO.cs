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
        public string? TaskAssignedTo { get; set; }
        public string? TaskType { get; set; }
        public string? Description { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? CompletionDate { get; set; }
        public string? Status { get; set; }
    }
}
