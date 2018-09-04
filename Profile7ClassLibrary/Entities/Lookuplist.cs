using System;
using System.Collections.Generic;

namespace Profile7ClassLibrary.Entities
{
    public partial class Lookuplist
    {
        public Lookuplist()
        {
            AddressNokRelationshipNavigation = new HashSet<Address>();
            AddressPostalstateNavigation = new HashSet<Address>();
            PatientLklsIdEthnicity2Navigation = new HashSet<Patient>();
            PatientLklsIdEthnicity3Navigation = new HashSet<Patient>();
            PatientLklsIdEthnicity4Navigation = new HashSet<Patient>();
            PatientLklsIdEthnicity5Navigation = new HashSet<Patient>();
            PatientLklsIdEthnicity6Navigation = new HashSet<Patient>();
            PatientLklsIdEthnicityNavigation = new HashSet<Patient>();
            PatientLklsIdMaritalstatusNavigation = new HashSet<Patient>();
            PatientLklsIdOccupationNavigation = new HashSet<Patient>();
            PatientLklsIdReligionNavigation = new HashSet<Patient>();
            PatientPtntLeadcarerelNavigation = new HashSet<Patient>();
            PatientPtntParent1relNavigation = new HashSet<Patient>();
            PatientPtntParent2relNavigation = new HashSet<Patient>();
            PatientPtntPostalstateNavigation = new HashSet<Patient>();
            PatientPtntStreetstateNavigation = new HashSet<Patient>();
            PatientPtntWorkstateNavigation = new HashSet<Patient>();
            PostCodes = new HashSet<PostCodes>();
            PppuPppuPostalstateNavigation = new HashSet<Pppu>();
            PppuPppuStreetstateNavigation = new HashSet<Pppu>();
        }

        public long LklsId { get; set; }
        public string LklsCode { get; set; }
        public string LklsDescription { get; set; }
        public long LklsType { get; set; }
        public long LklsDeletedid { get; set; }
        public DateTime? LklsChanged { get; set; }
        public long PartitionId { get; set; }
        public string RefSys { get; set; }
        public string RefId { get; set; }
        public DateTime DtModified { get; set; }
        public long? LklsTag { get; set; }
        public long? LklsTag2 { get; set; }
        public string ObjGuid { get; set; }

        public ICollection<Address> AddressNokRelationshipNavigation { get; set; }
        public ICollection<Address> AddressPostalstateNavigation { get; set; }
        public ICollection<Patient> PatientLklsIdEthnicity2Navigation { get; set; }
        public ICollection<Patient> PatientLklsIdEthnicity3Navigation { get; set; }
        public ICollection<Patient> PatientLklsIdEthnicity4Navigation { get; set; }
        public ICollection<Patient> PatientLklsIdEthnicity5Navigation { get; set; }
        public ICollection<Patient> PatientLklsIdEthnicity6Navigation { get; set; }
        public ICollection<Patient> PatientLklsIdEthnicityNavigation { get; set; }
        public ICollection<Patient> PatientLklsIdMaritalstatusNavigation { get; set; }
        public ICollection<Patient> PatientLklsIdOccupationNavigation { get; set; }
        public ICollection<Patient> PatientLklsIdReligionNavigation { get; set; }
        public ICollection<Patient> PatientPtntLeadcarerelNavigation { get; set; }
        public ICollection<Patient> PatientPtntParent1relNavigation { get; set; }
        public ICollection<Patient> PatientPtntParent2relNavigation { get; set; }
        public ICollection<Patient> PatientPtntPostalstateNavigation { get; set; }
        public ICollection<Patient> PatientPtntStreetstateNavigation { get; set; }
        public ICollection<Patient> PatientPtntWorkstateNavigation { get; set; }
        public ICollection<PostCodes> PostCodes { get; set; }
        public ICollection<Pppu> PppuPppuPostalstateNavigation { get; set; }
        public ICollection<Pppu> PppuPppuStreetstateNavigation { get; set; }
    }
}
