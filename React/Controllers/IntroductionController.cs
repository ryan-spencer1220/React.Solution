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
  public class IntroductionController : Controller
  {
    private readonly ReactContext _db;
    private readonly UserManager<ApplicationUser> _userManager;
    public IntroductionController(UserManager<ApplicationUser> userManager, ReactContext db)
    {
      _userManager = userManager;
      _db = db;
    }

    public async Task<ActionResult> Lesson1()
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);

      Introduction introduction = _db.Introductions.FirstOrDefault(a => a.UserId == userId );
      ViewBag.IsComplete = introduction.Lesson1Complete;
      return View();
    }

    public async Task<ActionResult> Lesson2()
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);

      Introduction introduction = _db.Introductions.FirstOrDefault(a => a.UserId == userId );
      ViewBag.IsComplete = introduction.Lesson2Complete;
      return View();
    }

    public async Task<ActionResult> Lesson3()
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);

      Introduction introduction = _db.Introductions.FirstOrDefault(a => a.UserId == userId );
      ViewBag.IsComplete = introduction.Lesson3Complete;
      return View();
    }

        public async Task<ActionResult> Lesson4()
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);

      Introduction introduction = _db.Introductions.FirstOrDefault(a => a.UserId == userId );
      ViewBag.IsComplete = introduction.Lesson4Complete;
      return View();
    }

    [HttpPost, ActionName("Lesson1")]
    public async Task<ActionResult> LessonOne()
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);

      Introduction introduction = _db.Introductions.FirstOrDefault(a => a.UserId == userId );
      if (introduction.Lesson1Complete == true)
      {
        introduction.Lesson1Complete = false;
      } else if (introduction.Lesson1Complete == false)
      {
      introduction.Lesson1Complete = true;
      }
      _db.Entry(introduction).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction();
    }

    [HttpPost, ActionName("Lesson2")]
    public async Task<ActionResult> LessonTwo()
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);

      Introduction introduction = _db.Introductions.FirstOrDefault(a => a.UserId == userId );
      if (introduction.Lesson2Complete == true)
      {
        introduction.Lesson2Complete = false;
      } else if (introduction.Lesson2Complete == false)
      {
      introduction.Lesson2Complete = true;
      }
      _db.Entry(introduction).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction();
    }

    [HttpPost, ActionName("Lesson3")]
    public async Task<ActionResult> LessonThree()
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);

      Introduction introduction = _db.Introductions.FirstOrDefault(a => a.UserId == userId );
      if (introduction.Lesson3Complete == true)
      {
        introduction.Lesson3Complete = false;
      } else if (introduction.Lesson3Complete == false)
      {
      introduction.Lesson3Complete = true;
      }
      _db.Entry(introduction).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction();
    }

    [HttpPost, ActionName("Lesson4")]
    public async Task<ActionResult> LessonFour()
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);

      Introduction introduction = _db.Introductions.FirstOrDefault(a => a.UserId == userId );
      if (introduction.Lesson4Complete == true)
      {
        introduction.Lesson4Complete = false;
      } else if (introduction.Lesson4Complete == false)
      {
      introduction.Lesson4Complete = true;
      }
      _db.Entry(introduction).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction();
    }
  }
}