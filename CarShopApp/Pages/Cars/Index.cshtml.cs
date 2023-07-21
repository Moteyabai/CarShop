using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Repositories.Models;

namespace CarShopApp.Pages.Cars
{
    public class IndexModel : PageModel
    {
        private readonly Repositories.Models.CarShopContext _context;

        public IndexModel(Repositories.Models.CarShopContext context)
        {
            _context = context;
        }

        public IList<Car> Car { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Cars != null)
            {
                Car = await _context.Cars.ToListAsync();
            }
        }
    }
}
