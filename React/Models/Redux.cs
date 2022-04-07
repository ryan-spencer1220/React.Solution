using System.Collections.Generic;

namespace React.Models
{
  public class Redux
  {
    public Redux( string userId )
    {
      UserId = userId;
    }
    public int ReduxId { get; set; }
    public string UserId { get; set; }
    public bool Lesson1Complete { get; set; }
    public bool Lesson2Complete { get; set; }
    public bool Lesson3Complete { get; set; }
    public bool Lesson4Complete { get; set; }
    public bool Lesson5Complete { get; set; }
    public bool Lesson6Complete { get; set; }
    public bool Lesson7Complete { get; set; }
  }
}