using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace React.Models
{
    public class ReactContext : IdentityDbContext<ApplicationUser>
    {
      
    }
}