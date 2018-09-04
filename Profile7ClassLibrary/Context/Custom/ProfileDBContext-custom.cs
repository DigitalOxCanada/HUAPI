using Microsoft.EntityFrameworkCore;
using Profile7ClassLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Profile7ClassLibrary
{

    public partial class ProfileDBContext : DbContext
    {
        /// <summary>
        /// 
        /// </summary>
        public virtual DbSet<CustomFormDef> CustomFormDef { get; set; }
    }

}
