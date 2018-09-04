using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HUAPIClassLibrary;

namespace HUAPICore.Pages.FWLink
{
    public class EditModel : PageModel
    {
        private readonly HUAPIClassLibrary.HUAPIDBContext _context;

        public EditModel(HUAPIClassLibrary.HUAPIDBContext context)
        {
            _context = context;
        }

        [BindProperty]
        public HUAPIClassLibrary.FWLink FWLink { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            FWLink = await _context.FWLink.FirstOrDefaultAsync(m => m.Id == id);

            if (FWLink == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(FWLink).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FWLinkExists(FWLink.Id))
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

        private bool FWLinkExists(int id)
        {
            return _context.FWLink.Any(e => e.Id == id);
        }
    }
}
