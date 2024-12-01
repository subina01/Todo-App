


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





app.MapControllers();

app.Run();


app.UseAuthorization();

app.UseAuthentication();//for reading identity cookie
app.UseAuthorization();//validates access permission of the user

app.UseAuthorization();
and service registration)

app.MapControllers();

app.Run();
