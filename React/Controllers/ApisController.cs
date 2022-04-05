using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using React.Models;

namespace React.Controllers
{
  public class ApisController : Controller
  {
    private readonly ReactContext _db;
    private readonly UserManager<ApplicationUser> _userManager;
    public ApisController(UserManager<ApplicationUser> userManager, ReactContext db)
    {
      _userManager = userManager;
      _db = db;
    }
    public ActionResult Index()
    {
      return View();
    }

    public ActionResult Lesson1()
    {
      return View();
    }
    // [HttpPost, ActionName("Lesson1")]
    // public async Task<ActionResult> LessonOne()
    // {
    //   var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
    //   var currentUser = await _userManager.FindByIdAsync(userId);
    //   var api = currentUser.Api;
    //   api.Lesson1Complete = true;
    //   _db.Entry(api)EntityState.Modified;
    //   _db.SaveChanges();
    //   return RedirectToAction("Index");
    // }
    public ActionResult Lesson2()
    {
      return View();
    }
    //  public ActionResult Lesson2()
    // {
    //   return View();
    // }
    // [HttpPost, ActionName("Lesson2")]
    // public async Task<ActionResult> LessonTwo()
    // {
    //   var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
    //   var currentUser = await _userManager.FindByIdAsync(userId);
    //   var api = currentUser.Api;
    //   api.Lesson2Complete = true;
    //   _db.Entry(api)EntityState.Modified;
    //   _db.SaveChanges();
    //   return RedirectToAction("Index");
    // }
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
  }
}