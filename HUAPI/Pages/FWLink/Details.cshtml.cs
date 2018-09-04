using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HUAPIClassLibrary;

namespace HUAPICore.Pages.FWLink
{
    public class DetailsModel : PageModel
    {
        private readonly HUAPIClassLibrary.HUAPIDBContext _context;

        public DetailsModel(HUAPIClassLibrary.HUAPIDBContext context)
        {
            _context = context;
        }

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
    }
}
