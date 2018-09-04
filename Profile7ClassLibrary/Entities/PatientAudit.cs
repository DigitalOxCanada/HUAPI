using System;
using System.Collections.Generic;

namespace Profile7ClassLibrary.Entities
{
    public partial class PatientAudit
    {
        public long PaudtId { get; set; }
        public long? PaudtPtntId { get; set; }
        public long? PaudtPppuId { get; set; }
        public string PaudtComputername { get; set; }
        public DateTime? PaudtStartDatetime { get; set; }
        public DateTime? PaudtEndDatetime { get; set; }
        public long PartitionId { get; set; }
        public string RefSys { get; set; }
        public string RefId { get; set; }
        public DateTime DtModified { get; set; }
        public string PaudtIp { get; set; }
        public string UserText { get; set; }
        public string ObjGuid { get; set; }
        public long? ObserverPtntId { get; set; }

        public Patient ObserverPtnt { get; set; }
        public Pppu PaudtPppu { get; set; }
        public Patient PaudtPtnt { get; set; }
    }
}
