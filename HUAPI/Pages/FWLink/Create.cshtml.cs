using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using HUAPIClassLibrary;

namespace HUAPICore.Pages.FWLink
{
    public class CreateModel : PageModel
    {
        private readonly HUAPIClassLibrary.HUAPIDBContext _context;

        public CreateModel(HUAPIClassLibrary.HUAPIDBContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public HUAPIClassLibrary.FWLink FWLink { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.FWLink.Add(FWLink);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}