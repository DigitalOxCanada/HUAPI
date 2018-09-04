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
    public class DeleteModel : PageModel
    {
        private readonly HUAPIDBContext _context;

        public DeleteModel(HUAPIDBContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ScrapeQuery = await _context.ScrapeQuery.FindAsync(id);

            if (ScrapeQuery != null)
            {
                _context.ScrapeQuery.Remove(ScrapeQuery);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
