using System;
using System.Collections.Generic;

namespace Profile7ClassLibrary.Entities
{
    public partial class ViewAudit
    {
        public ViewAudit()
        {
            InverseVaudParentNavigation = new HashSet<ViewAudit>();
        }

        public long Oid { get; set; }
        public long VaudRootParentCid { get; set; }
        public long VaudRootParentOid { get; set; }
        public long? VaudParent { get; set; }
        public DateTime? VaudEntryTime { get; set; }
        public DateTime? VaudExitTime { get; set; }
        public string VaudFilterName { get; set; }
        public long PartitionId { get; set; }
        public string RefSys { get; set; }
        public string RefId { get; set; }
        public DateTime DtModified { get; set; }
        public long? VaudKind { get; set; }
        public long? VaudViewIndex { get; set; }
        public long? VaudObjectCid { get; set; }
        public long? VaudObjectOid { get; set; }
        public string ObjGuid { get; set; }

        public ViewAudit VaudParentNavigation { get; set; }
        public ICollection<ViewAudit> InverseVaudParentNavigation { get; set; }
    }
}
