using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using React.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;

namespace React.Controllers
{
  public class FundamentalsTwoController : Controller
  {
    private readonly ReactContext _db;
    private readonly UserManager<ApplicationUser> _userManager;
    public FundamentalsTwoController(UserManager<ApplicationUser> userManager, ReactContext db)
    {
      _userManager = userManager;
      _db = db;
    }

    public async Task<ActionResult> Lesson1()
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);

      FundamentalsTwo fundamentalsTwo = _db.FundamentalsTwos.FirstOrDefault(a => a.UserId == userId );
      ViewBag.IsComplete = fundamentalsTwo.Lesson1Complete;
      return View();
    }

    public async Task<ActionResult> Lesson2()
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);

      FundamentalsTwo fundamentalsTwo = _db.FundamentalsTwos.FirstOrDefault(a => a.UserId == userId );
      ViewBag.IsComplete = fundamentalsTwo.Lesson2Complete;
      return View();
    }

    public async Task<ActionResult> Lesson3()
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);

      FundamentalsTwo fundamentalsTwo = _db.FundamentalsTwos.FirstOrDefault(a => a.UserId == userId );
      ViewBag.IsComplete = fundamentalsTwo.Lesson3Complete;
      return View();
    }

    public async Task<ActionResult> Lesson4()
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);

      FundamentalsTwo fundamentalsTwo = _db.FundamentalsTwos.FirstOrDefault(a => a.UserId == userId );
      ViewBag.IsComplete = fundamentalsTwo.Lesson4Complete;
      return View();
    }

    public async Task<ActionResult> Lesson5()
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);

      FundamentalsTwo fundamentalsTwo = _db.FundamentalsTwos.FirstOrDefault(a => a.UserId == userId );
      ViewBag.IsComplete = fundamentalsTwo.Lesson5Complete;
      return View();
    }

    public async Task<ActionResult> Lesson6()
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);

      FundamentalsTwo fundamentalsTwo = _db.FundamentalsTwos.FirstOrDefault(a => a.UserId == userId );
      ViewBag.IsComplete = fundamentalsTwo.Lesson6Complete;
      return View();
    }

    public async Task<ActionResult> Lesson7()
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);

      FundamentalsTwo fundamentalsTwo = _db.FundamentalsTwos.FirstOrDefault(a => a.UserId == userId );
      ViewBag.IsComplete = fundamentalsTwo.Lesson7Complete;
      return View();
    }

    [HttpPost, ActionName("Lesson1")]
    public async Task<ActionResult> LessonOne()
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);

      FundamentalsTwo fundamentalsTwo = _db.FundamentalsTwos.FirstOrDefault(a => a.UserId == userId );
      if (fundamentalsTwo.Lesson1Complete == true)
      {
        fundamentalsTwo.Lesson1Complete = false;
      } else if (fundamentalsTwo.Lesson1Complete == false)
      {
      fundamentalsTwo.Lesson1Complete = true;
      }
      _db.Entry(fundamentalsTwo).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction();
    }

    [HttpPost, ActionName("Lesson2")]
    public async Task<ActionResult> LessonTwo()
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);

      FundamentalsTwo fundamentalsTwo = _db.FundamentalsTwos.FirstOrDefault(a => a.UserId == userId );
      if (fundamentalsTwo.Lesson2Complete == true)
      {
        fundamentalsTwo.Lesson2Complete = false;
      } else if (fundamentalsTwo.Lesson2Complete == false)
      {
      fundamentalsTwo.Lesson2Complete = true;
      }
      _db.Entry(fundamentalsTwo).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction();
    }

    [HttpPost, ActionName("Lesson3")]
    public async Task<ActionResult> LessonThree()
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);

      FundamentalsTwo fundamentalsTwo = _db.FundamentalsTwos.FirstOrDefault(a => a.UserId == userId );
      if (fundamentalsTwo.Lesson3Complete == true)
      {
        fundamentalsTwo.Lesson3Complete = false;
      } else if (fundamentalsTwo.Lesson3Complete == false)
      {
      fundamentalsTwo.Lesson3Complete = true;
      }
      _db.Entry(fundamentalsTwo).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction();
    }

    [HttpPost, ActionName("Lesson4")]
    public async Task<ActionResult> LessonFour()
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);

      FundamentalsTwo fundamentalsTwo = _db.FundamentalsTwos.FirstOrDefault(a => a.UserId == userId );
      if (fundamentalsTwo.Lesson4Complete == true)
      {
        fundamentalsTwo.Lesson4Complete = false;
      } else if (fundamentalsTwo.Lesson4Complete == false)
      {
      fundamentalsTwo.Lesson4Complete = true;
      }
      _db.Entry(fundamentalsTwo).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction();
    }

    [HttpPost, ActionName("Lesson5")]
    public async Task<ActionResult> LessonFive()
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);

      FundamentalsTwo fundamentalsTwo = _db.FundamentalsTwos.FirstOrDefault(a => a.UserId == userId );
      if (fundamentalsTwo.Lesson5Complete == true)
      {
        fundamentalsTwo.Lesson5Complete = false;
      } else if (fundamentalsTwo.Lesson5Complete == false)
      {
      fundamentalsTwo.Lesson5Complete = true;
      }
      _db.Entry(fundamentalsTwo).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction();
    }

    [HttpPost, ActionName("Lesson6")]
    public async Task<ActionResult> LessonSix()
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);

      FundamentalsTwo fundamentalsTwo = _db.FundamentalsTwos.FirstOrDefault(a => a.UserId == userId );
      if (fundamentalsTwo.Lesson6Complete == true)
      {
        fundamentalsTwo.Lesson6Complete = false;
      } else if (fundamentalsTwo.Lesson6Complete == false)
      {
      fundamentalsTwo.Lesson6Complete = true;
      }
      _db.Entry(fundamentalsTwo).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction();
    }

    [HttpPost, ActionName("Lesson7")]
    public async Task<ActionResult> LessonSeven()
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);

      FundamentalsTwo fundamentalsTwo = _db.FundamentalsTwos.FirstOrDefault(a => a.UserId == userId );
      if (fundamentalsTwo.Lesson7Complete == true)
      {
        fundamentalsTwo.Lesson7Complete = false;
      } else if (fundamentalsTwo.Lesson7Complete == false)
      {
      fundamentalsTwo.Lesson7Complete = true;
      }
      _db.Entry(fundamentalsTwo).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction();
    }
  }
}