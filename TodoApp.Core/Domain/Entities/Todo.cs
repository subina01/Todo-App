using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp.Core.Domain.Entities
{
    public class ToDo
    {
        
        public int Id { get; set; }

        public string? TaskAssignedTo { get; set; }
        public DateTime StartDate { get; set; } = DateTime.Now;

        public DateTime DueDate { get; set; }

         public string? TaskType { get; set; }

        public string? Description { get; set; }

       public DateTime CompletionDate { get; set; }

        public string? Status { get; set; }
    }
}
