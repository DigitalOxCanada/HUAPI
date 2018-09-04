using System;
using System.Collections.Generic;

namespace Profile7ClassLibrary.Entities
{
    public partial class UserSecurityLog
    {
        public long Oid { get; set; }
        public long UslUserid { get; set; }
        public long? UslPatientid { get; set; }
        public DateTime UslCreated { get; set; }
        public long UslCategoryid { get; set; }
        public long UslEntryid { get; set; }
        public string UslDetails { get; set; }
        public byte[] UslDetailsExt { get; set; }
        public long PartitionId { get; set; }
        public string RefSys { get; set; }
        public string RefId { get; set; }
        public DateTime DtModified { get; set; }
        public string UslIp { get; set; }
        public string UslComputername { get; set; }
        public long? UslChangedUser { get; set; }
        public string ObjGuid { get; set; }

        public Shortcode UslCategory { get; set; }
        public Pppu UslChangedUserNavigation { get; set; }
        public Shortcode UslEntry { get; set; }
        public Patient UslPatient { get; set; }
        public Pppu UslUser { get; set; }
    }
}
