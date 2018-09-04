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
        /// Settings in the database for on the live changing.
        /// </summary>
        public virtual DbSet<CustomSetting> HUAPISettings { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual DbSet<ScrapeQuery> ScrapeQuery { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual DbSet<FWLink> FWLink { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public virtual DbSet<SMSCarrier> SMSCarrier { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public virtual DbSet<StreetType> StreetTypes { get; set; }
    }
}
