using System;
using System.Collections.Generic;

namespace Profile7ClassLibrary.Entities
{
    public partial class Headline
    {
        public long Oid { get; set; }
        public long HlCategory { get; set; }
        public string HlShortdescr { get; set; }
        public long? HlImageindex { get; set; }
        public string HlSummary { get; set; }
        public short HlInactive { get; set; }
        public string HlUrl { get; set; }
        public DateTime? HlDateFrom { get; set; }
        public DateTime? HlDateTo { get; set; }
        public short HlShowOnce { get; set; }
        public short HlRequireAck { get; set; }
        public long? HlOrganisation { get; set; }
        public long Deletedid { get; set; }
        public long PartitionId { get; set; }
        public string RefSys { get; set; }
        public string RefId { get; set; }
        public DateTime DtModified { get; set; }
        public byte[] HlDeatailed { get; set; }
        public long? HlHeadlineType { get; set; }
        public string ObjGuid { get; set; }
        public long HlOrder { get; set; }

        public Shortcode HlCategoryNavigation { get; set; }
        public OrgStructure HlOrganisationNavigation { get; set; }
    }
}
