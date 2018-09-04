using System;
using System.Collections.Generic;

namespace Profile7ClassLibrary.Entities
{
    public partial class CdoTermsetTerm
    {
        public CdoTermsetTerm()
        {
            CdoTermsetConcept = new HashSet<CdoTermsetConcept>();
            CdoTransdata = new HashSet<CdoTransdata>();
            DiseasecodeTermNavigation = new HashSet<Diseasecode>();
            DiseasecodeTermoidMon1Navigation = new HashSet<Diseasecode>();
            DiseasecodeTermoidMon2Navigation = new HashSet<Diseasecode>();
            Pppuroles = new HashSet<Pppuroles>();
        }

        public long Oid { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }
        public string Upperdescription { get; set; }
        public DateTime? Created { get; set; }
        public long? Createdby { get; set; }
        public long? Organization { get; set; }
        public long Termset { get; set; }
        public string Code { get; set; }
        public string Plural { get; set; }
        public long PartitionId { get; set; }
        public string RefSys { get; set; }
        public string RefId { get; set; }
        public DateTime DtModified { get; set; }
        public string ObjGuid { get; set; }

        public CdoPerson CreatedbyNavigation { get; set; }
        public CdoOrganization OrganizationNavigation { get; set; }
        public CdoTermset TermsetNavigation { get; set; }
        public ICollection<CdoTermsetConcept> CdoTermsetConcept { get; set; }
        public ICollection<CdoTransdata> CdoTransdata { get; set; }
        public ICollection<Diseasecode> DiseasecodeTermNavigation { get; set; }
        public ICollection<Diseasecode> DiseasecodeTermoidMon1Navigation { get; set; }
        public ICollection<Diseasecode> DiseasecodeTermoidMon2Navigation { get; set; }
        public ICollection<Pppuroles> Pppuroles { get; set; }
    }
}
