using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RecipeManager.Data;
using RecipeManager.Helpers;


namespace RecipeManager.Controllers
{
    public class RecipesController : Controller
    {
        private readonly AppDbContext _context;

        public RecipesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Recipes
		public async Task<IActionResult> Index(string searchString, string sortOrder, int? pageNumber)
		{
			ViewData["CurrentFilter"] = searchString;
			ViewData["CurrentSort"] = sortOrder;
			ViewData["NameSortParm"] = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
			ViewData["DateSortParm"] = sortOrder == "Date" ? "date_desc" : "Date";

			var recipes = _context.Recipes.Include(r => r.Category).AsQueryable();

			// Search
			if (!String.IsNullOrEmpty(searchString))
			{
				recipes = recipes.Where(r => r.Name.Contains(searchString));
			}

			// Sort
			recipes = sortOrder switch
			{
				"name_desc" => recipes.OrderByDescending(r => r.Name),
				"Date" => recipes.OrderBy(r => r.CreatedDate),
				"date_desc" => recipes.OrderByDescending(r => r.CreatedDate),
				_ => recipes.OrderBy(r => r.Name),
			};

			int pageSize = 5;
			return View(await PaginatedList<Recipe>.CreateAsync(recipes.AsNoTracking(), pageNumber ?? 1, pageSize));
		}


        // GET: Recipes/Details
		public async Task<IActionResult> Details(int? id)
		{
			if (id == null || _context.Recipes == null)
			{
				return NotFound();
			}

			var recipe = await _context.Recipes
				.Include(r => r.Category)
				.Include(r => r.Ingredients)
				.FirstOrDefaultAsync(m => m.Id == id);

			if (recipe == null)
			{
				return NotFound();
			}

			return View(recipe);
		}


        // GET: Recipes/Create
        public IActionResult Create()
        {
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name");
            return View();
        }

        // POST: Recipes/Create
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Create([Bind("Id,Name,Description,CreatedDate,CategoryId")] Recipe recipe)
		{
			if (!ModelState.IsValid)
			{
				foreach (var error in ModelState)
				{
					foreach (var subError in error.Value.Errors)
					{
						Console.WriteLine($"Model Error on {error.Key}: {subError.ErrorMessage}");
					}
				}
			}

			if (ModelState.IsValid)
			{
				_context.Add(recipe);
				await _context.SaveChangesAsync();
				return RedirectToAction(nameof(Index));
			}

			ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name", recipe.CategoryId);
			return View(recipe);
		}


        // GET: Recipes/Edit
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var recipe = await _context.Recipes.FindAsync(id);
            if (recipe == null)
            {
                return NotFound();
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name", recipe.CategoryId);
            return View(recipe);
        }

        // POST: Recipes/Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Description,CreatedDate,CategoryId")] Recipe recipe)
        {
            if (id != recipe.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(recipe);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RecipeExists(recipe.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name", recipe.CategoryId);
            return View(recipe);
        }

        // GET: Recipes/Delete
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var recipe = await _context.Recipes
                .Include(r => r.Category)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (recipe == null)
            {
                return NotFound();
            }

            return View(recipe);
        }

        // POST: Recipes/Delete
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var recipe = await _context.Recipes.FindAsync(id);
            if (recipe != null)
            {
                _context.Recipes.Remove(recipe);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

		[HttpPost]
		public async Task<IActionResult> ToggleFavorite(int id)
		{
			var recipe = await _context.Recipes.FindAsync(id);
			if (recipe == null)
				return NotFound();

			recipe.IsFavorite = !recipe.IsFavorite;
			await _context.SaveChangesAsync();

			return RedirectToAction(nameof(Details), new { id = recipe.Id });
		}

		public async Task<IActionResult> Favorites(int? pageNumber)
		{
			var favs = _context.Recipes
				.Include(r => r.Category)
				.Where(r => r.IsFavorite);

			int pageSize = 5;
			return View("Index", await PaginatedList<Recipe>.CreateAsync(favs.AsNoTracking(), pageNumber ?? 1, pageSize));
		}

        private bool RecipeExists(int id)
        {
            return _context.Recipes.Any(e => e.Id == id);
        }
    }
}
