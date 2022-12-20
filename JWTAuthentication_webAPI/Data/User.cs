using Microsoft.AspNetCore.Identity;

namespace JWTAuthentication_webAPI.Data
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
