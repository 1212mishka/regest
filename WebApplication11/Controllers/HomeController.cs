using Microsoft.AspNetCore.Mvc;
using WebApplication11;

namespace WebApplication11.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationContext _context;

        public HomeController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(User user)
        {
            if (ModelState.IsValid)
            {
                _context.Users.Add(user);
                _context.SaveChanges();
                return RedirectToAction("Success");
            }
            return View(user);
        }

        public IActionResult Success()
        {
            return View();
        }
    }
}
