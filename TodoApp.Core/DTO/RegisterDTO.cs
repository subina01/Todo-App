using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



using TodoApp.Core.Domain.Enum;
=======
>>>>>>> c90400b (feat(Registration): Added Registration API using ASP.NET Identity)
=======
using TodoApp.Core.Domain.Enum;
>>>>>>> 86a57ab (feat(auth): Add jwt based authentication)
=======

>>>>>>> 6af2c4c (feat(auth): implement authentication and authorization using jwt)

namespace TodoApp.Core.DTO
{
        public class RegisterDTO
        {


                [Required(ErrorMessage = "Name can't be blank")]
=======
        [Required(ErrorMessage ="Name can't be blank")]
>>>>>>> c90400b (feat(Registration): Added Registration API using ASP.NET Identity)
=======
        [Required(ErrorMessage = "Name can't be blank")]
>>>>>>> 86a57ab (feat(auth): Add jwt based authentication)
                public string? Name { get; set; }

                [Required(ErrorMessage = "Email can't be blank")]
                [EmailAddress]


                public string? Email { get; set; }

                [Required(ErrorMessage = "Password can't be blank")]

                public string? Password { get; set; }
                [Required(ErrorMessage = "ConfirmPassword can't be blank")]

                public string? ConfirmPassword { get; set; }

                public UserTypeOptions UserType { get; set; }

=======
        public string? Email {  get; set; }
=======
        public string? Email { get; set; }
>>>>>>> 86a57ab (feat(auth): Add jwt based authentication)
                [Required(ErrorMessage = "Password can't be blank")]

                public string? Password { get; set; }
                [Required(ErrorMessage = "ConfirmPassword can't be blank")]

                [DataType(DataType.Password)]
                public string? ConfirmPassword { get; set; }
        
>>>>>>> c90400b(feat(Registration): Added Registration API using ASP.NET Identity)
=======
   
        public string? ConfirmPassword { get; set; }
         public UserTypeOptions UserType { get; set; }
>>>>>>> 86a57ab (feat(auth): Add jwt based authentication)
=======
        
>>>>>>> 6af2c4c (feat(auth): implement authentication and authorization using jwt)
      
    }
}
