
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp.Core.DTO
{
    public class UpdateStatusRequestDTO
    {
        public int Id { get; set; }

        public string? Status { get; set; } 
    }
}
