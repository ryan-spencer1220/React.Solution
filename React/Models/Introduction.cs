using System.Collections.Generic;

namespace React.Models
{
  public class Introduction
  {
    public int ModuleId { get; set; }
    public bool Lesson1Complete { get; set; }
    public bool Lesson2Complete { get; set; }
    public bool Lesson3Complete { get; set; }
    public bool ModuleComplete { get; set; }
    public virtual ApplicationUser User { get; set; }
  }
}