using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TravelApp.Models;
using TravelApp.Core.Filters;
using TravelApp.Core.Extensions;
using TravelApp.Data;
using TravelApp.Models.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace TravelApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext db;
        public HomeController(AppDbContext _db)
        {
            db = _db;
        }

        [ServiceFilter(typeof(CheckLanguageFilter))]
        public async Task<IActionResult> Index()
        {
            int langId = await HttpContext.GetCurrentLanguageIdAsync(db, "lang_id");
            HomeModel model = new HomeModel()
            {
                serviceLanguages = await db.ServiceLanguages
                                                .Where(sl=>sl.LanguageId == langId)
                                                .Include(sl=>sl.Service)
                                                .ThenInclude(sl=>sl.Photos)
                                                .ToListAsync(),

                testimonialLanguages = await db.TestimonialLanguages
                                                .Where(tl=>tl.LanguageId == langId)
                                                .Include(tl=>tl.Testimonial)
                                                .ToListAsync()
            };
            return View(model);
        }

    }
}
