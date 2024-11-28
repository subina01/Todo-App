

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TodoApp.Core.Domain.IdentityEntities;
using TodoApp.Core.Domain.Interface;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TodoApp.Core.Domain.IdentityEntities;


using TodoApp.Core.Domain.Interface;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TodoApp.Core.Domain.IdentityEntities;
using TodoApp.Core.Domain.Interface;
using TodoApp.Core.DTO;

namespace todo.WebAPI.Controllers
{



    [Route("api/")]
    [ApiController]
    [AllowAnonymous]

    [Route("api/[controller]")]

    [Route("api/")]

    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        //business logic provided by asp.net core Identity
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly RoleManager<ApplicationRole> roleManager;
        private readonly IJwtService jwtService;

        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, RoleManager<ApplicationRole> roleManager, IJwtService jwtService)

        private readonly IJwtService jwtService;

        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, RoleManager<ApplicationRole> roleManager, IJwtService jwtService)
      public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, RoleManager<ApplicationRole> roleManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.roleManager = roleManager;


            this.jwtService = jwtService;
        }

        [HttpPost]
        [Route("register")]


        [HttpPost]

        [Route("Register")]
        [Route("register")]
       }

        [HttpPost]
        [Route("Register")]

        public async Task<IActionResult> Register([FromBody] RegisterDTO register)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (register.Password != register.ConfirmPassword)
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


            ApplicationUser user = new ApplicationUser
            {
                UserName = register.Name,
                Email = register.Email,
                Name = register.Name,

                var user = new ApplicationUser
                {
                    UserName = register.Name,
                    Email = register.Email,
                    Name = register.Name
          ApplicationUser user = new ApplicationUser
          {
              UserName = register.Name,
              Email = register.Email,
              Name = register.Name,

          };

                    //creating the user
                    var response = await userManager.CreateAsync(user, register.Password);
            //THIS REPRESENTS THE RESULT OF OPERATIONS SUCH AS CREATING UPDATING AND DELETING
            if (!response.Succeeded)
            {
                var user = new ApplicationUser
                {
                    UserName = register.Name,
                    Email = register.Email,
                    Name = register.Name
                };

                //creating the user
                var response = await userManager.CreateAsync(user, register.Password);
                //THIS REPRESENTS THE RESULT OF OPERATIONS SUCH AS CREATING UPDATING AND DELETING
                if (!response.Succeeded)
                {
                    return BadRequest(new
                    {
                        Message = "Registration failed."
                    });
                }










                //sign the user in after sucessful registration
                await signInManager.SignInAsync(user, isPersistent: false);
                var authenticationResponse = jwtService.CreateJwtToken(user);
                //isPersistent false huda chai current browser session chalda samma matra user loggedin hunxa ani true huda chai user remains logged in even after browser close garisakepaxi
                return Ok(authenticationResponse);
            }




            [HttpPost]
            [Route("login")]
            public async Task<IActionResult> Login([FromBody] LoginDTO login)
            {
                var user = await userManager.FindByNameAsync(login.UserName);
                if (user == null)
                {
                    return BadRequest("User is not registered");
                }
                var response = await signInManager.PasswordSignInAsync(user, login.Password, false, false);
                if (!response.Succeeded)
                {
                    return BadRequest(new
                    {
                        Message = "Login failed."
                    });

                }

                var authenticationResponse = jwtService.CreateJwtToken(user);

                return Ok(authenticationResponse);


            }


            //sign the user in after sucessful registration
            await signInManager.SignInAsync(user, isPersistent: false);
            var authenticationResponse = jwtService.CreateJwtToken(user);
            //isPersistent false huda chai current browser session chalda samma matra user loggedin hunxa ani true huda chai user remains logged in even after browser close garisakepaxi
            return Ok(authenticationResponse);
        }

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login([FromBody] LoginDTO login)
        {
            var user = await userManager.FindByNameAsync(login.UserName);
            if (user == null)
            {
                return BadRequest("User is not registered");
            }
            var response = await signInManager.PasswordSignInAsync(user, login.Password, false, false);
            if (!response.Succeeded)
            {
                return BadRequest(new
                {
                    Message = "Login failed."
                });

            }

            var authenticationResponse = jwtService.CreateJwtToken(user);

            return Ok(authenticationResponse);


        }


        //sign the user in after sucessful registration
        await signInManager.SignInAsync(user, isPersistent: false);
//isPersistent false huda chai current browser session chalda samma matra user loggedin hunxa ani true huda chai user remains logged in even after browser close garisakepaxi
return Ok(new
{
    Message = "Registration sucessful."

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
