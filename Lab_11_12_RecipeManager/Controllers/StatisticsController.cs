using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RecipeManager.Data;
using RecipeManager.ViewModels;

namespace RecipeManager.Controllers
{
    public class StatisticsController : Controller
    {
        private readonly AppDbContext _context;

        public StatisticsController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var stats = await _context.Categories
                .Select(c => new CategoryStatsViewModel
                {
                    CategoryName = c.Name,
                    RecipeCount = c.Recipes.Count
                })
                .ToListAsync();

            return View(stats);
        }
    }
}
