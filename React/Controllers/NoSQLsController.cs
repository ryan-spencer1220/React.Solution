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
  public class NoSQLsController : Controller
  {
    private readonly ReactContext _db;
    private readonly UserManager<ApplicationUser> _userManager;
    public NoSQLsController(UserManager<ApplicationUser> userManager, ReactContext db)
    {
      _userManager = userManager;
      _db = db;
    }

    public ActionResult Lesson1()
    {
      return View();
    }

    public ActionResult Lesson2()
    {
      return View();
    }

    public ActionResult Lesson3()
    {
      return View();
    }

    public ActionResult Lesson4()
    {
      return View();
    }

    public ActionResult Lesson5()
    {
      return View();
    }

    public ActionResult Lesson6()
    {
      return View();
    }

    public ActionResult Lesson7()
    {
      return View();
    }

    [HttpPost, ActionName("Lesson1")]
    public async Task<ActionResult> LessonOne()
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);

      NoSQL noSQL = _db.NoSQLs.FirstOrDefault(a => a.UserId == userId );
      noSQL.Lesson1Complete = true;
      _db.Entry(noSQL).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Details", "Account");
    }

    [HttpPost, ActionName("Lesson2")]
    public async Task<ActionResult> LessonTwo()
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);

      NoSQL noSQL = _db.NoSQLs.FirstOrDefault(a => a.UserId == userId );
      noSQL.Lesson2Complete = true;
      _db.Entry(noSQL).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    [HttpPost, ActionName("Lesson3")]
    public async Task<ActionResult> LessonThree()
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);

      NoSQL noSQL = _db.NoSQLs.FirstOrDefault(a => a.UserId == userId );
      noSQL.Lesson3Complete = true;
      _db.Entry(noSQL).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    [HttpPost, ActionName("Lesson4")]
    public async Task<ActionResult> LessonFour()
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);

      NoSQL noSQL = _db.NoSQLs.FirstOrDefault(a => a.UserId == userId );
      noSQL.Lesson4Complete = true;
      _db.Entry(noSQL).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    [HttpPost, ActionName("Lesson5")]
    public async Task<ActionResult> LessonFive()
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);

      NoSQL noSQL = _db.NoSQLs.FirstOrDefault(a => a.UserId == userId );
      noSQL.Lesson5Complete = true;
      _db.Entry(noSQL).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    [HttpPost, ActionName("Lesson6")]
    public async Task<ActionResult> LessonSix()
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);

      NoSQL noSQL = _db.NoSQLs.FirstOrDefault(a => a.UserId == userId );
      noSQL.Lesson6Complete = true;
      _db.Entry(noSQL).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    [HttpPost, ActionName("Lesson7")]
    public async Task<ActionResult> LessonSeven()
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);

      NoSQL noSQL = _db.NoSQLs.FirstOrDefault(a => a.UserId == userId );
      noSQL.Lesson7Complete = true;
      _db.Entry(noSQL).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
    
  }
}