<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
=======
﻿using Microsoft.EntityFrameworkCore;
>>>>>>> ea898ab (feat(infrastructure): add application db context and service implementation)
=======
﻿using Microsoft.EntityFrameworkCore;
>>>>>>> c99b1a6 (refactor(repository): implement DTOs in repository methods for task operations)
=======
﻿using Microsoft.EntityFrameworkCore;
>>>>>>> 769f1e3 (feat(infrastructure): add application db context and service implementation)
=======
﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
>>>>>>> c90400b (feat(Registration): Added Registration API using ASP.NET Identity)
=======
<<<<<<< HEAD
﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
>>>>>>> 6af2c4cf890176350c27058ed130352aecbf6b7c
=======
﻿using Microsoft.EntityFrameworkCore;
>>>>>>> ea2fbee (feat(infrastructure): add application db context and service implementation)
<<<<<<< HEAD
>>>>>>> b701d45 (feat(infrastructure): add application db context and service implementation)
=======
=======
﻿using Microsoft.EntityFrameworkCore;
>>>>>>> 7dda02d (refactor(repository): implement DTOs in repository methods for task operations)
<<<<<<< HEAD
>>>>>>> 21f4e66 (refactor(repository): implement DTOs in repository methods for task operations)
=======
=======
﻿using Microsoft.EntityFrameworkCore;
>>>>>>> 41e5918 (feat(infrastructure): add application db context and service implementation)
<<<<<<< HEAD
>>>>>>> d0b2b5f (feat(infrastructure): add application db context and service implementation)
=======
=======
﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
>>>>>>> 73d3215 (feat(Registration): Added Registration API using ASP.NET Identity)
<<<<<<< HEAD
>>>>>>> be0f8e4 (chore: Remove bin and obj folders from version control)
=======
=======
﻿using Microsoft.EntityFrameworkCore;
>>>>>>> ea898ab (feat(infrastructure): add application db context and service implementation)
>>>>>>> 765cc0b (feat(infrastructure): add application db context and service implementation)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.Core.Domain.Entities;
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> 6af2c4cf890176350c27058ed130352aecbf6b7c
using TodoApp.Core.Domain.IdentityEntities;

namespace Todo.Infrastructure.Database
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, Guid>
<<<<<<< HEAD
=======
=======
>>>>>>> c99b1a6 (refactor(repository): implement DTOs in repository methods for task operations)
=======
>>>>>>> 769f1e3 (feat(infrastructure): add application db context and service implementation)
=======
>>>>>>> ea2fbee (feat(infrastructure): add application db context and service implementation)
=======
>>>>>>> 7dda02d (refactor(repository): implement DTOs in repository methods for task operations)
=======
>>>>>>> 41e5918 (feat(infrastructure): add application db context and service implementation)
=======
>>>>>>> ea898ab (feat(infrastructure): add application db context and service implementation)

namespace Todo.Infrastructure.Database
{
    public class ApplicationDbContext : DbContext
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
>>>>>>> ea898ab (feat(infrastructure): add application db context and service implementation)
=======
>>>>>>> c99b1a6 (refactor(repository): implement DTOs in repository methods for task operations)
=======
>>>>>>> 769f1e3 (feat(infrastructure): add application db context and service implementation)
=======
using TodoApp.Core.Domain.IdentityEntities;

namespace Todo.Infrastructure.Database
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, Guid>
>>>>>>> c90400b (feat(Registration): Added Registration API using ASP.NET Identity)
=======
<<<<<<< HEAD
>>>>>>> 6af2c4cf890176350c27058ed130352aecbf6b7c
=======
>>>>>>> ea2fbee (feat(infrastructure): add application db context and service implementation)
<<<<<<< HEAD
>>>>>>> b701d45 (feat(infrastructure): add application db context and service implementation)
=======
=======
>>>>>>> 7dda02d (refactor(repository): implement DTOs in repository methods for task operations)
<<<<<<< HEAD
>>>>>>> 21f4e66 (refactor(repository): implement DTOs in repository methods for task operations)
=======
=======
>>>>>>> 41e5918 (feat(infrastructure): add application db context and service implementation)
<<<<<<< HEAD
>>>>>>> d0b2b5f (feat(infrastructure): add application db context and service implementation)
=======
=======
using TodoApp.Core.Domain.IdentityEntities;

namespace Todo.Infrastructure.Database
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, Guid>
>>>>>>> 73d3215 (feat(Registration): Added Registration API using ASP.NET Identity)
<<<<<<< HEAD
>>>>>>> be0f8e4 (chore: Remove bin and obj folders from version control)
=======
=======
>>>>>>> ea898ab (feat(infrastructure): add application db context and service implementation)
>>>>>>> 765cc0b (feat(infrastructure): add application db context and service implementation)
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<ToDo> TodoData { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ToDo>().HasKey(t => t.Id);
            base.OnModelCreating(modelBuilder);
        }
    }
}
