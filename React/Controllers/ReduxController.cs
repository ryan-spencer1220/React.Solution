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
  public class ReduxController : Controller
  {
    private readonly ReactContext _db;
    private readonly UserManager<ApplicationUser> _userManager;
    public ReduxController(UserManager<ApplicationUser> userManager, ReactContext db)
    {
      _userManager = userManager;
      _db = db;
    }

    public async Task<ActionResult> Lesson1()
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);

      Redux redux = _db.Reduxes.FirstOrDefault(a => a.UserId == userId );
      ViewBag.IsComplete = redux.Lesson1Complete;
      return View();
    }

    public async Task<ActionResult> Lesson2()
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);

      Redux redux = _db.Reduxes.FirstOrDefault(a => a.UserId == userId );
      ViewBag.IsComplete = redux.Lesson2Complete;
      return View();
    }

    public async Task<ActionResult> Lesson3()
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);

      Redux redux = _db.Reduxes.FirstOrDefault(a => a.UserId == userId );
      ViewBag.IsComplete = redux.Lesson3Complete;
      return View();
    }

    public async Task<ActionResult> Lesson4()
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);

      Redux redux = _db.Reduxes.FirstOrDefault(a => a.UserId == userId );
      ViewBag.IsComplete = redux.Lesson4Complete;
      return View();
    }

    public async Task<ActionResult> Lesson5()
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);

      Redux redux = _db.Reduxes.FirstOrDefault(a => a.UserId == userId );
      ViewBag.IsComplete = redux.Lesson5Complete;
      return View();
    }

    public async Task<ActionResult> Lesson6()
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);

      Redux redux = _db.Reduxes.FirstOrDefault(a => a.UserId == userId );
      ViewBag.IsComplete = redux.Lesson6Complete;
      return View();
    }

    public async Task<ActionResult> Lesson7()
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);

      Redux redux = _db.Reduxes.FirstOrDefault(a => a.UserId == userId );
      ViewBag.IsComplete = redux.Lesson7Complete;
      return View();
    }

    [HttpPost, ActionName("Lesson1")]
    public async Task<ActionResult> LessonOne()
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);

      Redux redux = _db.Reduxes.FirstOrDefault(a => a.UserId == userId );
      if (redux.Lesson1Complete == true)
      {
        redux.Lesson1Complete = false;
      } else if (redux.Lesson1Complete == false)
      {
      redux.Lesson1Complete = true;
      }
      _db.Entry(redux).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction();
    }

    [HttpPost, ActionName("Lesson2")]
    public async Task<ActionResult> LessonTwo()
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);

      Redux redux = _db.Reduxes.FirstOrDefault(a => a.UserId == userId );
      if (redux.Lesson2Complete == true)
      {
        redux.Lesson2Complete = false;
      } else if (redux.Lesson2Complete == false)
      {
      redux.Lesson2Complete = true;
      }
      _db.Entry(redux).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction();
    }

    [HttpPost, ActionName("Lesson3")]
    public async Task<ActionResult> LessonThree()
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);

      Redux redux = _db.Reduxes.FirstOrDefault(a => a.UserId == userId );
      if (redux.Lesson3Complete == true)
      {
        redux.Lesson3Complete = false;
      } else if (redux.Lesson3Complete == false)
      {
      redux.Lesson3Complete = true;
      }
      _db.Entry(redux).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction();
    }

    [HttpPost, ActionName("Lesson4")]
    public async Task<ActionResult> LessonFour()
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);

      Redux redux = _db.Reduxes.FirstOrDefault(a => a.UserId == userId );
      if (redux.Lesson4Complete == true)
      {
        redux.Lesson4Complete = false;
      } else if (redux.Lesson4Complete == false)
      {
      redux.Lesson4Complete = true;
      }
      _db.Entry(redux).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction();
    }

    [HttpPost, ActionName("Lesson5")]
    public async Task<ActionResult> LessonFive()
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);

      Redux redux = _db.Reduxes.FirstOrDefault(a => a.UserId == userId );
      if (redux.Lesson5Complete == true)
      {
        redux.Lesson5Complete = false;
      } else if (redux.Lesson5Complete == false)
      {
      redux.Lesson5Complete = true;
      }
      _db.Entry(redux).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction();
    }

    [HttpPost, ActionName("Lesson6")]
    public async Task<ActionResult> LessonSix()
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);

      Redux redux = _db.Reduxes.FirstOrDefault(a => a.UserId == userId );
      if (redux.Lesson6Complete == true)
      {
        redux.Lesson6Complete = false;
      } else if (redux.Lesson6Complete == false)
      {
      redux.Lesson6Complete = true;
      }
      _db.Entry(redux).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction();
    }

    [HttpPost, ActionName("Lesson7")]
    public async Task<ActionResult> LessonSeven()
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);

      Redux redux = _db.Reduxes.FirstOrDefault(a => a.UserId == userId );
      if (redux.Lesson7Complete == true)
      {
        redux.Lesson7Complete = false;
      } else if (redux.Lesson7Complete == false)
      {
      redux.Lesson7Complete = true;
      }
      _db.Entry(redux).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction();
    }
    
  }
}