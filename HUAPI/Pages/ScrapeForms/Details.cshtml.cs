using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HUAPICore.Data;
using HUAPICore.Models;
using HUAPIClassLibrary;

namespace HUAPICore.Pages.Tools
{
    public class DetailsModel : PageModel
    {
        private readonly HUAPIDBContext _context;

        public DetailsModel(HUAPIDBContext context)
        {
            _context = context;
        }

        public ScrapeQuery ScrapeQuery { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ScrapeQuery = await _context.ScrapeQuery.FirstOrDefaultAsync(m => m.Id == id);

            if (ScrapeQuery == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
