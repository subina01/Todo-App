using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TodoApp.Core.Domain.IdentityEntities;
using TodoApp.Core.Domain.Interface;
using TodoApp.Core.DTO;

namespace Todo.WebApi.Controllers
{
    [Route("api/")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        // Business logic provided by ASP.NET Core Identity
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly RoleManager<ApplicationRole> _roleManager;
        private readonly IJwtService _jwtService;

        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, RoleManager<ApplicationRole> roleManager, IJwtService jwtService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _jwtService = jwtService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterDTO register)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (register.Password != register.ConfirmPassword)
            {
                return BadRequest("Password doesn't match with the confirmed password");
            }

            var existingUser = await _userManager.FindByEmailAsync(register.Email);
            if (existingUser != null)
            {
                return Conflict(new
                {
                    Message = "A user with this email already exists."
                });
            }

            // Creating object for application user class
            ApplicationUser user = new ApplicationUser
            {
                UserName = register.Name,
                Email = register.Email,
                Name = register.Name,
            };

            // Creating the user
            var response = await _userManager.CreateAsync(user, register.Password);

            // This represents the result of operations such as creating, updating, and deleting
            if (!response.Succeeded)
            {
                return BadRequest(new
                {
                    Message = "Registration failed."
                });
            }

            // Sign the user in after successful registration
            await _signInManager.SignInAsync(user, isPersistent: false);
            var authenticationResponse = _jwtService.CreateJwtToken(user);

            // isPersistent false means the user will be logged in only for the current browser session, and true means the user remains logged in even after the browser is closed
            return Ok(authenticationResponse);
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginDTO login)
        {
            var user = await _userManager.FindByNameAsync(login.UserName);
            if (user == null)
            {
                return BadRequest("User is not registered");
            }
            var response = await signInManager.PasswordSignInAsync(user, login.Password, false, false);
            if (!response.Succeeded)
            {
                return BadRequest(new
                {
                    return BadRequest(new
                    {
                        Message = "Login failed."
                    });
            }

            var authenticationResponse = _jwtService.CreateJwtToken(user);

            return Ok(authenticationResponse);
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

            var authenticationResponse = _jwtService.CreateJwtToken(user);

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
    }
}


