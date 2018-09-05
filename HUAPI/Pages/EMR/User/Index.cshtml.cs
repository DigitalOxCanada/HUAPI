using HUAPICore.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HUAPICore.Pages.EMR.User
{
    public class IndexModel : PageModel
    {
        private readonly IProfileDAL _dal;

        public IndexModel(IProfileDAL dal)
        {
            _dal = dal;
        }

        public class data
        {
            public int x { get; set; }
            public string xval { get; set; }
            public double yval { get; set; }
        }

        [BindProperty]
        public List<data> datasource { get; set; }

        [BindProperty]
        public long Sessions { get; private set; }
        [BindProperty]
        public long Users { get; private set; }

        public void OnGet()
        {
            Sessions = -1;

            var ret = _dal.GetConcurrentUsersLatest();
            if (ret != null)
            {
                Sessions = ret.CulSessions;
                Users = ret.CulUsers;
            }

            var all = _dal.GetConcurrentUsers(DateTime.Today); // DateTime.Parse("2016-01-12"));       //DateTime.Now);
            int cnt = 0;
            datasource = new List<data>();
            foreach (var a in all)
            {
                cnt++;
                datasource.Add(new data { x = cnt, xval = a.CulDate.ToString(), yval = a.CulSessions });
            }
            datasource.Reverse();
            ViewData["peakusers"] = all.Max(p => p.CulUsers);
            ViewData["peaksessions"] = all.Max(p => p.CulSessions);
        }
    }
}