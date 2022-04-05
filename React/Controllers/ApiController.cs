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
  public class ApiController : Controller
  {
    private readonly ReactContext _db;
    private readonly UserManager<ApplicationUser> _userManager;
    public ApiController(UserManager<ApplicationUser> userManager, ReactContext db)
    {
      _userManager = userManager;
      _db = db;
    }

    public async Task<ActionResult> Lesson1()
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);

      Api Api = _db.Apis.FirstOrDefault(a => a.UserId == userId );
      ViewBag.IsComplete = Api.Lesson1Complete;
      return View();
    }

    public async Task<ActionResult> Lesson2()
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);

      Api Api = _db.Apis.FirstOrDefault(a => a.UserId == userId );
      ViewBag.IsComplete = Api.Lesson2Complete;
      return View();
    }

    public async Task<ActionResult> Lesson3()
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);

      Api Api = _db.Apis.FirstOrDefault(a => a.UserId == userId );
      ViewBag.IsComplete = Api.Lesson3Complete;
      return View();
    }

    public async Task<ActionResult> Lesson4()
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);

      Api Api = _db.Apis.FirstOrDefault(a => a.UserId == userId );
      ViewBag.IsComplete = Api.Lesson4Complete;
      return View();
    }

    public async Task<ActionResult> Lesson5()
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);

      Api Api = _db.Apis.FirstOrDefault(a => a.UserId == userId );
      ViewBag.IsComplete = Api.Lesson5Complete;
      return View();
    }

    public async Task<ActionResult> Lesson6()
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);

      Api Api = _db.Apis.FirstOrDefault(a => a.UserId == userId );
      ViewBag.IsComplete = Api.Lesson6Complete;
      return View();
    }
    [HttpPost, ActionName("Lesson1")]
    public async Task<ActionResult> LessonOne()
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);

      Api Api = _db.Apis.FirstOrDefault(a => a.UserId == userId );
      if (Api.Lesson1Complete == true)
      {
        Api.Lesson1Complete = false;
      } else if (Api.Lesson1Complete == false)
      {
      Api.Lesson1Complete = true;
      }
      _db.Entry(Api).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction();
    }

    [HttpPost, ActionName("Lesson2")]
    public async Task<ActionResult> LessonTwo()
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);

      Api Api = _db.Apis.FirstOrDefault(a => a.UserId == userId );
      if (Api.Lesson2Complete == true)
      {
        Api.Lesson2Complete = false;
      } else if (Api.Lesson2Complete == false)
      {
      Api.Lesson2Complete = true;
      }
      _db.Entry(Api).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction();
    }

    [HttpPost, ActionName("Lesson3")]
    public async Task<ActionResult> LessonThree()
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);

      Api Api = _db.Apis.FirstOrDefault(a => a.UserId == userId );
      if (Api.Lesson3Complete == true)
      {
        Api.Lesson3Complete = false;
      } else if (Api.Lesson3Complete == false)
      {
      Api.Lesson3Complete = true;
      }
      _db.Entry(Api).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction();
    }

    [HttpPost, ActionName("Lesson4")]
    public async Task<ActionResult> LessonFour()
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);

      Api Api = _db.Apis.FirstOrDefault(a => a.UserId == userId );
      if (Api.Lesson4Complete == true)
      {
        Api.Lesson4Complete = false;
      } else if (Api.Lesson4Complete == false)
      {
      Api.Lesson4Complete = true;
      }
      _db.Entry(Api).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction();
    }

    [HttpPost, ActionName("Lesson5")]
    public async Task<ActionResult> LessonFive()
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);

      Api Api = _db.Apis.FirstOrDefault(a => a.UserId == userId );
      if (Api.Lesson5Complete == true)
      {
        Api.Lesson5Complete = false;
      } else if (Api.Lesson5Complete == false)
      {
      Api.Lesson5Complete = true;
      }
      _db.Entry(Api).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction();
    }

    [HttpPost, ActionName("Lesson6")]
    public async Task<ActionResult> LessonSix()
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);

      Api Api = _db.Apis.FirstOrDefault(a => a.UserId == userId );
      if (Api.Lesson6Complete == true)
      {
        Api.Lesson6Complete = false;
      } else if (Api.Lesson6Complete == false)
      {
      Api.Lesson6Complete = true;
      }
      _db.Entry(Api).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction();
    }
  }
}