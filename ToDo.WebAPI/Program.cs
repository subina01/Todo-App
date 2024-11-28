using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using Todo.Infrastructure.Database;
using Todo.Infrastructure.Services;
using TodoApp.Core.Domain.IdentityEntities;
using TodoApp.Core.Domain.Interface;
using TodoApp.Core.Domain.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnectionString")
    )
);

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



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthentication();//for reading identity cookie
app.UseAuthorization();//validates access permission of the user

app.MapControllers();

app.Run();
