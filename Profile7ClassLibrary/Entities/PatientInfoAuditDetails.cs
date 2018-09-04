using System;
using System.Collections.Generic;

namespace Profile7ClassLibrary.Entities
{
    public partial class PatientInfoAuditDetails
    {
        public long Oid { get; set; }
        public long PiadAuditId { get; set; }
        public long PiadType { get; set; }
        public string PiadDescription { get; set; }
        public long PartitionId { get; set; }
        public string RefSys { get; set; }
        public string RefId { get; set; }
        public DateTime DtModified { get; set; }
        public DateTime PiadAlertdate { get; set; }
        public string ObjGuid { get; set; }

        public PatientInfoAudit PiadAudit { get; set; }
    }
}
