using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
using TodoApp.Core.Domain.Enum;
=======
>>>>>>> c90400b (feat(Registration): Added Registration API using ASP.NET Identity)
=======
using TodoApp.Core.Domain.Enum;
>>>>>>> 86a57ab (feat(auth): Add jwt based authentication)
=======

>>>>>>> 6af2c4c (feat(auth): implement authentication and authorization using jwt)
=======
<<<<<<< HEAD

>>>>>>> 6af2c4cf890176350c27058ed130352aecbf6b7c
=======
>>>>>>> 73d3215 (feat(Registration): Added Registration API using ASP.NET Identity)
<<<<<<< HEAD
>>>>>>> be0f8e4 (chore: Remove bin and obj folders from version control)
=======
=======
using TodoApp.Core.Domain.Enum;
>>>>>>> 5783ca4 (feat(auth): Add jwt based authentication)
>>>>>>> 0ac0018 (feat(auth): Add jwt based authentication)

namespace TodoApp.Core.DTO
{
    public class RegisterDTO
    {
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
        [Required(ErrorMessage = "Name can't be blank")]
=======
        [Required(ErrorMessage ="Name can't be blank")]
>>>>>>> c90400b (feat(Registration): Added Registration API using ASP.NET Identity)
=======
        [Required(ErrorMessage = "Name can't be blank")]
>>>>>>> 86a57ab (feat(auth): Add jwt based authentication)
=======
<<<<<<< HEAD
        [Required(ErrorMessage = "Name can't be blank")]
>>>>>>> 6af2c4cf890176350c27058ed130352aecbf6b7c
=======
        [Required(ErrorMessage ="Name can't be blank")]
>>>>>>> 73d3215 (feat(Registration): Added Registration API using ASP.NET Identity)
<<<<<<< HEAD
>>>>>>> be0f8e4 (chore: Remove bin and obj folders from version control)
=======
=======
        [Required(ErrorMessage = "Name can't be blank")]
>>>>>>> 5783ca4 (feat(auth): Add jwt based authentication)
>>>>>>> 0ac0018 (feat(auth): Add jwt based authentication)
        public string? Name { get; set; }

        [Required(ErrorMessage = "Email can't be blank")]
        [EmailAddress]
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> 6af2c4cf890176350c27058ed130352aecbf6b7c
        public string? Email { get; set; }

        [Required(ErrorMessage = "Password can't be blank")]
      
        public string? Password { get; set; }
        [Required(ErrorMessage = "ConfirmPassword can't be blank")]
   
        public string? ConfirmPassword { get; set; }
<<<<<<< HEAD
<<<<<<< HEAD
         public UserTypeOptions UserType { get; set; }
=======
        public string? Email {  get; set; }
=======
        public string? Email { get; set; }
>>>>>>> 86a57ab (feat(auth): Add jwt based authentication)

        [Required(ErrorMessage = "Password can't be blank")]
      
        public string? Password { get; set; }
        [Required(ErrorMessage = "ConfirmPassword can't be blank")]
<<<<<<< HEAD
        [DataType(DataType.Password)]
        public string? ConfirmPassword {  get; set; }
        
>>>>>>> c90400b (feat(Registration): Added Registration API using ASP.NET Identity)
=======
   
        public string? ConfirmPassword { get; set; }
         public UserTypeOptions UserType { get; set; }
>>>>>>> 86a57ab (feat(auth): Add jwt based authentication)
=======
        
>>>>>>> 6af2c4c (feat(auth): implement authentication and authorization using jwt)
=======
<<<<<<< HEAD
        
>>>>>>> 6af2c4cf890176350c27058ed130352aecbf6b7c
=======
        public string? Email {  get; set; }
=======
        public string? Email { get; set; }
>>>>>>> 5783ca4 (feat(auth): Add jwt based authentication)

        [Required(ErrorMessage = "Password can't be blank")]
      
        public string? Password { get; set; }
        [Required(ErrorMessage = "ConfirmPassword can't be blank")]
<<<<<<< HEAD
        [DataType(DataType.Password)]
        public string? ConfirmPassword {  get; set; }
        
>>>>>>> 73d3215 (feat(Registration): Added Registration API using ASP.NET Identity)
<<<<<<< HEAD
>>>>>>> be0f8e4 (chore: Remove bin and obj folders from version control)
=======
=======
   
        public string? ConfirmPassword { get; set; }
         public UserTypeOptions UserType { get; set; }
>>>>>>> 5783ca4 (feat(auth): Add jwt based authentication)
>>>>>>> 0ac0018 (feat(auth): Add jwt based authentication)
      
    }
}
