using System.ComponentModel.DataAnnotations;
namespace simple_login_registration_version_one.Models
{
    public class UserLogin
    {
        [Required]
        [EmailAddress]
        [Display (Name = "Email")]
        public string LoginEmail { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string LoginPassword { get; set; }
    
    }
}