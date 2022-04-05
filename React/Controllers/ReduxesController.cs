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
  public class ReduxesController : Controller
  {
    private readonly ReactContext _db;
    private readonly UserManager<ApplicationUser> _userManager;
    public ReduxesController(UserManager<ApplicationUser> userManager, ReactContext db)
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
  }
}