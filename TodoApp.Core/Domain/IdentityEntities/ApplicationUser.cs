﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



using TodoApp.Core.Domain.Enum;
=======
>>>>>>> c90400b (feat(Registration): Added Registration API using ASP.NET Identity)
=======
using TodoApp.Core.Domain.Enum;
>>>>>>> 86a57ab (feat(auth): Add jwt based authentication)
=======

>>>>>>> 6af2c4c (feat(auth): implement authentication and authorization using jwt)

namespace TodoApp.Core.Domain.IdentityEntities
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        public string? Name { get; set; }



=======
>>>>>>> c90400b (feat(Registration): Added Registration API using ASP.NET Identity)
=======
     
>>>>>>> 86a57ab (feat(auth): Add jwt based authentication)
    }
}
