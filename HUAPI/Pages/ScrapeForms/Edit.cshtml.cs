using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HUAPICore.Data;
using HUAPICore.Models;
using HUAPIClassLibrary;

namespace HUAPICore.Pages.Tools
{
    /// <summary>
    /// 
    /// </summary>
    public class EditModel : PageModel
    {
        private readonly HUAPIDBContext _context;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        public EditModel(HUAPIDBContext context)
        {
            _context = context;
        }

        /// <summary>
        /// 
        /// </summary>
        [BindProperty]
        public ScrapeQuery ScrapeQuery { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
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

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(ScrapeQuery).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ScrapeQueryExists(ScrapeQuery.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ScrapeQueryExists(int id)
        {
            return _context.ScrapeQuery.Any(e => e.Id == id);
        }
    }
}
