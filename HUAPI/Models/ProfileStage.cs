using System;
using System.ComponentModel.DataAnnotations;

namespace HUAPICore.Models
{
    public class ProfileStage
    {
    }

    public class ScrapeQueryRequest
    {
        [Required]
        public string FormName { get; set; }
        public string Group { get; set; } = "General";
        public int Order { get; set; } = 1000;
        public Boolean Active { get; set; } = false;
        public Boolean Insert { get; set; } = false;
    }

}
