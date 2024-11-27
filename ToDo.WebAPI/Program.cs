using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Todo.Infrastructure.Database;
using Todo.Infrastructure.Services;
using TodoApp.Core.Domain.IdentityEntities;
using TodoApp.Core.Domain.Interface;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnectionString")
    )
);

builder.Services.AddScoped<ITodoServices, TodoRepository>();
//enable identity in this project
builder.Services.AddIdentity<ApplicationUser,
    ApplicationRole>()//Now it understood that we have to enable the identity services
    .AddEntityFrameworkStores<ApplicationDbContext>()//using entity framework to store the data and exact dbcontext we are using is ApplicationDBContext
    
    .AddDefaultTokenProviders()//predefined token provider lai enable garxa
    
    .AddUserStore<UserStore<ApplicationUser, ApplicationRole, ApplicationDbContext, Guid>>()//whats the exact repository layer to use as we cannot use dbcontext directly in the userManager class
    
    .AddRoleStore<RoleStore<ApplicationRole, ApplicationDbContext, Guid>>();//this is the repository layer for manipulating the roles data
builder.Services.AddRazorPages();


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
