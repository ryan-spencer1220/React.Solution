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
  public class NoSQLController : Controller
  {
    private readonly ReactContext _db;
    private readonly UserManager<ApplicationUser> _userManager;
    public NoSQLController(UserManager<ApplicationUser> userManager, ReactContext db)
    {
      _userManager = userManager;
      _db = db;
    }

    public async Task<ActionResult> Lesson1()
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);

      NoSQL noSQL = _db.NoSQLs.FirstOrDefault(a => a.UserId == userId );
      ViewBag.IsComplete = noSQL.Lesson1Complete;
      return View();
    }

    public async Task<ActionResult> Lesson2()
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);

      NoSQL noSQL = _db.NoSQLs.FirstOrDefault(a => a.UserId == userId );
      ViewBag.IsComplete = noSQL.Lesson2Complete;
      return View();
    }

    public async Task<ActionResult> Lesson3()
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);

      NoSQL noSQL = _db.NoSQLs.FirstOrDefault(a => a.UserId == userId );
      ViewBag.IsComplete = noSQL.Lesson3Complete;
      return View();
    }

    public async Task<ActionResult> Lesson4()
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);

      NoSQL noSQL = _db.NoSQLs.FirstOrDefault(a => a.UserId == userId );
      ViewBag.IsComplete = noSQL.Lesson4Complete;
      return View();
    }

    public async Task<ActionResult> Lesson5()
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);

      NoSQL noSQL = _db.NoSQLs.FirstOrDefault(a => a.UserId == userId );
      ViewBag.IsComplete = noSQL.Lesson5Complete;
      return View();
    }

    public async Task<ActionResult> Lesson6()
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);

      NoSQL noSQL = _db.NoSQLs.FirstOrDefault(a => a.UserId == userId );
      ViewBag.IsComplete = noSQL.Lesson6Complete;
      return View();
    }

    public async Task<ActionResult> Lesson7()
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);

      NoSQL noSQL = _db.NoSQLs.FirstOrDefault(a => a.UserId == userId );
      ViewBag.IsComplete = noSQL.Lesson7Complete;
      return View();
    }

    [HttpPost, ActionName("Lesson1")]
    public async Task<ActionResult> LessonOne()
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);

      NoSQL noSQL = _db.NoSQLs.FirstOrDefault(a => a.UserId == userId );
      if (noSQL.Lesson1Complete == true)
      {
        noSQL.Lesson1Complete = false;
      } else if (noSQL.Lesson1Complete == false)
      {
      noSQL.Lesson1Complete = true;
      }
      _db.Entry(noSQL).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction();
    }

    [HttpPost, ActionName("Lesson2")]
    public async Task<ActionResult> LessonTwo()
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);

      NoSQL noSQL = _db.NoSQLs.FirstOrDefault(a => a.UserId == userId );
      if (noSQL.Lesson2Complete == true)
      {
        noSQL.Lesson2Complete = false;
      } else if (noSQL.Lesson2Complete == false)
      {
      noSQL.Lesson2Complete = true;
      }
      _db.Entry(noSQL).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction();
    }

    [HttpPost, ActionName("Lesson3")]
    public async Task<ActionResult> LessonThree()
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);

      NoSQL noSQL = _db.NoSQLs.FirstOrDefault(a => a.UserId == userId );
      if (noSQL.Lesson3Complete == true)
      {
        noSQL.Lesson3Complete = false;
      } else if (noSQL.Lesson3Complete == false)
      {
      noSQL.Lesson3Complete = true;
      }
      _db.Entry(noSQL).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction();
    }

    [HttpPost, ActionName("Lesson4")]
    public async Task<ActionResult> LessonFour()
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);

      NoSQL noSQL = _db.NoSQLs.FirstOrDefault(a => a.UserId == userId );
      if (noSQL.Lesson4Complete == true)
      {
        noSQL.Lesson4Complete = false;
      } else if (noSQL.Lesson4Complete == false)
      {
      noSQL.Lesson4Complete = true;
      }
      _db.Entry(noSQL).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction();
    }

    [HttpPost, ActionName("Lesson5")]
    public async Task<ActionResult> LessonFive()
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);

      NoSQL noSQL = _db.NoSQLs.FirstOrDefault(a => a.UserId == userId );
      if (noSQL.Lesson5Complete == true)
      {
        noSQL.Lesson5Complete = false;
      } else if (noSQL.Lesson5Complete == false)
      {
      noSQL.Lesson5Complete = true;
      }
      _db.Entry(noSQL).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction();
    }

    [HttpPost, ActionName("Lesson6")]
    public async Task<ActionResult> LessonSix()
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);

      NoSQL noSQL = _db.NoSQLs.FirstOrDefault(a => a.UserId == userId );
      if (noSQL.Lesson6Complete == true)
      {
        noSQL.Lesson6Complete = false;
      } else if (noSQL.Lesson6Complete == false)
      {
      noSQL.Lesson6Complete = true;
      }
      _db.Entry(noSQL).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction();
    }

    [HttpPost, ActionName("Lesson7")]
    public async Task<ActionResult> LessonSeven()
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);

      NoSQL noSQL = _db.NoSQLs.FirstOrDefault(a => a.UserId == userId );
      if (noSQL.Lesson7Complete == true)
      {
        noSQL.Lesson7Complete = false;
      } else if (noSQL.Lesson7Complete == false)
      {
      noSQL.Lesson7Complete = true;
      }
      _db.Entry(noSQL).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction();
    }
  }
}