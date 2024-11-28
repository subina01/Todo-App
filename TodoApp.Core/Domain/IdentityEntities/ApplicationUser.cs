using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.Core.Domain.Enum;



using TodoApp.Core.Domain.Enum;

using TodoApp.Core.Domain.Enum;


namespace TodoApp.Core.Domain.IdentityEntities
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        public string? Name { get; set; }
    }
}
