using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp.Core.DTO
{
    public class UpdateStatusResponseDTO
    {
        public string? Message {  get; set; }
        public string? UpdatedStatus { get; set; }
    }
}
