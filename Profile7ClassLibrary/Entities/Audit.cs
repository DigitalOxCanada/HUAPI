using System;
using System.Collections.Generic;

namespace Profile7ClassLibrary.Entities
{
    public partial class Audit
    {
        public long AudtId { get; set; }
        public DateTime? AudtDate { get; set; }
        public string AudtAction { get; set; }
        public string AudtLogoncomputer { get; set; }
        public string AudtLogoncode { get; set; }
        public long? AudtResultcode { get; set; }
        public long? AudtSecurityc { get; set; }
        public long? AudtSecurityf { get; set; }
        public long? AudtPppuId { get; set; }
        public string AudtNic { get; set; }
        public DateTime? AudtLogoffDate { get; set; }
        public long PartitionId { get; set; }
        public string RefSys { get; set; }
        public string RefId { get; set; }
        public DateTime DtModified { get; set; }
        public string AuditIp { get; set; }
        public string UserText { get; set; }
        public string ObjGuid { get; set; }

        public Pppu AudtPppu { get; set; }
    }
}
