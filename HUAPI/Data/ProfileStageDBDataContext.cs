using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using HUAPICore.Models;

namespace HUAPICore.Data
{
    //TODO move this to separate project and then create a DAL like the others
    public partial class ProfileStageDBDataContext : DbContext
    {
        public ProfileStageDBDataContext(DbContextOptions<ProfileStageDBDataContext> options) : base(options)
        {
        }

        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
