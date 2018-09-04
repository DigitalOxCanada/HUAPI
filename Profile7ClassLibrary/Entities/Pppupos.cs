using System;
using System.Collections.Generic;

namespace Profile7ClassLibrary.Entities
{
    public partial class Pppupos
    {
        public long PppuId { get; set; }
        public long PppuPosId { get; set; }
        public long? PppuPosReferencesystem { get; set; }
        public string PppuPosReferencecode { get; set; }
        public string PayeeId { get; set; }
        public long PartitionId { get; set; }
        public string RefSys { get; set; }
        public string RefId { get; set; }
        public DateTime DtModified { get; set; }
        public long Oid { get; set; }
        public long PppuPosMethod { get; set; }
        public string CorePayeeId { get; set; }
        public DateTime PppuPosDatefrom { get; set; }
        public DateTime? PppuPosDateto { get; set; }
        public short PppuPosHold { get; set; }
        public long? PppuPosRrpScc { get; set; }
        public long? PppuPosMspOptOut { get; set; }
        public string ObjGuid { get; set; }
        public long? PppuPosTopRole { get; set; }
        public short PppuPosIsgroupacct { get; set; }

        public Pppu Pppu { get; set; }
        public Pppu PppuPos { get; set; }
        public Shortcode PppuPosReferencesystemNavigation { get; set; }
        public Shortcode PppuPosRrpSccNavigation { get; set; }
        public AppRole PppuPosTopRoleNavigation { get; set; }
    }
}
