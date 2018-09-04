using System;
using System.Collections.Generic;

namespace Profile7ClassLibrary.Entities
{
    public partial class CdoPersonImage
    {
        public long Oid { get; set; }
        public long PersonId { get; set; }
        public long? PimgType { get; set; }
        public string PimgMime { get; set; }
        public byte[] PimgData { get; set; }
        public long PartitionId { get; set; }
        public string RefSys { get; set; }
        public string RefId { get; set; }
        public DateTime DtModified { get; set; }
        public string ObjGuid { get; set; }

        public CdoPerson Person { get; set; }
    }
}
