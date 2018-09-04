using System;
using System.Collections.Generic;

namespace Profile7ClassLibrary.Entities
{
    public partial class CdoTermsetConcept
    {
        public CdoTermsetConcept()
        {
            BcaseOriginationNavigation = new HashSet<Bcase>();
            BcaseSourceNavigation = new HashSet<Bcase>();
            CdoTransdataConceptNavigation = new HashSet<CdoTransdata>();
            CdoTransdataConceptvalueNavigation = new HashSet<CdoTransdata>();
            DiseasecodeConceptNavigation = new HashSet<Diseasecode>();
            DiseasecodeConceptoidMon1Navigation = new HashSet<Diseasecode>();
            DiseasecodeConceptoidMon2Navigation = new HashSet<Diseasecode>();
            DiseasecodeDscdTravelDiseaseNavigation = new HashSet<Diseasecode>();
            PatientproblemPaprAnatomy = new HashSet<Patientproblem>();
            PatientproblemPaprLocation = new HashSet<Patientproblem>();
            PatientrecallvisitPrvsSpecialtyconcept = new HashSet<Patientrecallvisit>();
            PatientrecallvisitPrvsSpecialtytypeconcept = new HashSet<Patientrecallvisit>();
            PppuPppuSpecialtyconcept = new HashSet<Pppu>();
            PppuPppuTypeconcept = new HashSet<Pppu>();
        }

        public long Oid { get; set; }
        public string Status { get; set; }
        public long Cid { get; set; }
        public DateTime? Created { get; set; }
        public long? Createdby { get; set; }
        public long? Organization { get; set; }
        public long Termset { get; set; }
        public string Code { get; set; }
        public long PartitionId { get; set; }
        public string RefSys { get; set; }
        public string RefId { get; set; }
        public DateTime DtModified { get; set; }
        public long Prefterm { get; set; }
        public string ObjGuid { get; set; }

        public CdoPerson CreatedbyNavigation { get; set; }
        public CdoOrganization OrganizationNavigation { get; set; }
        public CdoTermsetTerm PreftermNavigation { get; set; }
        public CdoTermset TermsetNavigation { get; set; }
        public ICollection<Bcase> BcaseOriginationNavigation { get; set; }
        public ICollection<Bcase> BcaseSourceNavigation { get; set; }
        public ICollection<CdoTransdata> CdoTransdataConceptNavigation { get; set; }
        public ICollection<CdoTransdata> CdoTransdataConceptvalueNavigation { get; set; }
        public ICollection<Diseasecode> DiseasecodeConceptNavigation { get; set; }
        public ICollection<Diseasecode> DiseasecodeConceptoidMon1Navigation { get; set; }
        public ICollection<Diseasecode> DiseasecodeConceptoidMon2Navigation { get; set; }
        public ICollection<Diseasecode> DiseasecodeDscdTravelDiseaseNavigation { get; set; }
        public ICollection<Patientproblem> PatientproblemPaprAnatomy { get; set; }
        public ICollection<Patientproblem> PatientproblemPaprLocation { get; set; }
        public ICollection<Patientrecallvisit> PatientrecallvisitPrvsSpecialtyconcept { get; set; }
        public ICollection<Patientrecallvisit> PatientrecallvisitPrvsSpecialtytypeconcept { get; set; }
        public ICollection<Pppu> PppuPppuSpecialtyconcept { get; set; }
        public ICollection<Pppu> PppuPppuTypeconcept { get; set; }
    }
}
