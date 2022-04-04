using System.Collections.Generic;

namespace React.Models
{
  public class Introduction
  {

    public Introduction( string userId )
    {
      UserId = userId;
    }

    public string UserId { get; set; }
    public int IntroductionId { get; set; }
    public bool Lesson1Complete { get; set; }
    public bool Lesson2Complete { get; set; }
    public bool Lesson3Complete { get; set; }
    public bool ModuleComplete { get; set; }
  }
}