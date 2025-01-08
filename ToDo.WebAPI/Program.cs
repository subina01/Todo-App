using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;
using Todo.Infrastructure.Map;
using TodoApp.Core.Domain.IdentityEntities;
using TodoApp.Core.Domain.Interface;
using TodoApp.Core.Domain.Services;
using TodoApp.Infrastructure.Database;

using TodoApp.Infrastructure.Repository;


var builder = WebApplication.CreateBuilder(args);

/// <summary>
/// Configures the database context to use SQL Server and specifies the connection string from the configuration.
/// </summary>
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnectionString")
    )
);
/// <summary>
/// Registers services with a scoped lifetime for dependency injection.
/// </summary>
builder.Services.AddScoped<ITodoServices, TodoRepository>();
/// <summary>
/// Registers services with transient for handling JWT token functionality.
/// </summary>
builder.Services.AddTransient<IJwtService, JwtService>();

/// <summary>
/// Configures AutoMapper for object mapping based on the specified mapping profile.
/// </summary>
builder.Services.AddAutoMapper(typeof(MappingProfile));
/// <summary>
/// Enables Identity for managing user authentication, roles, and token providers using Entity Framework.
/// </summary>
builder.Services.AddIdentity<ApplicationUser, ApplicationRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddDefaultTokenProviders();

/// <summary>
/// Configures authentication services, specifying JWT Bearer as the primary authentication scheme.
/// The primary authentication scheme is set to JWT Bearer authentication, which will be used for authenticating users using JWT tokens.
/// If authentication fails, this specifies that the system should challenge the user by checking whether the token is valid or not.
/// </summary>
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
.AddJwtBearer(options =>
{ /// <summary>
  /// Specifies parameters for validating JWT tokens.
  /// </summary>
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
    /// <summary>
    /// Adds security definition for JWT authentication in Swagger UI.
    /// </summary>
    options.AddSecurityDefinition(name: JwtBearerDefaults.AuthenticationScheme, securityScheme: new OpenApiSecurityScheme
    {
        Name = "Authorization",
        Description = "Enter the Bearer token: `Bearer <Generated-JWT-Token>`",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer"
    });
    /// <summary>
    /// Adds security requirements to all API endpoints to enforce the use of JWT Bearer tokens.
    /// </summary>

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

// Add controllers and set JSON options
builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthentication();  // Add authentication middleware to validate JWT token
app.UseAuthorization();   // Add authorization middleware to check the user's permissions

app.MapControllers();

app.Run();

