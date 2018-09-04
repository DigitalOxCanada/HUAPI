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
    public class IndexModel : PageModel
    {
        private readonly HUAPIClassLibrary.HUAPIDBContext _context;

        public IndexModel(HUAPIClassLibrary.HUAPIDBContext context)
        {
            _context = context;
        }

        public IList<HUAPIClassLibrary.FWLink> FWLink { get;set; }

        public async Task OnGetAsync()
        {
            FWLink = await _context.FWLink.AsNoTracking().ToListAsync();
        }
    }
}
