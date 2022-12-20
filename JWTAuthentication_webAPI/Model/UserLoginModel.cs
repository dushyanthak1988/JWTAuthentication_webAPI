using System.ComponentModel.DataAnnotations;

namespace JWTAuthentication_webAPI.Model
{
    public class UserLoginModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
