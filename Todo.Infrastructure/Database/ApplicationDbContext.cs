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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.Core.Domain.Entities;
<<<<<<< HEAD
<<<<<<< HEAD
using TodoApp.Core.Domain.IdentityEntities;

namespace Todo.Infrastructure.Database
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, Guid>
=======
=======
>>>>>>> c99b1a6 (refactor(repository): implement DTOs in repository methods for task operations)

namespace Todo.Infrastructure.Database
{
    public class ApplicationDbContext : DbContext
<<<<<<< HEAD
>>>>>>> ea898ab (feat(infrastructure): add application db context and service implementation)
=======
>>>>>>> c99b1a6 (refactor(repository): implement DTOs in repository methods for task operations)
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
