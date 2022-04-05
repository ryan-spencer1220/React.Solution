using Microsoft.AspNetCore.Identity;

namespace React.Models
{
  public class ApplicationUser : IdentityUser
  {
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public Introduction Introduction { get; set; }
    public void AddSections(Introduction intro)
    {
      this.Introduction = intro;
    }
  }
}