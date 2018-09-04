using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using HUAPICore.Data;
using HUAPICore.Models;
using HUAPICore.Services;
using System.Net.Http;
using HUAPICore.Interfaces;
using HUAPIClassLibrary;
using Profile7ClassLibrary.Entities;

namespace HUAPICore.Pages.Tools
{
    public class CreateModel : PageModel
    {
        public IProfileDAL _profileDAL { get; set; }

        [BindProperty]
        public string FormName{ get; set; }
        [BindProperty]
        public List<CustomFormDef> CustomForms { get; set; }

        public CreateModel(IProfileDAL profiledal)
        {
            _profileDAL = profiledal;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IActionResult OnGet()
        {
            CustomForms = _profileDAL.GetListOfAllForms();

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

            var retval = await _profileDAL.GenerateScrapeFormQueries(FormName);

            return RedirectToPage("./Index");
        }
    }
}