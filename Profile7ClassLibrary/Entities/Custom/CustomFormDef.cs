using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Profile7ClassLibrary.Entities
{
    public class CustomFormDef
    {
        [Key]
        public long OID { get; set; }
        public string Description { get; set; }
        public DateTime? Created { get; set; }
        public long Version { get; set; }
        public string Code { get; set; }
    }
}
