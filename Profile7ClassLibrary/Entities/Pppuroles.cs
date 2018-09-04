using System;
using System.Collections.Generic;

namespace Profile7ClassLibrary.Entities
{
    public partial class Pppuroles
    {
        public long Cid { get; set; }
        public long Oid { get; set; }
        public long Pppuid { get; set; }
        public long Roleid { get; set; }
        public long Createdby { get; set; }
        public DateTime? Createddate { get; set; }
        public short Ishistoric { get; set; }
        public long PartitionId { get; set; }
        public string RefSys { get; set; }
        public string RefId { get; set; }
        public DateTime DtModified { get; set; }
        public string ObjGuid { get; set; }

        public Pppu CreatedbyNavigation { get; set; }
        public Pppu Pppu { get; set; }
        public CdoTermsetTerm Role { get; set; }
    }
}
