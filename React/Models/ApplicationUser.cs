using Microsoft.AspNetCore.Identity;

namespace React.Models
{
  public class ApplicationUser : IdentityUser
  {
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public Introduction Introduction { get; set; }
    public Redux Redux { get; set; }
    public Api Api { get; set; }
    public void AddSections(Introduction intro, Redux redux, Api api)
    {
      this.Introduction = intro;
      this.Redux = redux;
      this.Api = api;
    }
  }
}

// namespace React.Models
// {
//   public class ApplicationUser : IdentityUser
//   {
//     public string FirstName { get; set; }
//     public string LastName { get; set; }
//     public Introduction Introduction { get; set; }
//     public void AddSections(Introduction intro)
//     {
//       this.Introduction = intro;
//     }
//   }
// }