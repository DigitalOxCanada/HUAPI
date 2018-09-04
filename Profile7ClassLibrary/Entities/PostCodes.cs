using System;
using System.Collections.Generic;

namespace Profile7ClassLibrary.Entities
{
    public partial class PostCodes
    {
        public long Oid { get; set; }
        public long Cid { get; set; }
        public string Postcode { get; set; }
        public long? State { get; set; }
        public string Addr2 { get; set; }
        public string Addr3 { get; set; }
        public long Country { get; set; }
        public string GeoX { get; set; }
        public string GeoY { get; set; }
        public string GeoMeshblock { get; set; }
        public long PartitionId { get; set; }
        public string RefSys { get; set; }
        public string RefId { get; set; }
        public DateTime DtModified { get; set; }
        public double GeoLatitude { get; set; }
        public double GeoLongitude { get; set; }
        public string StreetName { get; set; }
        public string OldPostcode { get; set; }
        public long? Deletedid { get; set; }
        public string ObjGuid { get; set; }

        public Lookuplist StateNavigation { get; set; }
    }
}
