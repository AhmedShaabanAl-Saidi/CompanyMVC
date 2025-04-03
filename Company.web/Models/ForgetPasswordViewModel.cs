using System.ComponentModel.DataAnnotations;

namespace Company.web.Models
{
    public class ForgetPasswordViewModel
    {
        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        public string Email { get; set; }
    }
}
