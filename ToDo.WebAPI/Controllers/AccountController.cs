<<<<<<< HEAD
using Microsoft.AspNetCore.Authorization;
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
>>>>>>> 73d3215 (feat(Registration): Added Registration API using ASP.NET Identity)
using TodoApp.Core.DTO;

namespace todo.WebAPI.Controllers
{
<<<<<<< HEAD
<<<<<<< HEAD
    [Route("api/")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        // Business logic provided by ASP.NET Core Identity
=======
    [Route("api/[controller]")]
=======
    [Route("api/")]
>>>>>>> 25050fb (feat(login): Add login functionality and its DTO)
    [ApiController]
    public class AccountController : ControllerBase
    {
<<<<<<< HEAD
>>>>>>> 78b8029 (refactor: updated sln file with updatedfeatures)
=======
<<<<<<< HEAD
>>>>>>> be0f8e4 (chore: Remove bin and obj folders from version control)
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly RoleManager<ApplicationRole> roleManager;
        private readonly IJwtService jwtService;

        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, RoleManager<ApplicationRole> roleManager, IJwtService jwtService)
=======
        //business logic provided by asp.net core Identity
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly RoleManager<ApplicationRole> roleManager;

        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, RoleManager<ApplicationRole> roleManager)
>>>>>>> 73d3215 (feat(Registration): Added Registration API using ASP.NET Identity)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.roleManager = roleManager;
<<<<<<< HEAD
            this.jwtService = jwtService;
        }

<<<<<<< HEAD
        [HttpPost("register")]
=======
        [HttpPost]
        [Route("register")]
<<<<<<< HEAD
>>>>>>> 78b8029 (refactor: updated sln file with updatedfeatures)
=======
=======
        }

        [HttpPost]
<<<<<<< HEAD
        [Route("Register")]
>>>>>>> 73d3215 (feat(Registration): Added Registration API using ASP.NET Identity)
<<<<<<< HEAD
>>>>>>> be0f8e4 (chore: Remove bin and obj folders from version control)
=======
=======
        [Route("register")]
>>>>>>> eb11733 (feat(login): Add login functionality and its DTO)
>>>>>>> 25050fb (feat(login): Add login functionality and its DTO)
        public async Task<IActionResult> Register([FromBody] RegisterDTO register)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
<<<<<<< HEAD
<<<<<<< HEAD

=======
>>>>>>> 78b8029 (refactor: updated sln file with updatedfeatures)
=======
>>>>>>> be0f8e4 (chore: Remove bin and obj folders from version control)
            if (register.Password != register.ConfirmPassword)
            {
                return BadRequest("Password doesn't match with the confirmed password");
=======
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
>>>>>>> 73d3215 (feat(Registration): Added Registration API using ASP.NET Identity)
            }

            var existingUser = await userManager.FindByEmailAsync(register.Email);
            if (existingUser != null)
            {
                return Conflict(new
                {
                    Message = "A user with this email already exists."
                });
            }
<<<<<<< HEAD

<<<<<<< HEAD
<<<<<<< HEAD
            // Creating object for application user class
            ApplicationUser user = new ApplicationUser
            {
                UserName = register.Name,
                Email = register.Email,
                Name = register.Name,
            };

            // Creating the user
            var response = await userManager.CreateAsync(user, register.Password);

            // This represents the result of operations such as creating, updating, and deleting
=======
=======
=======
            //creating object for application user class
>>>>>>> 73d3215 (feat(Registration): Added Registration API using ASP.NET Identity)
>>>>>>> be0f8e4 (chore: Remove bin and obj folders from version control)
            var user = new ApplicationUser
            {
                UserName = register.Name,
                Email = register.Email,
                Name = register.Name
            };

<<<<<<< HEAD
            var response = await userManager.CreateAsync(user, register.Password);
>>>>>>> 78b8029 (refactor: updated sln file with updatedfeatures)
            if (!response.Succeeded)
            {
=======
            //creating the user
            var response = await userManager.CreateAsync(user, register.Password);
            //THIS REPRESENTS THE RESULT OF OPERATIONS SUCH AS CREATING UPDATING AND DELETING
            if (!response.Succeeded) {
>>>>>>> 73d3215 (feat(Registration): Added Registration API using ASP.NET Identity)
                return BadRequest(new
                {
                    Message = "Registration failed."
                });
            }

<<<<<<< HEAD
<<<<<<< HEAD
            // Sign the user in after successful registration
=======
>>>>>>> be0f8e4 (chore: Remove bin and obj folders from version control)
            await signInManager.SignInAsync(user, isPersistent: false);
            var authenticationResponse = jwtService.CreateJwtToken(user);

            // isPersistent false means the user will be logged in only for the current browser session, and true means the user remains logged in even after the browser is closed
=======
            await signInManager.SignInAsync(user, isPersistent: false);
            var authenticationResponse = jwtService.CreateJwtToken(user);
>>>>>>> 78b8029 (refactor: updated sln file with updatedfeatures)
            return Ok(authenticationResponse);
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginDTO login)
        {
            var user = await userManager.FindByNameAsync(login.UserName);
            if (user == null)
            {
                return BadRequest("User is not registered");
            }
<<<<<<< HEAD

=======
>>>>>>> 78b8029 (refactor: updated sln file with updatedfeatures)
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
=======
            //sign the user in after sucessful registration
            await signInManager.SignInAsync(user, isPersistent: false);
            //isPersistent false huda chai current browser session chalda samma matra user loggedin hunxa ani true huda chai user remains logged in even after browser close garisakepaxi
            return Ok(new
            {
                Message = "Registration sucessful."
               
            });
           
>>>>>>> 73d3215 (feat(Registration): Added Registration API using ASP.NET Identity)
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

            return Ok(new
            {
                Message = "Login sucessful"
            });
        }
    }
}
