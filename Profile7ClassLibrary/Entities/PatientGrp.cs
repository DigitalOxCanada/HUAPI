using System;
using System.Collections.Generic;

namespace Profile7ClassLibrary.Entities
{
    public partial class PatientGrp
    {
        public long Oid { get; set; }
        public long Cid { get; set; }
        public string Descr { get; set; }
        public long PppuId { get; set; }
        public long? GrpRange { get; set; }
        public DateTime? GrpFromdate { get; set; }
        public DateTime? GrpTodate { get; set; }
        public long PartitionId { get; set; }
        public string RefSys { get; set; }
        public string RefId { get; set; }
        public DateTime DtModified { get; set; }
        public string ObjGuid { get; set; }

        public Pppu Pppu { get; set; }
    }
}
