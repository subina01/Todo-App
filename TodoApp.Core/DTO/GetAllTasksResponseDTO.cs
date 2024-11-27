using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp.Core.DTO
{
    public class GetAllTasksResponseDTO
    {
        public IEnumerable<TodoResponseDTO>? Tasks { get; set; }
        public int TotalTask { get; set; }
    }
}
