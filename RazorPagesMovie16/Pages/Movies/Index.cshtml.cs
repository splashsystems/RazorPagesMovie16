using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie16.Data;
using RazorPagesMovie16.Models;

namespace RazorPagesMovie16.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesMovie16.Data.RazorPagesMovie16Context _context;

        public IndexModel(RazorPagesMovie16.Data.RazorPagesMovie16Context context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
