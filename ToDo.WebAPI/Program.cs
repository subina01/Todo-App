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
>>>>>>> 5783ca4 (feat(auth): Add jwt based authentication)
=======
>>>>>>> 86a57ab (feat(auth): Add jwt based authentication)
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> 6af2c4c (feat(auth): implement authentication and authorization using jwt)
using Microsoft.OpenApi.Models;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using Todo.Infrastructure.Database;
using Todo.Infrastructure.Services;
using TodoApp.Core.Domain.IdentityEntities;
using TodoApp.Core.Domain.Interface;
using TodoApp.Core.Domain.Services;
=======
=======
>>>>>>> 7f01e22 (feat(ui): add CRUD APIs with constructor-based dependency injection)
=======
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
>>>>>>> 73d3215 (feat(Registration): Added Registration API using ASP.NET Identity)
using Microsoft.EntityFrameworkCore;
=======
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
>>>>>>> 5783ca4 (feat(auth): Add jwt based authentication)
using Todo.Infrastructure.Database;
using Todo.Infrastructure.Services;
using TodoApp.Core.Domain.IdentityEntities;
using TodoApp.Core.Domain.Interface;
using TodoApp.Core.Domain.Services;

<<<<<<< HEAD
>>>>>>> d1de45d (refactor(controller): update controller methods to integrate request and response DTOs)
=======
>>>>>>> 7f01e22 (feat(ui): add CRUD APIs with constructor-based dependency injection)
=======
=======
>>>>>>> 3cfe03a (refactor(controller): update controller methods to integrate request and response DTOs)
=======
>>>>>>> 87b39c6 (feat(ui): add CRUD APIs with constructor-based dependency injection)
=======
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
>>>>>>> c90400b (feat(Registration): Added Registration API using ASP.NET Identity)
using Microsoft.EntityFrameworkCore;
=======
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
>>>>>>> 86a57ab (feat(auth): Add jwt based authentication)
using Todo.Infrastructure.Database;
using Todo.Infrastructure.Services;
using TodoApp.Core.Domain.IdentityEntities;
using TodoApp.Core.Domain.Interface;
using TodoApp.Core.Domain.Services;

<<<<<<< HEAD
<<<<<<< HEAD
>>>>>>> efcbf6a (feat(startup): add ASP.NET Web API project with enabling openAi, layer references, and service registration)
=======
>>>>>>> 3cfe03a (refactor(controller): update controller methods to integrate request and response DTOs)
=======
>>>>>>> 87b39c6 (feat(ui): add CRUD APIs with constructor-based dependency injection)
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======

>>>>>>> d1de45d (refactor(controller): update controller methods to integrate request and response DTOs)
=======

>>>>>>> 7f01e22 (feat(ui): add CRUD APIs with constructor-based dependency injection)
=======

>>>>>>> efcbf6a (feat(startup): add ASP.NET Web API project with enabling openAi, layer references, and service registration)
=======

>>>>>>> 3cfe03a (refactor(controller): update controller methods to integrate request and response DTOs)
=======

>>>>>>> 87b39c6 (feat(ui): add CRUD APIs with constructor-based dependency injection)
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnectionString")
    )
);

<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
// Register services for Dependency Injection (DI)
builder.Services.AddScoped<ITodoServices, TodoRepository>();  // Scoped lifetime for Todo services
builder.Services.AddTransient<IJwtService, JwtService>();      // Transient lifetime for JWT services

// Enable Identity services for authentication and authorization
builder.Services.AddIdentity<ApplicationUser, ApplicationRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>()   // Use Entity Framework for storing user data
    .AddDefaultTokenProviders();                         // Enable the default token providers for Identity (e.g., email confirmation tokens)

// Add Authentication and JWT Bearer token support
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;  // Use JWT Bearer scheme for authentication
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;     // Challenge the client if authentication fails
})
.AddJwtBearer(options =>
{
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,               // Validate the issuer of the token
        ValidateAudience = true,             // Validate the audience of the token
        ValidateLifetime = true,             // Validate the token's expiration time
        ValidateIssuerSigningKey = true,     // Validate the signing key of the token
        ValidIssuer = builder.Configuration["Jwt:Issuer"],  // Set the valid issuer for the token
        ValidAudience = builder.Configuration["Jwt:Audience"], // Set the valid audience for the token
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"])) // Set the key to validate the token's signature
    };
});

