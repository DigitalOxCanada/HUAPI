using System;
using System.Collections.Generic;

namespace Profile7ClassLibrary.Entities
{
    public partial class Alias
    {
        public string AlisCode { get; set; }
        public long ColourId { get; set; }
        public long PartitionId { get; set; }
        public string RefSys { get; set; }
        public string RefId { get; set; }
        public DateTime DtModified { get; set; }
        public long Oid { get; set; }
        public string ObjGuid { get; set; }
        public long ObjectId { get; set; }
        public long ObjectType { get; set; }
    }
}
