using IntrodutionProject.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace IntrodutionProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly PersonContext _context;

        public HomeController(ILogger<HomeController> logger,PersonContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(Person person)
        {
            _context.Add(person);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}