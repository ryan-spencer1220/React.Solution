using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using React.Models;
using React.ViewModels;
using System.Linq;

namespace React.Controllers {
  public class AccountController : Controller {
    private readonly ReactContext _db;
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly SignInManager<ApplicationUser> _signInManager;
    public AccountController (UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, ReactContext db) {
      _userManager = userManager;
      _signInManager = signInManager;
      _db = db;
    }

    public async Task<ActionResult> Index() {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);

      ViewBag.Introduction = _db.Introductions.FirstOrDefault(a => a.UserId == userId );
      ViewBag.FundamentalsOne = _db.FundamentalsOnes.FirstOrDefault(a => a.UserId == userId );
      ViewBag.FundamentalsTwo = _db.FundamentalsTwos.FirstOrDefault(a => a.UserId == userId );
      ViewBag.Redux = _db.Reduxes.FirstOrDefault(a => a.UserId == userId );
      ViewBag.NoSQL = _db.NoSQLs.FirstOrDefault(a => a.UserId == userId );
      ViewBag.Api = _db.Apis.FirstOrDefault(a => a.UserId == userId );
      return View(currentUser);
    }
    public IActionResult Register() {
      return View();
    }
    [HttpPost]
    public async Task<ActionResult> Register (RegisterViewModel model) {
      var user = new ApplicationUser { UserName = model.Email, FirstName = model.FirstName, LastName = model.LastName };      
      Introduction intro = new Introduction(user.Id);
      FundamentalsOne fundamentalsOne = new FundamentalsOne(user.Id);
      FundamentalsTwo fundamentalsTwo = new FundamentalsTwo(user.Id);
      Redux redux = new Redux(user.Id);
      NoSQL noSql = new NoSQL(user.Id);
      Api api = new Api(user.Id);
      _db.Introductions.Add(intro);
      _db.FundamentalsOnes.Add(fundamentalsOne);
      _db.FundamentalsTwos.Add(fundamentalsTwo);
      _db.Reduxes.Add(redux);
      _db.NoSQLs.Add(noSql);
      _db.Apis.Add(api);
      user.AddIds(intro.IntroductionId, fundamentalsOne.FundamentalsOneId, fundamentalsTwo.FundamentalsTwoId, redux.ReduxId, noSql.NoSQLId, api.ApiId);
      _db.SaveChanges();
      IdentityResult result = await _userManager.CreateAsync(user, model.Password);
      if (result.Succeeded) {
        return RedirectToAction("Index");
      }
      else {
        return View();
      }
    }
    public ActionResult Login() {
      return View();
    }

    [HttpPost]
    public async Task<ActionResult> Login(LoginViewModel model) {
      Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, isPersistent: true, lockoutOnFailure: false);
      if (result.Succeeded) {
        return RedirectToAction("Index");
      }
      else {
        return View();
      }
    }

    [HttpPost]
    public async Task<ActionResult> LogOff() {
      await _signInManager.SignOutAsync();
      return RedirectToAction("Index");
    }
  }
}