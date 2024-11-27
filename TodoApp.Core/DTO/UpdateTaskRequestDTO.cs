﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp.Core.DTO
{
    public class UpdateTaskRequestDTO
    {
        public int Id { get; set; }

        public string? UserName { get; set; }
        public string? TaskType { get; set; }

        public string? Description { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? DueDate { get; set; }

        public DateTime? CompletionDate { get; set; }
    }
}