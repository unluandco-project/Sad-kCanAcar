using System.ComponentModel.DataAnnotations;

namespace UnluCoProject.Models
{
    public class SignUpModel
    {
        [Required(ErrorMessage = "Enter the first name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Enter the last name")]
        public string LastName { get; set; }
        
        [Required(ErrorMessage = "Enter the e-mail"), EmailAddress(ErrorMessage = "Enter the valid e-mail")]
        public string Email { get; set; }
        
        [Required(ErrorMessage = "Enter the password")]
        [MinLength(8), MaxLength(20)]
        [Compare("ConfirmPassword")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        
        [Required(ErrorMessage = "Enter the password to confirm")]
        [MinLength(8), MaxLength(20)]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}
