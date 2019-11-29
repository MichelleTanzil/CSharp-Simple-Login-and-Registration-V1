using System.ComponentModel.DataAnnotations;
using simple_login_registration_version_one.Models;
namespace simple_login_registration_version_one
{
    public class ConfirmPasswordAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var user = (UserRegistration)validationContext.ObjectInstance;
            if (user.Password != user.ConfirmPassword)
            {
                return new ValidationResult("Passwords must match!");
            }
            return ValidationResult.Success;
        }
    }
}