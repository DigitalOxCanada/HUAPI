using System;
using System.Collections.Generic;

namespace Profile7ClassLibrary.Entities
{
    public partial class CaseAuditDetails
    {
        public long Oid { get; set; }
        public long CadAuditId { get; set; }
        public long CadType { get; set; }
        public string CadDescription { get; set; }
        public long PartitionId { get; set; }
        public string RefSys { get; set; }
        public string RefId { get; set; }
        public DateTime DtModified { get; set; }
        public DateTime CadAlertdate { get; set; }
        public string ObjGuid { get; set; }

        public CaseAudit CadAudit { get; set; }
    }
}
