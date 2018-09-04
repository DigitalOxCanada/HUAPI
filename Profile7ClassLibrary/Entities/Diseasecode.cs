using System;
using System.Collections.Generic;

namespace Profile7ClassLibrary.Entities
{
    public partial class Diseasecode
    {
        public Diseasecode()
        {
            BcaseCaseInitDiag = new HashSet<Bcase>();
            BcasePresentationNavigation = new HashSet<Bcase>();
            BcaseSepDiag = new HashSet<Bcase>();
            PatientproblemIndication = new HashSet<Patientproblem>();
            PatientproblemPaprDx = new HashSet<Patientproblem>();
        }

        public long DscdId { get; set; }
        public string DscdCode { get; set; }
        public string DscdDescription { get; set; }
        public long DscdSystem { get; set; }
        public string DscdSystemcode { get; set; }
        public string DscdOutputcode { get; set; }
        public string DscdKeywords { get; set; }
        public long? DscdGroup { get; set; }
        public long DscdDeletedid { get; set; }
        public long? Concept { get; set; }
        public long? Term { get; set; }
        public long? Conceptcid { get; set; }
        public long? ConceptoidMon1 { get; set; }
        public long? TermoidMon1 { get; set; }
        public long? ConceptcidMon1 { get; set; }
        public long? ConceptoidMon2 { get; set; }
        public long? TermoidMon2 { get; set; }
        public long? ConceptcidMon2 { get; set; }
        public DateTime Changed { get; set; }
        public long? DscdTravelDisease { get; set; }
        public long PartitionId { get; set; }
        public string RefSys { get; set; }
        public string RefId { get; set; }
        public DateTime DtModified { get; set; }
        public long DscdType { get; set; }
        public string DscdUrl { get; set; }
        public string ObjGuid { get; set; }
        public long? Modifiedby { get; set; }
        public long DscdSysid { get; set; }

        public CdoTermsetConcept ConceptNavigation { get; set; }
        public CdoTermsetConcept ConceptoidMon1Navigation { get; set; }
        public CdoTermsetConcept ConceptoidMon2Navigation { get; set; }
        public Shortcode DscdGroupNavigation { get; set; }
        public CdoTermsetConcept DscdTravelDiseaseNavigation { get; set; }
        public Pppu ModifiedbyNavigation { get; set; }
        public CdoTermsetTerm TermNavigation { get; set; }
        public CdoTermsetTerm TermoidMon1Navigation { get; set; }
        public CdoTermsetTerm TermoidMon2Navigation { get; set; }
        public ICollection<Bcase> BcaseCaseInitDiag { get; set; }
        public ICollection<Bcase> BcasePresentationNavigation { get; set; }
        public ICollection<Bcase> BcaseSepDiag { get; set; }
        public ICollection<Patientproblem> PatientproblemIndication { get; set; }
        public ICollection<Patientproblem> PatientproblemPaprDx { get; set; }
    }
}
