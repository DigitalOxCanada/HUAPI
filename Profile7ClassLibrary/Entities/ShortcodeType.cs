using System;
using System.Collections.Generic;

namespace Profile7ClassLibrary.Entities
{
    public partial class ShortcodeType
    {
        public ShortcodeType()
        {
            InverseParentType = new HashSet<ShortcodeType>();
            Shortcode = new HashSet<Shortcode>();
        }

        public long Oid { get; set; }
        public string Name { get; set; }
        public short Editable { get; set; }
        public long Deletedid { get; set; }
        public long? Category { get; set; }
        public long PartitionId { get; set; }
        public string RefSys { get; set; }
        public string RefId { get; set; }
        public DateTime DtModified { get; set; }
        public string ObjGuid { get; set; }
        public long? ParentTypeId { get; set; }

        public ShortcodeType ParentType { get; set; }
        public ICollection<ShortcodeType> InverseParentType { get; set; }
        public ICollection<Shortcode> Shortcode { get; set; }
    }
}
