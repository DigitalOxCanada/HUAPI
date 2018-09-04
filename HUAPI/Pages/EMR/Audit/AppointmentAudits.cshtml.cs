using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Profile7ClassLibrary;
using Profile7ClassLibrary.Entities;

namespace HUAPICore.Pages.EMR.Audit
{
    public class AppointmentAuditsModel : PageModel
    {
        private readonly Profile7ClassLibrary.ProfileDBContext _context;

        public AppointmentAuditsModel(Profile7ClassLibrary.ProfileDBContext context)
        {
            _context = context;
        }

        [BindProperty]
        public List<Appointmentaudit> Appointmentaudit { get;set; }

        [BindProperty]
        public List<data> dataSource { get; set; }

        public class data
        {
            public DateTime x;
            public double y;
            public double y1;
        }

        public async Task OnGetAsync()
        {
            Appointmentaudit = await _context.Appointmentaudit.Take(1).ToListAsync();
            dataSource = (from p in Appointmentaudit select new data { x = p.ApadDatetime, y = Convert.ToDouble(p.ApadDuration), y1= Convert.ToDouble(p.ApadDuration + 10) }).ToList<data>();

            //            Appointmentaudit = _context.Appointmentaudit.Take(50).ToList();
            //.Include(a => a.Apnt)
            //.Include(a => a.PppuIdUserNavigation)
            //.Include(a => a.Ptnt).ToListAsync();
        }
    }
}
