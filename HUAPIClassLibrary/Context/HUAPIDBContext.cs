using Microsoft.EntityFrameworkCore;

namespace HUAPIClassLibrary
{
    /// <summary>
    /// ARS Database Context
    /// </summary>
    public partial class HUAPIDBContext : DbContext
    { 
        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="options"></param>
        public HUAPIDBContext(DbContextOptions<HUAPIDBContext> options) : base(options)
        {
        }

        /// <summary>
        /// Settings in the database for on the fly changing.
        /// </summary>
        public virtual DbSet<CustomSetting> HUAPISettings { get; set; }

        /// <summary>
        /// Scraping Queries for nightly scraping routine.
        /// </summary>
        public virtual DbSet<ScrapeQuery> ScrapeQuery { get; set; }

        /// <summary>
        /// Forwarding links.
        /// </summary>
        public virtual DbSet<FWLink> FWLink { get; set; }
        
        /// <summary>
        /// List of carriers for the SMS exchange option.
        /// </summary>
        public virtual DbSet<SMSCarrier> SMSCarrier { get; set; }
        
        /// <summary>
        /// Street types list used for patient demographics.
        /// </summary>
        public virtual DbSet<StreetType> StreetTypes { get; set; }
    }
}
