using System;
using System.Collections.Generic;

namespace Profile7ClassLibrary.Entities
{
    public partial class PatientMergeLog
    {
        public long Oid { get; set; }
        public long Masterid { get; set; }
        public long Subid { get; set; }
        public DateTime CreatedOn { get; set; }
        public long CreatedBy { get; set; }
        public long Deletedid { get; set; }
        public long PartitionId { get; set; }
        public string RefSys { get; set; }
        public string RefId { get; set; }
        public DateTime DtModified { get; set; }
        public string ObjGuid { get; set; }

        public Pppu CreatedByNavigation { get; set; }
        public Patient Master { get; set; }
        public Patient Sub { get; set; }
    }
}