builder.Services.AddRazorPages();  // Add support for Razor Pages

// Configure controllers to use specific JSON serialization settings
builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());  // Handle enums as strings in JSON
});

// Configure additional JSON options like camel case property naming and ignoring null properties
builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;  // Use camel case for property names in JSON
        options.JsonSerializerOptions.DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull;  // Ignore properties with null values
    });

// Add support for Swagger (API documentation)
builder.Services.AddEndpointsApiExplorer();  // Enables OpenAPI support
builder.Services.AddSwaggerGen(options =>
{
    options.AddSecurityDefinition(name: JwtBearerDefaults.AuthenticationScheme, securityScheme: new Microsoft.OpenApi.Models.OpenApiSecurityScheme
    {
        Name = "Authorization",
        Description = "Enter the Bearer Authorization: `Bearer Generated-JWT-Token`",
        In = Microsoft.OpenApi.Models.ParameterLocation.Header,
        Type = Microsoft.OpenApi.Models.SecuritySchemeType.ApiKey,
        Scheme = "Bearer"
    });

    options.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = JwtBearerDefaults.AuthenticationScheme  // Use the previously defined JWT Bearer authentication scheme
                }
            },
            new string[] { }  // No specific scope is required
        }
    });
});

var app = builder.Build();  

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment()) 
{
    app.UseSwagger();
    app.UseSwaggerUI();  
}

app.UseHttpsRedirection();  
app.UseAuthentication();    // Add authentication middleware to validate JWT token
app.UseAuthorization();     // Add authorization middleware to check the user's permissions

app.MapControllers(); 

app.Run(); 
=======
=======
>>>>>>> 7f01e22 (feat(ui): add CRUD APIs with constructor-based dependency injection)
builder.Services.AddScoped<ITodoServices, TodoRepository>();
<<<<<<< HEAD
<<<<<<< HEAD
builder.Services.AddTransient<IJwtService, JwtService>();
=======
>>>>>>> c90400b (feat(Registration): Added Registration API using ASP.NET Identity)
=======
builder.Services.AddTransient<IJwtService, JwtService>();
>>>>>>> 86a57ab (feat(auth): Add jwt based authentication)
//enable identity in this project
builder.Services.AddIdentity<ApplicationUser,
    ApplicationRole>()//Now it understood that we have to enable the identity services
    .AddEntityFrameworkStores<ApplicationDbContext>()//using entity framework to store the data and exact dbcontext we are using is ApplicationDBContext
<<<<<<< HEAD
<<<<<<< HEAD

    .AddDefaultTokenProviders();//predefined token provider lai enable garxa
    
    



builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;//Authentication ko primary system ho , JWT tokens use garxa.
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;//Authentication failed bhaye user lai Challenge garna token valid cha ki chaina check garna yaha specify garxa.
})
.AddJwtBearer(options => //Yo JWT ko details specify garxa for validation.
{
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer = builder.Configuration["Jwt:Issuer"],
        ValidAudience = builder.Configuration["Jwt:Audience"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]))
    };
    
});
builder.Services.AddRazorPages();


builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
});

builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
        options.JsonSerializerOptions.DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull;
    });
=======
builder.Services.AddScoped<ITodoServices, TodoServices>();
=======
builder.Services.AddScoped<ITodoServices, TodoRepository>();
>>>>>>> 3cfe03a (refactor(controller): update controller methods to integrate request and response DTOs)
=======
builder.Services.AddScoped<ITodoServices, TodoRepository>();
>>>>>>> 87b39c6 (feat(ui): add CRUD APIs with constructor-based dependency injection)

=======
=======

    .AddDefaultTokenProviders();//predefined token provider lai enable garxa
