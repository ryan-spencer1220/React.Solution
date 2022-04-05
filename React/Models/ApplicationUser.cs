using Microsoft.AspNetCore.Identity;

namespace React.Models
{
  public class ApplicationUser : IdentityUser
  {
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int IntroductionId { get; set; }
    public int FundamentalsOneId { get; set; }
    public int FundamentalsTwoId { get; set; }
    public int ReduxId { get; set; }
    public int NoSQLId { get; set; }
    public int ApiId { get; set; }

    public void AddIds(int introId, int fundOne, int fundTwo, int reduxId, int noSQLId, int apiId)
    {
      IntroductionId = introId;
      FundamentalsOneId = fundOne;
      FundamentalsTwoId = fundTwo;
      ReduxId = reduxId;
      NoSQLId = noSQLId;
      ApiId = apiId;
    }
  }
}