

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

using Microsoft.EntityFrameworkCore;

using Microsoft.EntityFrameworkCore;

using Microsoft.EntityFrameworkCore;

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


using Microsoft.EntityFrameworkCore;

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using TodoApp.Core.Domain.Enities;
using TodoApp.Core.Domain.Entities;
using TodoApp.Core.Domain.IdentityEntities;

namespace TodoApp.Infrastructure.Database
{

    using Microsoft.EntityFrameworkCore;

    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using TodoApp.Core.Domain.Entities;
    using TodoApp.Core.Domain.IdentityEntities;

    namespace Todo.Infrastructure.Database
   public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, Guid>

namespace Todo.Infrastructure.Database
    {
        public class ApplicationDbContext : DbContext
using TodoApp.Core.Domain.IdentityEntities;

namespace Todo.Infrastructure.Database
        {
            public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, Guid>
            {
                public class ApplicationDbContext : DbContext
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

{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, Guid>

namespace Todo.Infrastructure.Database
            {
                public class ApplicationDbContext : DbContext

using TodoApp.Core.Domain.IdentityEntities;

namespace Todo.Infrastructure.Database
                {
                    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, Guid>
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
