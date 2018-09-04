using System;
using System.Collections.Generic;

namespace Profile7ClassLibrary.Entities
{
    public partial class Patientrecallvisit
    {
        public Patientrecallvisit()
        {
            Appointment = new HashSet<Appointment>();
            InverseMaster = new HashSet<Patientrecallvisit>();
            InversePrvsParent = new HashSet<Patientrecallvisit>();
        }

        public long PrvsId { get; set; }
        public long PrvsPrplId { get; set; }
        public DateTime? PrvsDate { get; set; }
        public DateTime? PrvsDatecompleted { get; set; }
        public long PrvsStatus { get; set; }
        public string PrvsComment { get; set; }
        public long? PrvsPppuId { get; set; }
        public short PrvsIsdateseen { get; set; }
        public DateTime? PrvsDateseen { get; set; }
        public short PrvsIsadjustfrequency { get; set; }
        public long? PrvsAdjustfrequency { get; set; }
        public long? PrvsAdjustunit { get; set; }
        public short PrvsIsnextvisitdate { get; set; }
        public DateTime? PrvsNextvisitdate { get; set; }
        public string PrvsClash { get; set; }
        public long? PrvsWindows { get; set; }
        public string PrvsDescription { get; set; }
        public long? ContactOid { get; set; }
        public long? PrvsExplanationid { get; set; }
        public DateTime? PrvsDateconcluded { get; set; }
        public short PrvsIshistorysummary { get; set; }
        public short PrvsRepeatmade { get; set; }
        public long? PrvsSrvcId { get; set; }
        public long? PrvsCaseId { get; set; }
        public DateTime Changed { get; set; }
        public long? PrvsContactId { get; set; }
        public long? PrvsVisittemplateId { get; set; }
        public short PrvsDatematchesplan { get; set; }
        public long? CarevisitId { get; set; }
        public long? PrvsPerformedbyId { get; set; }
        public short PrvsMoveduedate { get; set; }
        public short PrvsForceontoinvoice { get; set; }
        public short PrvsIscreatedwithrefdate { get; set; }
        public long? PrvsParentId { get; set; }
        public long? PrvsRecallobjectiveId { get; set; }
        public long? PrvsExtproviderId { get; set; }
        public long? PrvsPppuPosId { get; set; }
        public long? PrvsShcdVisittypeId { get; set; }
        public long? PrvsPrivacyroleId { get; set; }
        public long? PrvsProvidertype { get; set; }
        public short PrvsIscompleteformflag { get; set; }
        public long? ShcdCompleteformid { get; set; }
        public string PrvsNextvisitnote { get; set; }
        public long? PrvsPerformedbyExtprovid { get; set; }
        public long? PrvsPerformedbyType { get; set; }
        public long? PrvsRecallrecurrenceId { get; set; }
        public long? PrvsMentalEvent { get; set; }
        public string PrvsSourceref { get; set; }
        public long? PrvsExternalVisitType { get; set; }
        public long PartitionId { get; set; }
        public string RefSys { get; set; }
        public string RefId { get; set; }
        public DateTime DtModified { get; set; }
        public long MasterId { get; set; }
        public long Version { get; set; }
        public DateTime Created { get; set; }
        public DateTime Deleted { get; set; }
        public long? Createdby { get; set; }
        public long? Deletedby { get; set; }
        public long? PrvsPriorityid { get; set; }
        public long PrvsApprovalStatus { get; set; }
        public short PrvsHold { get; set; }
        public string ObjGuid { get; set; }
        public string PrvsApproxConclDate { get; set; }
        public long? PrvsSpecialtytypeconceptId { get; set; }
        public long? PrvsSpecialtyconceptId { get; set; }
        public long? PrivacyPppuId { get; set; }
        public long? PrivacyOrg { get; set; }
        public long? PrvsOtherPatientId { get; set; }
        public long? PrvsPerformedbyPatientId { get; set; }
        public string PrvsPerformedbyAdhoc { get; set; }
        public long? ExternalEntityId { get; set; }

        public CdoTransdata ContactO { get; set; }
        public CdoPerson CreatedbyNavigation { get; set; }
        public CdoPerson DeletedbyNavigation { get; set; }
        public Patientrecallvisit Master { get; set; }
        public Pppu PrivacyPppu { get; set; }
        public Bcase PrvsCase { get; set; }
        public CdoTransdata PrvsContact { get; set; }
        public Shortcode PrvsExplanation { get; set; }
        public Pppu PrvsExtprovider { get; set; }
        public Patient PrvsOtherPatient { get; set; }
        public Patientrecallvisit PrvsParent { get; set; }
        public Pppu PrvsPerformedby { get; set; }
        public Pppu PrvsPerformedbyExtprov { get; set; }
        public Patient PrvsPerformedbyPatient { get; set; }
        public Pppu PrvsPppu { get; set; }
        public Pppu PrvsPppuPos { get; set; }
        public Shortcode PrvsPriority { get; set; }
        public AppRole PrvsPrivacyrole { get; set; }
        public Shortcode PrvsShcdVisittype { get; set; }
        public CdoTermsetConcept PrvsSpecialtyconcept { get; set; }
        public CdoTermsetConcept PrvsSpecialtytypeconcept { get; set; }
        public Shortcode ShcdCompleteform { get; set; }
        public ICollection<Appointment> Appointment { get; set; }
        public ICollection<Patientrecallvisit> InverseMaster { get; set; }
        public ICollection<Patientrecallvisit> InversePrvsParent { get; set; }
    }
}
