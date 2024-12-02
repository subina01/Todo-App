<<<<<<< HEAD
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
using TodoApp.Core.Services;
using TodoApp.Infrastructure.Database;
using TodoApp.Infrastructure.Repository;
using TodoApp.Infrastructure.Map;
=======
using Microsoft.EntityFrameworkCore;
using Todo.Infrastructure.Database;
using Todo.Infrastructure.Services;
using TodoApp.Core.Domain.Interface;
>>>>>>> d1de45d (refactor(controller): update controller methods to integrate request and response DTOs)

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
<<<<<<< HEAD
=======


>>>>>>> d1de45d (refactor(controller): update controller methods to integrate request and response DTOs)
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnectionString")
    )
<<<<<<< HEAD
); builder.Services.AddAutoMapper(typeof(MappingProfile));

builder.Services.AddScoped<ITodoServices, TodoRepository>();
builder.Services.AddTransient<IJwtService, JwtService>();
//enable identity in this project
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
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.AddSecurityDefinition(name: JwtBearerDefaults.AuthenticationScheme, securityScheme: new Microsoft.OpenApi.Models.OpenApiSecurityScheme
    {
        Name = "Authorization",
        Description = "Enter the Bearer Authorization : `Bearer Genreated-JWT-Token`",
        In = Microsoft.OpenApi.Models.ParameterLocation.Header,
        Type = Microsoft.OpenApi.Models.SecuritySchemeType.ApiKey,
        Scheme = "Bearer"
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

=======
);

builder.Services.AddScoped<ITodoServices, TodoRepository>();

builder.Services.AddRazorPages();


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
>>>>>>> d1de45d (refactor(controller): update controller methods to integrate request and response DTOs)

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

<<<<<<< HEAD
app.UseAuthentication();//for reading identity cookie
app.UseAuthorization();//validates access permission of the user


app.MapControllers();

app.Run();
=======
app.UseAuthorization();

app.MapControllers();

app.Run();
>>>>>>> d1de45d (refactor(controller): update controller methods to integrate request and response DTOs)
