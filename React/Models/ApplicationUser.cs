using Microsoft.AspNetCore.Identity;

namespace React.Models
{
    public class ApplicationUser : IdentityUser
    {
        // public int UserId { get; set; }
        public int IntroductionId { get; set; }
        public int ReduxId { get; set; }
        public int something { get; set; }
    }
}