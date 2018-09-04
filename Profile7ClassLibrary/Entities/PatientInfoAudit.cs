using System;
using System.Collections.Generic;

namespace Profile7ClassLibrary.Entities
{
    public partial class PatientInfoAudit
    {
        public PatientInfoAudit()
        {
            PatientInfoAuditDetails = new HashSet<PatientInfoAuditDetails>();
        }

        public long Oid { get; set; }
        public long PiaudPtntId { get; set; }
        public long PiaudPppuId { get; set; }
        public string PiaudComputername { get; set; }
        public string PiaudIp { get; set; }
        public DateTime? PiaudStartDatetime { get; set; }
        public DateTime? PiaudEndDatetime { get; set; }
        public long PartitionId { get; set; }
        public string RefSys { get; set; }
        public string RefId { get; set; }
        public DateTime DtModified { get; set; }
        public string UserText { get; set; }
        public string ObjGuid { get; set; }
        public long? ObserverPtntId { get; set; }

        public Patient ObserverPtnt { get; set; }
        public Pppu PiaudPppu { get; set; }
        public Patient PiaudPtnt { get; set; }
        public ICollection<PatientInfoAuditDetails> PatientInfoAuditDetails { get; set; }
    }
}
