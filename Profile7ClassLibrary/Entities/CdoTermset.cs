using System;
using System.Collections.Generic;

namespace Profile7ClassLibrary.Entities
{
    public partial class CdoTermset
    {
        public CdoTermset()
        {
            CdoTermsetConcept = new HashSet<CdoTermsetConcept>();
            CdoTermsetTerm = new HashSet<CdoTermsetTerm>();
        }

        public long Oid { get; set; }
        public string Name { get; set; }
        public long? Hierarchical { get; set; }
        public DateTime? Created { get; set; }
        public long? Createdby { get; set; }
        public long? Organization { get; set; }
        public string Comment { get; set; }
        public string Maxcode { get; set; }
        public long PartitionId { get; set; }
        public string RefSys { get; set; }
        public string RefId { get; set; }
        public DateTime DtModified { get; set; }
        public string Code { get; set; }
        public long? Copyrights { get; set; }
        public string ObjGuid { get; set; }

        public Blobs CopyrightsNavigation { get; set; }
        public CdoPerson CreatedbyNavigation { get; set; }
        public CdoOrganization OrganizationNavigation { get; set; }
        public ICollection<CdoTermsetConcept> CdoTermsetConcept { get; set; }
        public ICollection<CdoTermsetTerm> CdoTermsetTerm { get; set; }
    }
}
