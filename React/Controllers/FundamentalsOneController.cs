using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using React.Models;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace React.Controllers
{
  public class FundamentalsOneController : Controller
  {
    private readonly ReactContext _db;
    private readonly UserManager<ApplicationUser> _userManager;
    public FundamentalsOneController(UserManager<ApplicationUser> userManager, ReactContext db)
    {
      _userManager = userManager;
      _db = db;
    }

    public async Task<ActionResult> Lesson1()
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);
      FundamentalsOne fundamentalsOne = _db.FundamentalsOnes.FirstOrDefault(a => a.UserId == userId );
      ViewBag.IsComplete = fundamentalsOne.Lesson1Complete;
      return View();
    }

    [HttpPost, ActionName("Lesson1")]
    public async Task<ActionResult> LessonOne()
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);
      FundamentalsOne fundamentalsOne = _db.FundamentalsOnes.FirstOrDefault(a => a.UserId == userId );
      if (fundamentalsOne.Lesson1Complete == true)
      {
        fundamentalsOne.Lesson1Complete = false;
      } 
      else if (fundamentalsOne.Lesson1Complete == false)
      {
        fundamentalsOne.Lesson1Complete = true;
      }
      _db.Entry(fundamentalsOne).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction();
    }

    public async Task<ActionResult> Lesson2()
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);
      FundamentalsOne fundamentalsOne = _db.FundamentalsOnes.FirstOrDefault(a => a.UserId == userId );
      ViewBag.IsComplete = fundamentalsOne.Lesson2Complete;
      return View();
    }

    [HttpPost, ActionName("Lesson2")]
    public async Task<ActionResult> LessonTwo()
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);
      FundamentalsOne fundamentalsOne = _db.FundamentalsOnes.FirstOrDefault(a => a.UserId == userId );
      if (fundamentalsOne.Lesson2Complete == true)
      {
        fundamentalsOne.Lesson2Complete = false;
      } 
      else if (fundamentalsOne.Lesson2Complete == false)
      {
        fundamentalsOne.Lesson2Complete = true;
      }
      _db.Entry(fundamentalsOne).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction();
    }

    public async Task<ActionResult> Lesson3()
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);
      FundamentalsOne fundamentalsOne = _db.FundamentalsOnes.FirstOrDefault(a => a.UserId == userId );
      ViewBag.IsComplete = fundamentalsOne.Lesson3Complete;
      return View();
    }

    [HttpPost, ActionName("Lesson3")]
    public async Task<ActionResult> LessonThree()
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);
      FundamentalsOne fundamentalsOne = _db.FundamentalsOnes.FirstOrDefault(a => a.UserId == userId );
      if (fundamentalsOne.Lesson3Complete == true)
      {
        fundamentalsOne.Lesson3Complete = false;
      } 
      else if (fundamentalsOne.Lesson3Complete == false)
      {
        fundamentalsOne.Lesson3Complete = true;
      }
      _db.Entry(fundamentalsOne).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction();
    }

    public async Task<ActionResult> Lesson4()
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);
      FundamentalsOne fundamentalsOne = _db.FundamentalsOnes.FirstOrDefault(a => a.UserId == userId );
      ViewBag.IsComplete = fundamentalsOne.Lesson4Complete;
      return View();
    }

    [HttpPost, ActionName("Lesson4")]
    public async Task<ActionResult> LessonFour()
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);
      FundamentalsOne fundamentalsOne = _db.FundamentalsOnes.FirstOrDefault(a => a.UserId == userId );
      if (fundamentalsOne.Lesson4Complete == true)
      {
        fundamentalsOne.Lesson4Complete = false;
      } 
      else if (fundamentalsOne.Lesson4Complete == false)
      {
        fundamentalsOne.Lesson4Complete = true;
      }
      _db.Entry(fundamentalsOne).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction();
    }

    public async Task<ActionResult> Lesson5()
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);
      FundamentalsOne fundamentalsOne = _db.FundamentalsOnes.FirstOrDefault(a => a.UserId == userId );
      ViewBag.IsComplete = fundamentalsOne.Lesson5Complete;
      return View();
    }

    [HttpPost, ActionName("Lesson5")]
    public async Task<ActionResult> LessonFive()
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);
      FundamentalsOne fundamentalsOne = _db.FundamentalsOnes.FirstOrDefault(a => a.UserId == userId );
      if (fundamentalsOne.Lesson5Complete == true)
      {
        fundamentalsOne.Lesson5Complete = false;
      } 
      else if (fundamentalsOne.Lesson5Complete == false)
      {
        fundamentalsOne.Lesson5Complete = true;
      }
      _db.Entry(fundamentalsOne).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction();
    }

    public async Task<ActionResult> Lesson6()
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);
      FundamentalsOne fundamentalsOne = _db.FundamentalsOnes.FirstOrDefault(a => a.UserId == userId );
      ViewBag.IsComplete = fundamentalsOne.Lesson6Complete;
      return View();
    }

    [HttpPost, ActionName("Lesson6")]
    public async Task<ActionResult> LessonSix()
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);
      FundamentalsOne fundamentalsOne = _db.FundamentalsOnes.FirstOrDefault(a => a.UserId == userId );
      if (fundamentalsOne.Lesson6Complete == true)
      {
        fundamentalsOne.Lesson6Complete = false;
      } 
      else if (fundamentalsOne.Lesson6Complete == false)
      {
        fundamentalsOne.Lesson6Complete = true;
      }
      _db.Entry(fundamentalsOne).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction();
    }

    public async Task<ActionResult> Lesson7()
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);
      FundamentalsOne fundamentalsOne = _db.FundamentalsOnes.FirstOrDefault(a => a.UserId == userId );
      ViewBag.IsComplete = fundamentalsOne.Lesson7Complete;
      return View();
    }

    [HttpPost, ActionName("Lesson7")]
    public async Task<ActionResult> LessonSeven()
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);
      FundamentalsOne fundamentalsOne = _db.FundamentalsOnes.FirstOrDefault(a => a.UserId == userId );
      if (fundamentalsOne.Lesson7Complete == true)
      {
        fundamentalsOne.Lesson7Complete = false;
      } 
      else if (fundamentalsOne.Lesson7Complete == false)
      {
        fundamentalsOne.Lesson7Complete = true;
      }
      _db.Entry(fundamentalsOne).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction();
    }
  }
}