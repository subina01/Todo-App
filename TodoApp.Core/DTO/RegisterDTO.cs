using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp.Core.DTO
{
        public class RegisterDTO
        {
                [Required(ErrorMessage = "Name can't be blank")]
                public string? Name { get; set; }

                [Required(ErrorMessage = "Email can't be blank")]
                [EmailAddress]
                public string? Email { get; set; }

                [Required(ErrorMessage = "Password can't be blank")]
                public string? Password { get; set; }

                [Required(ErrorMessage = "ConfirmPassword can't be blank")]
                public string? ConfirmPassword { get; set; }
        }
}