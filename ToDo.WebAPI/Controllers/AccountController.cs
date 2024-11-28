<<<<<<< HEAD
=======
<<<<<<< HEAD
<<<<<<< HEAD
>>>>>>> 7b60dfd (feat(auth): Add jwt based authentication)
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TodoApp.Core.Domain.IdentityEntities;
using TodoApp.Core.Domain.Interface;
<<<<<<< HEAD
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TodoApp.Core.Domain.IdentityEntities;


using TodoApp.Core.Domain.Interface;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TodoApp.Core.Domain.IdentityEntities;
using TodoApp.Core.Domain.Interface;
using Microsoft.AspNetCore.Http;
sing Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TodoApp.Core.Domain.IdentityEntities;
using TodoApp.Core.DTO;

namespace todo.WebAPI.Controllers
{
    [Route("api/")]
    [ApiController]
  {
   [Route("api/[controller]")]
    [Route("api/")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        [Route("api/[controller]")]
        [ApiController]
        public class AccountController : ControllerBase
        {

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
            private readonly UserManager<ApplicationUser> userManager;
            private readonly SignInManager<ApplicationUser> signInManager;
            private readonly RoleManager<ApplicationRole> roleManager;
            private readonly IJwtService jwtService;

            public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, RoleManager<ApplicationRole> roleManager, IJwtService jwtService)
          //business logic provided by asp.net core Identity
        private readonly UserManager<ApplicationUser> userManager;
            private readonly SignInManager<ApplicationUser> signInManager;
            private readonly RoleManager<ApplicationRole> roleManager;

            public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, RoleManager<ApplicationRole> roleManager)
            {
                this.userManager = userManager;
                this.signInManager = signInManager;
                this.roleManager = roleManager;
                this.jwtService = jwtService;
            }

            [HttpPost]
            [HttpPost("register")]
            [HttpPost]
            [Route("register")]
            private readonly SignInManager<ApplicationUser> signInManager;
            private readonly RoleManager<ApplicationRole> roleManager;
            private readonly IJwtService jwtService;

            public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, RoleManager<ApplicationRole> roleManager)
       public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, RoleManager<ApplicationRole> roleManager, IJwtService jwtService)
            {
                this.userManager = userManager;
                this.signInManager = signInManager;
                this.jwtService = jwtService;
            }

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
                if (register.Password != register.ConfirmPassword)
                {
                    return BadRequest("Password doesn't match with the confirmed password");

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
                    ApplicationUser user = new ApplicationUser
                    {
                        UserName = register.Name,
                        Email = register.Email,
                        Name = register.Name,
                        var user = new ApplicationUser
                 // Creating the user
            var response = await userManager.CreateAsync(user, register.Password);

                        // This represents the result of operations such as creating, updating, and deleting
                        var user = new ApplicationUser
                        {
                            UserName = register.Name,
                            Email = register.Email,
                            Name = register.Name
                        };

                        var response = await userManager.CreateAsync(user, register.Password);
          if (!response.Succeeded)
                    {
                        //creating the user
                        var response = await userManager.CreateAsync(user, register.Password);
                        //THIS REPRESENTS THE RESULT OF OPERATIONS SUCH AS CREATING UPDATING AND DELETING
                        if (!response.Succeeded)
                        {
                            return BadRequest(new
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
                            var user = new ApplicationUser
                            {
                                UserName = register.Name,
                                Email = register.Email,
                                Name = register.Name
                            };

                            var response = await userManager.CreateAsync(user, register.Password);
\           if (!response.Succeeded)
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
                            await signInManager.SignInAsync(user, isPersistent: false);
                            var authenticationResponse = jwtService.CreateJwtToken(user);

                            // isPersistent false means the user will be logged in only for the current browser session, and true means the user remains logged in even after the browser is closed

                            await signInManager.SignInAsync(user, isPersistent: false);
                            var authenticationResponse = jwtService.CreateJwtToken(user);

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


                    //sign the user in after sucessful registration
                    await signInManager.SignInAsync(user, isPersistent: false);
                    //isPersistent false huda chai current browser session chalda samma matra user loggedin hunxa ani true huda chai user remains logged in even after browser close garisakepaxi
                    return Ok(new
                    {
                        Message = "Registration sucessful."

                    });

                }
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

                return Ok(new
                {
                    Message = "Login sucessful"
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
            var response = await userManager.CreateAsync(user, register.Password);

            // This represents the result of operations such as creating, updating, and deleting
            if (!response.Succeeded)
                var response = await userManager.CreateAsync(user, register.Password);
            //THIS REPRESENTS THE RESULT OF OPERATIONS SUCH AS CREATING UPDATING AND DELETING
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
            var authenticationResponse = jwtService.CreateJwtToken(user);
            //isPersistent false huda chai current browser session chalda samma matra user loggedin hunxa ani true huda chai user remains logged in even after browser close garisakepaxi
            return Ok(authenticationResponse);
           
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


>>>>>>> 7b60dfd(feat(auth): Add jwt based authentication)
        }

    }
