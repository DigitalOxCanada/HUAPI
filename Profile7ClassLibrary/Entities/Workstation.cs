using System;
using System.Collections.Generic;

namespace Profile7ClassLibrary.Entities
{
    public partial class Workstation
    {
        public long WrksId { get; set; }
        public string WrksName { get; set; }
        public string WrksIpaddress { get; set; }
        public long PppuIdPos { get; set; }
        public long PartitionId { get; set; }
        public string RefSys { get; set; }
        public string RefId { get; set; }
        public DateTime DtModified { get; set; }
        public string ObjGuid { get; set; }

        public Pppu PppuIdPosNavigation { get; set; }
    }
}
