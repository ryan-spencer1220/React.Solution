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
  public class IntroductionsController : Controller
  {
    private readonly ReactContext _db;
    private readonly UserManager<ApplicationUser> _userManager;
    public IntroductionsController(UserManager<ApplicationUser> userManager, ReactContext db)
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

    [HttpPost, ActionName("Lesson1")]
    public async Task<ActionResult> LessonOne()
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);

      Introduction introduction = _db.Introductions.FirstOrDefault(a => a.UserId == userId );
      introduction.Lesson1Complete = true;
      _db.Entry(introduction).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
} 