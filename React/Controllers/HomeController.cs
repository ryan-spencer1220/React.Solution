using System;
using System.Reflection;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using React.Models;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using System.Threading.Tasks;

namespace React.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ReactContext _db;
        private readonly UserManager<ApplicationUser> _userManager;

        public HomeController(ILogger<HomeController> logger, UserManager<ApplicationUser> userManager, ReactContext db)
        {
            _logger = logger;
            _userManager = userManager;
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public async Task<IActionResult> Overview()
        {
            var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var currentUser = await _userManager.FindByIdAsync(userId);

            ViewBag.Introduction = _db.Introductions.FirstOrDefault(a => a.UserId == userId );
            ViewBag.FundamentalsOne = _db.FundamentalsOnes.FirstOrDefault(a => a.UserId == userId );
            ViewBag.FundamentalsTwo = _db.FundamentalsTwos.FirstOrDefault(a => a.UserId == userId );
            ViewBag.Redux = _db.Reduxes.FirstOrDefault(a => a.UserId == userId );
            ViewBag.NoSQL = _db.NoSQLs.FirstOrDefault(a => a.UserId == userId );
            ViewBag.Api = _db.Apis.FirstOrDefault(a => a.UserId == userId );

            // ViewBag.TotalLessons = _db.Select(x => x.GetType().GetProperty("Lesson1").GetValue(x, null)).ToArray();
            ViewBag.NumLessons = 0;
            ViewBag.NumComplete = 0;
            ViewBag.Ratio = 0.0;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
