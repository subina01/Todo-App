using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
<<<<<<< HEAD
using TodoApp.Core.Domain.Enum;
=======
>>>>>>> c90400b (feat(Registration): Added Registration API using ASP.NET Identity)

namespace TodoApp.Core.Domain.IdentityEntities
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        public string? Name { get; set; }
<<<<<<< HEAD
     
=======
>>>>>>> c90400b (feat(Registration): Added Registration API using ASP.NET Identity)
    }
}
