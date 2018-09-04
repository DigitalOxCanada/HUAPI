using System;
using System.Collections.Generic;

namespace Profile7ClassLibrary.Entities
{
    public partial class CdoOrganization
    {
        public CdoOrganization()
        {
            CdoTermset = new HashSet<CdoTermset>();
            CdoTermsetConcept = new HashSet<CdoTermsetConcept>();
            CdoTermsetTerm = new HashSet<CdoTermsetTerm>();
            CdoTransAqSourceNavigation = new HashSet<CdoTrans>();
            CdoTransOrganizationNavigation = new HashSet<CdoTrans>();
            InverseOrganizationNavigation = new HashSet<CdoOrganization>();
        }

        public long Oid { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Deleted { get; set; }
        public long? Createdby { get; set; }
        public long? Deletedby { get; set; }
        public string Name { get; set; }
        public string Contacts { get; set; }
        public long? Organization { get; set; }
        public long? Version { get; set; }
        public string Code { get; set; }
        public long PartitionId { get; set; }
        public string RefSys { get; set; }
        public string RefId { get; set; }
        public DateTime DtModified { get; set; }
        public string ObjGuid { get; set; }

        public CdoPerson CreatedbyNavigation { get; set; }
        public CdoPerson DeletedbyNavigation { get; set; }
        public CdoOrganization OrganizationNavigation { get; set; }
        public ICollection<CdoTermset> CdoTermset { get; set; }
        public ICollection<CdoTermsetConcept> CdoTermsetConcept { get; set; }
        public ICollection<CdoTermsetTerm> CdoTermsetTerm { get; set; }
        public ICollection<CdoTrans> CdoTransAqSourceNavigation { get; set; }
        public ICollection<CdoTrans> CdoTransOrganizationNavigation { get; set; }
        public ICollection<CdoOrganization> InverseOrganizationNavigation { get; set; }
    }
}
