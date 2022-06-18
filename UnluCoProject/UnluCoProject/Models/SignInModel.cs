using System.ComponentModel.DataAnnotations;

namespace UnluCoProject.Models
{
    public class SignInModel
    {
        [Required(ErrorMessage = "Enter the e-mail"), EmailAddress(ErrorMessage = "Enter a valid e-mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Enter the password")]
        [MinLength(8), MaxLength(20)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
