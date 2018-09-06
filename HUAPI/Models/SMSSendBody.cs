using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HUAPICore.Models
{
    /// <summary>
    /// body used for Post
    /// </summary>
    public class SMSSendBody
    {
        public string number { get; set; }
        public string message { get; set; }
        public string region { get; set; } = "Canada";
        public DateTime when { get; set; } = DateTime.Now;
    }

}
