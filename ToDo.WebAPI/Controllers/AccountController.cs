using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;
using TodoApp.Core.Domain.IdentityEntities;
using TodoApp.Core.DTO;

namespace todo.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        //business logic provided by asp.net core Identity
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly RoleManager<ApplicationRole> roleManager;

        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, RoleManager<ApplicationRole> roleManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.roleManager = roleManager;
        }

        [HttpPost]
        [Route("Register")]
        public async Task<IActionResult> Register([FromBody] RegisterDTO register)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if(register.Password != register.ConfirmPassword)
            {
                try
                {
                    throw new Exception("Password doesn't match with the confirmed password");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{ex}");
                }
            }

            var existingUser = await userManager.FindByEmailAsync(register.Email);
            if (existingUser != null)
            {
                return Conflict(new
                {
                    Message = "A user with this email already exists."
                });
            }
            //creating object for application user class
            var user = new ApplicationUser
            {
                UserName = register.Name,
                Email = register.Email,
                Name = register.Name
            };

            //creating the user
            var response = await userManager.CreateAsync(user, register.Password);
            //THIS REPRESENTS THE RESULT OF OPERATIONS SUCH AS CREATING UPDATING AND DELETING
            if (!response.Succeeded) {
                return BadRequest(new
                {
                    Message = "Registration failed."
                });
            }

            //sign the user in after sucessful registration
            await signInManager.SignInAsync(user, isPersistent: false);
            //isPersistent false huda chai current browser session chalda samma matra user loggedin hunxa ani true huda chai user remains logged in even after browser close garisakepaxi
            return Ok(new
            {
                Message = "Registration sucessful."
               
            });
           
        }
    }
}
