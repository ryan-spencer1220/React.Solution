using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using React.Models;
using React.ViewModels;

namespace React.Controllers
{
  public class AccountController : Controller
  {
    private readonly ReactContext _db;
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly SignInManager<ApplicationUser> _signInManager;
    
    public AccountController (UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, ReactContext db)
    {
      _userManager = userManager;
      _signInManager = signInManager;
      _db = db;
    }

    public ActionResult Index()
    {
      return View();
    }

    public IActionResult Register()
    {
      return View();
    }

    [HttpPost]
    public async Task<ActionResult> Register (RegisterViewModel model)
    {
      ApplicationUser user = new ApplicationUser { UserName = model.UserName, Email = model.Email, FirstName = model.FirstName, LastName = model.LastName };
      IdentityResult result = await _userManager.CreateAsync(user, model.Password);
      // Introduction intro = new Introduction( user.Id );
      Introduction intro = new Introduction();
      _db.Introductions.Add(intro);
      Redux redux = new Redux();
      _db.Reduxes.Add(redux);
      Api api = new Api();
      _db.Apis.Add(api);
      user.AddSections(intro, redux, api);
      _db.SaveChanges();
      if (result.Succeeded)
      {
        return RedirectToAction("Index");
      }
      else
      {
        return View();
      }
    }

    public ActionResult Login()
    {
      return View();
    }

    [HttpPost]
    public async Task<ActionResult> Login(LoginViewModel model)
    {
      Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.PasswordSignInAsync(model.UserName, model.Password, isPersistent: true, lockoutOnFailure: false);
      if (result.Succeeded)
      {
        return RedirectToAction("Index");
      }
      else
      {
        return View();
      }
    }

    public async Task<ActionResult> Details()
    {
      string userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      ApplicationUser currentUser = await _userManager.FindByIdAsync(userId);
      return View(currentUser);
    }

    [HttpPost]
    public async Task<ActionResult> LogOff()
    {
      await _signInManager.SignOutAsync();
      return RedirectToAction("Index");
    }
  }
}

// namespace React.Controllers {
//   public class AccountController : Controller {
//     private readonly ReactContext _db;
//     private readonly UserManager<ApplicationUser> _userManager;
//     private readonly SignInManager<ApplicationUser> _signInManager;
//     public AccountController (UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, ReactContext db) {
//       _userManager = userManager;
//       _signInManager = signInManager;
//       _db = db;
//     }
//     public ActionResult Index() {
//       return View();
//     }
//     public IActionResult Register() {
//       return View();
//     }
//     [HttpPost]
//     public async Task<ActionResult> Register (RegisterViewModel model) {
//       var user = new ApplicationUser { UserName = model.Email };      

//       //When creating an Introduction object (or Redux, API, etc) we need to tie that object to a specific user, using an unique identifier 

//       //we can create our own custom unique number to identify each user by making a new property, OR...
//       Introduction intro = new Introduction();
//       _db.Introductions.Add(intro);
//       user.AddSections(intro);
//       _db.SaveChanges();

//       //...get a unique identifier for each specific user from Identity
//       // Introduction intro = new Introduction( User.Identity.UserId );
//       // Introduction intro = new Introduction(this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value);
//       // Introduction intro = new Introduction( user.Identity.id );

  

//       // Redux red = new Redux(user.Id);

//       // user.IntroductionId = intro.IntroductionId;
//       // user.ReduxId = red.ReduxId;

//       IdentityResult result = await _userManager.CreateAsync(user, model.Password);
//       if (result.Succeeded) {
//         return RedirectToAction("Index");
//       }
//       else {
//         return View();
//       }
//     }
//     public ActionResult Login() {
//       return View();
//     }

//     [HttpPost]
//     public async Task<ActionResult> Login(LoginViewModel model) {
//       Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, isPersistent: true, lockoutOnFailure: false);
//       if (result.Succeeded) {
//         return RedirectToAction("Index");
//       }
//       else {
//         return View();
//       }
//     }

//     [HttpPost]
//     public async Task<ActionResult> LogOff() {
//       await _signInManager.SignOutAsync();
//       return RedirectToAction("Index");
//     }
//   }
// }