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
    /// <summary>
    /// 
    /// </summary>
    public class ScrapeFormsModels : PageModel
    {
        private readonly HUAPIDBContext _context;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        public ScrapeFormsModels(HUAPIDBContext context)
        {
            _context = context;
        }

        /// <summary>
        /// 
        /// </summary>
        public IList<ScrapeQuery> ScrapeQuery { get;set; }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public async Task OnGetAsync()
        {
            ScrapeQuery = await _context.ScrapeQuery.AsNoTracking().ToListAsync();
        }
    }
}
