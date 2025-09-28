using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SnapFolio.Data;
using SnapFolio.Models;
using SnapFolio.ViewModels;

namespace SnapFolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var categories = _context.Categories
                .Include(c => c.Items)
                .ToList();

            var experiences = _context.Experiences
                .Include(e => e.Details)
                .OrderByDescending(e=>e.StartYear)
                .ToList();

            var educations = _context.Educations.ToList();

            var homeVM = new HomeVM
            {
                Categories = categories,
                Experiences = experiences,
                Educations = educations
            };
            return View(homeVM);
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
    }
}
