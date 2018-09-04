using HUAPIClassLibrary;
using HUAPICore.Interfaces;
using HUAPICore.Services;
using Hangfire;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HUAPICore.Pages
{
    /// <summary>
    /// settings page model
    /// </summary>
    public class SettingsModel : PageModel
    {
        const string SCRAPERJOBNAME = "SQLProfileDAL.ScrapeCustomForms";

        private IProfileDAL _dal;
        private IOptions<CustomConfig> _cfg;

        /// 
        public ISettings _settings { get; set; }

        /// if the system is live and online or not
        [BindProperty]
        public bool IsLive { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [BindProperty]
        public Dictionary<string, string> ScrapeJob { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="settings"></param>
        /// <param name="dal"></param>
        /// <param name="cfg"></param>
        public SettingsModel(ISettings settings, IProfileDAL dal, IOptions<CustomConfig> cfg)
        {
            _cfg = cfg;
            _settings = settings;
            _settings.ReadSettings();
            _dal = dal;
        }

        /// when page loads
        public void OnGet()
        {
            IsLive = Convert.ToBoolean(_settings.Settings["IsLive"]);

            //check if scraping job exists....??
            var con = Hangfire.JobStorage.Current.GetConnection();
            ScrapeJob = con.GetAllEntriesFromHash($"recurring-job:{SCRAPERJOBNAME}");
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> OnPostAsync()
        {
            //write out setting
            _settings.UpdateSetting(new CustomSetting() { Name = "IsLive", Value = IsLive.ToString() });

            return RedirectToPage("/Settings");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> OnPostCreateJob()
        {
            //create the job
            //var con = Hangfire.JobStorage.Current.GetConnection();
            //con..GetAllEntriesFromHash($"recurring-job:ProfileController.ScrapeCustomForms");

            RecurringJob.AddOrUpdate(SCRAPERJOBNAME, () => _dal.ScrapeCustomForms("all"), _cfg.Value.SystemConfig.ScrapeCustomFormsCRON);

            return RedirectToPage("/Settings");
        }
    }
}