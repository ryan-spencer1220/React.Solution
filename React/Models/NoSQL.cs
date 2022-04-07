using System.Collections.Generic;

namespace React.Models
{
  public class NoSQL
  {
    public NoSQL( string userId )
    {
      UserId = userId;
    }
    public int NoSQLId { get; set; }
    public string UserId { get; set; }
    public bool Lesson1Complete { get; set; }
    public bool Lesson2Complete { get; set; }
    public bool Lesson3Complete { get; set; }
    public bool Lesson4Complete { get; set; }
    public bool Lesson5Complete { get; set; }
    public bool Lesson6Complete { get; set; }
  }
}