<<<<<<< HEAD
﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TodoApp.Core.Domain.IdentityEntities;
using TodoApp.Core.Domain.Interface;
=======
﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;
using TodoApp.Core.Domain.IdentityEntities;
>>>>>>> c90400b (feat(Registration): Added Registration API using ASP.NET Identity)
using TodoApp.Core.DTO;

namespace todo.WebAPI.Controllers
{
<<<<<<< HEAD
    [Route("api/")]
    [ApiController]
    [AllowAnonymous]
=======
    [Route("api/[controller]")]
    [ApiController]
>>>>>>> c90400b (feat(Registration): Added Registration API using ASP.NET Identity)
    public class AccountController : ControllerBase
    {
        //business logic provided by asp.net core Identity
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly RoleManager<ApplicationRole> roleManager;
<<<<<<< HEAD
        private readonly IJwtService jwtService;

        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, RoleManager<ApplicationRole> roleManager, IJwtService jwtService)
=======

        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, RoleManager<ApplicationRole> roleManager)
>>>>>>> c90400b (feat(Registration): Added Registration API using ASP.NET Identity)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.roleManager = roleManager;
<<<<<<< HEAD
            this.jwtService = jwtService;
        }

        [HttpPost]
        [Route("register")]
=======
        }

        [HttpPost]
        [Route("Register")]
>>>>>>> c90400b (feat(Registration): Added Registration API using ASP.NET Identity)
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
<<<<<<< HEAD
            ApplicationUser user = new ApplicationUser
            {
                UserName = register.Name,
                Email = register.Email,
                Name = register.Name,
                
=======
            var user = new ApplicationUser
            {
                UserName = register.Name,
                Email = register.Email,
                Name = register.Name
>>>>>>> c90400b (feat(Registration): Added Registration API using ASP.NET Identity)
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
<<<<<<< HEAD
            

            

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
            var response = await signInManager.PasswordSignInAsync(user, login.Password,false, false);
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
       
=======

            //sign the user in after sucessful registration
            await signInManager.SignInAsync(user, isPersistent: false);
            //isPersistent false huda chai current browser session chalda samma matra user loggedin hunxa ani true huda chai user remains logged in even after browser close garisakepaxi
            return Ok(new
            {
                Message = "Registration sucessful."
               
            });
           
        }
>>>>>>> c90400b (feat(Registration): Added Registration API using ASP.NET Identity)
    }
}
