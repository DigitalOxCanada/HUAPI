using System;
using System.Collections.Generic;

namespace Profile7ClassLibrary.Entities
{
    public partial class CaseAudit
    {
        public CaseAudit()
        {
            CaseAuditDetails = new HashSet<CaseAuditDetails>();
        }

        public long Oid { get; set; }
        public long? CaseId { get; set; }
        public long? PppuId { get; set; }
        public string Computername { get; set; }
        public DateTime? StartDatetime { get; set; }
        public DateTime? EndDatetime { get; set; }
        public string AccessCode { get; set; }
        public long PartitionId { get; set; }
        public string RefSys { get; set; }
        public string RefId { get; set; }
        public DateTime DtModified { get; set; }
        public string Ip { get; set; }
        public string UserText { get; set; }
        public string ObjGuid { get; set; }
        public long? ObserverPtntId { get; set; }

        public Bcase Case { get; set; }
        public Patient ObserverPtnt { get; set; }
        public Pppu Pppu { get; set; }
        public ICollection<CaseAuditDetails> CaseAuditDetails { get; set; }
    }
}