>>>>>>> 86a57ab (feat(auth): Add jwt based authentication)
    
    



builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;//Authentication ko primary system ho , JWT tokens use garxa.
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;//Authentication failed bhaye user lai Challenge garna token valid cha ki chaina check garna yaha specify garxa.
})
.AddJwtBearer(options => //Yo JWT ko details specify garxa for validation.
{
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer = builder.Configuration["Jwt:Issuer"],
        ValidAudience = builder.Configuration["Jwt:Audience"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]))
    };
    
<<<<<<< HEAD
    .AddRoleStore<RoleStore<ApplicationRole, ApplicationDbContext, Guid>>();//this is the repository layer for manipulating the roles data
>>>>>>> c90400b (feat(Registration): Added Registration API using ASP.NET Identity)
builder.Services.AddRazorPages();


builder.Services.AddControllers();
<<<<<<< HEAD
<<<<<<< HEAD
>>>>>>> efcbf6a (feat(startup): add ASP.NET Web API project with enabling openAi, layer references, and service registration)
=======
>>>>>>> 3cfe03a (refactor(controller): update controller methods to integrate request and response DTOs)
=======
>>>>>>> 87b39c6 (feat(ui): add CRUD APIs with constructor-based dependency injection)
=======
});
builder.Services.AddRazorPages();


builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
});

builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
        options.JsonSerializerOptions.DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull;
    });
>>>>>>> 86a57ab (feat(auth): Add jwt based authentication)
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.AddSecurityDefinition(name: JwtBearerDefaults.AuthenticationScheme, securityScheme: new Microsoft.OpenApi.Models.OpenApiSecurityScheme{
        Name = "Authorization",
        Description = "Enter the Bearer Authorization : `Bearer Genreated-JWT-Token`",
        In = Microsoft.OpenApi.Models.ParameterLocation.Header,
        Type =Microsoft.OpenApi.Models.SecuritySchemeType.ApiKey,
        Scheme ="Bearer"
    });
    options.AddSecurityRequirement(new OpenApiSecurityRequirement
    { {
        new OpenApiSecurityScheme
        {
            Reference = new OpenApiReference
            {
                Type=ReferenceType.SecurityScheme,
                Id = JwtBearerDefaults.AuthenticationScheme
            }
        }, new String []{}
        }
    });
});

<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD


=======
>>>>>>> efcbf6a (feat(startup): add ASP.NET Web API project with enabling openAi, layer references, and service registration)
=======
>>>>>>> 3cfe03a (refactor(controller): update controller methods to integrate request and response DTOs)
=======
>>>>>>> 87b39c6 (feat(ui): add CRUD APIs with constructor-based dependency injection)
=======


>>>>>>> 86a57ab (feat(auth): Add jwt based authentication)
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
app.UseAuthentication();//for reading identity cookie
app.UseAuthorization();//validates access permission of the user
=======

app.UseAuthorization();
>>>>>>> efcbf6a (feat(startup): add ASP.NET Web API project with enabling openAi, layer references, and service registration)
=======

app.UseAuthorization();
>>>>>>> 3cfe03a (refactor(controller): update controller methods to integrate request and response DTOs)
=======

app.UseAuthorization();
>>>>>>> 87b39c6 (feat(ui): add CRUD APIs with constructor-based dependency injection)
=======
app.UseAuthentication();//for reading identity cookie
app.UseAuthorization();//validates access permission of the user
>>>>>>> 86a57ab (feat(auth): Add jwt based authentication)

app.MapControllers();

app.Run();
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
>>>>>>> d1de45d (refactor(controller): update controller methods to integrate request and response DTOs)
=======
>>>>>>> 7f01e22 (feat(ui): add CRUD APIs with constructor-based dependency injection)
=======
>>>>>>> efcbf6a (feat(startup): add ASP.NET Web API project with enabling openAi, layer references, and service registration)
=======
>>>>>>> 3cfe03a (refactor(controller): update controller methods to integrate request and response DTOs)
=======
>>>>>>> 87b39c6 (feat(ui): add CRUD APIs with constructor-based dependency injection)
