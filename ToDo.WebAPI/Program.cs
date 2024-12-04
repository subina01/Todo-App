using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json;
using TodoApp.Core.Domain.IdentityEntities;
using TodoApp.Core.Domain.Interface;
using TodoApp.Core.Domain.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using Todo.Infrastructure.Database;
using Todo.Infrastructure.Services;
using TodoApp.Core.Domain.IdentityEntities;
using TodoApp.Core.Domain.Interface;
using TodoApp.Core.Domain.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using Todo.Infrastructure.Map;
using TodoApp.Core.Domain.IdentityEntities;
using TodoApp.Core.Domain.Interface;
using TodoApp.Core.Domain.Services;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnectionString")
    )
);

builder.Services.AddScoped<ITodoServices, TodoRepository>();  // Scoped lifetime for Todo services
builder.Services.AddTransient<IJwtService, JwtService>();      // Transient lifetime for JWT services

    .AddDefaultTokenProviders();//predefined token provider lai enable garxa
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
.AddJwtBearer(options =>
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

// Swagger setup for API documentation
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.AddSecurityDefinition(name: JwtBearerDefaults.AuthenticationScheme, securityScheme: new OpenApiSecurityScheme
    {
        Name = "Authorization",
        Description = "Enter the Bearer token: `Bearer <Generated-JWT-Token>`",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.ApiKey,
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
                    Id = JwtBearerDefaults.AuthenticationScheme
                }
            },
            new string[] { }
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
builder.Services.AddScoped<ITodoServices, TodoRepository>();


builder.Services.AddTransient<IJwtService, JwtService>();

builder.Services.AddTransient<IJwtService, JwtService>();

//enable identity in this project
builder.Services.AddIdentity<ApplicationUser,
    ApplicationRole>()//Now it understood that we have to enable the identity services
    .AddEntityFrameworkStores<ApplicationDbContext>()//using entity framework to store the data and exact dbcontext we are using is ApplicationDBContext


    .AddDefaultTokenProviders();//predefined token provider lai enable garxa





builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;  // Use JWT Bearer scheme for authentication
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;     // Challenge the client if authentication fails
})
.AddJwtBearer(options =>
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

builder.Services.AddScoped<ITodoServices, TodoRepository>();


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
    

    .AddRoleStore<RoleStore<ApplicationRole, ApplicationDbContext, Guid>>();//this is the repository layer for manipulating the roles data
builder.Services.AddRazorPages();


builder.Services.AddControllers();
and service registration)
});
builder.Services.AddRazorPages();


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
builder.Services.AddScoped<ITodoServices, TodoRepository>();

builder.Services.AddTransient<IJwtService, JwtService>();

builder.Services.AddTransient<IJwtService, JwtService>();

builder.Services.AddTransient<IJwtService, JwtService>();


builder.Services.AddIdentity<ApplicationUser,
    ApplicationRole>()//Now it understood that we have to enable the identity services
    .AddEntityFrameworkStores<ApplicationDbContext>()//using entity framework to store the data and exact dbcontext we are using is ApplicationDBContext

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


builder.Services.AddScoped<ITodoServices, TodoServices>();

builder.Services.AddScoped<ITodoServices, TodoRepository>();


builder.Services.AddScoped<ITodoServices, TodoRepository>();


    
    .AddDefaultTokenProviders()//predefined token provider lai enable garxa

    .AddUserStore<UserStore<ApplicationUser, ApplicationRole, ApplicationDbContext, Guid>>()//whats the exact repository layer to use as we cannot use dbcontext directly in the userManager class


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
    
   .AddRoleStore<RoleStore<ApplicationRole, ApplicationDbContext, Guid>>();//this is the repository layer for manipulating the roles data

    builder.Services.AddRazorPages();


    builder.Services.AddControllers();

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

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


=======
>>>>>>> efcbf6a (feat(startup): add ASP.NET Web API project with enabling openAi, layer references, and service registration)
=======
>>>>>>> 3cfe03a (refactor(controller): update controller methods to integrate request and response DTOs)
=======
>>>>>>> 87b39c6 (feat(ui): add CRUD APIs with constructor-based dependency injection)
=======


>>>>>>> 86a57ab (feat(auth): Add jwt based authentication)
var app = builder.Build();

// Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();//for reading identity cookie
app.UseAuthorization();//validates access permission of the user



app.UseAuthorization();



app.UseAuthorization();


app.UseAuthorization();

app.MapControllers();

app.Run();


app.UseAuthorization();

app.UseAuthentication();//for reading identity cookie
app.UseAuthorization();//validates access permission of the user

app.UseAuthorization();
and service registration)


app.UseAuthorization();

app.UseAuthentication();//for reading identity cookie
app.UseAuthorization();//validates access permission of the user


app.MapControllers();

app.Run();
