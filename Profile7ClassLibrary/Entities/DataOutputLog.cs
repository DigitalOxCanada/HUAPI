using System;
using System.Collections.Generic;

namespace Profile7ClassLibrary.Entities
{
    public partial class DataOutputLog
    {
        public long Oid { get; set; }
        public long DolUserId { get; set; }
        public long DolActionType { get; set; }
        public DateTime? DolStartDateTime { get; set; }
        public string DolDescription { get; set; }
        public long PartitionId { get; set; }
        public string RefSys { get; set; }
        public string RefId { get; set; }
        public DateTime DtModified { get; set; }
        public string ObjGuid { get; set; }

        public Pppu DolUser { get; set; }
    }
}
