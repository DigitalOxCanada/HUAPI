using System;
using System.Collections.Generic;

namespace Profile7ClassLibrary.Entities
{
    public partial class Pppuimage
    {
        public long PppuId { get; set; }
        public byte[] PuimBitmap { get; set; }
        public long PartitionId { get; set; }
        public string RefSys { get; set; }
        public string RefId { get; set; }
        public DateTime DtModified { get; set; }
        public string ObjGuid { get; set; }

        public Pppu Pppu { get; set; }
    }
}
