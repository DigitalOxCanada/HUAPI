using System;
using System.Collections.Generic;

namespace Profile7ClassLibrary.Entities
{
    public partial class Bcase
    {
        public Bcase()
        {
            Appointment = new HashSet<Appointment>();
            CareTeam = new HashSet<CareTeam>();
            CaseAudit = new HashSet<CaseAudit>();
            CaseMergeLogMaster = new HashSet<CaseMergeLog>();
            CaseMergeLogSub = new HashSet<CaseMergeLog>();
            CdoTrans = new HashSet<CdoTrans>();
            ContactActionLink = new HashSet<ContactActionLink>();
            Patientproblem = new HashSet<Patientproblem>();
            Patientrecallvisit = new HashSet<Patientrecallvisit>();
        }

        public long Oid { get; set; }
        public long Cid { get; set; }
        public long CreatorId { get; set; }
        public DateTime CreatedOn { get; set; }
        public long? AlteredById { get; set; }
        public DateTime? AlteredOn { get; set; }
        public long PatientId { get; set; }
        public long Status { get; set; }
        public DateTime? OpenedOn { get; set; }
        public string CaseTitle { get; set; }
        public long? RefCid { get; set; }
        public long? RefOid { get; set; }
        public long? ServicePosId { get; set; }
        public long? LeadProvId { get; set; }
        public long? CaseMngrId { get; set; }
        public long? SepDiagId { get; set; }
        public long? SepServiceId { get; set; }
        public long? SepOutcomeId { get; set; }
        public DateTime? ClosedOn { get; set; }
        public long? CaseInitDiagId { get; set; }
        public long? Condition { get; set; }
        public string CarePlan { get; set; }
        public long? Presentation { get; set; }
        public long? RoleOid { get; set; }
        public long? Source { get; set; }
        public long? Origination { get; set; }
        public string Reason { get; set; }
        public long? ShcdPriorityid { get; set; }
        public long? ShcdDischargedtoid { get; set; }
        public DateTime? Firstvisit { get; set; }
        public long? CasemixInitial { get; set; }
        public long? CasemixFinal { get; set; }
        public string CasemixComm { get; set; }
        public long? RoleOidAdmin { get; set; }
        public string Referrer { get; set; }
        public long? ShcdSource1 { get; set; }
        public long? ShcdSource2 { get; set; }
        public DateTime? Source2date { get; set; }
        public long Deletedid { get; set; }
        public long? ShcdCaserisk { get; set; }
        public string RelevantInf { get; set; }
        public long? OrgStructureId { get; set; }
        public long? ForceCase { get; set; }
        public long? CaseSettings { get; set; }
        public short CaseAvailInAccession { get; set; }
        public string Sourceref { get; set; }
        public DateTime? Source1date { get; set; }
        public long PartitionId { get; set; }
        public string RefSys { get; set; }
        public string RefId { get; set; }
        public DateTime DtModified { get; set; }
        public long? CaseRoleId { get; set; }
        public long? CaseTemplate { get; set; }
        public long? PrivacyPppuId { get; set; }
        public long? PrivacyOrg { get; set; }
        public long? Financial { get; set; }
        public string ObjGuid { get; set; }

        public Pppu AlteredBy { get; set; }
        public Diseasecode CaseInitDiag { get; set; }
        public Pppu CaseMngr { get; set; }
        public AppRole CaseRole { get; set; }
        public Shortcode CaseSettingsNavigation { get; set; }
        public CaseTemplates CaseTemplateNavigation { get; set; }
        public Shortcode ConditionNavigation { get; set; }
        public Pppu Creator { get; set; }
        public OrgStructure ForceCaseNavigation { get; set; }
        public Pppu LeadProv { get; set; }
        public OrgStructure OrgStructure { get; set; }
        public CdoTermsetConcept OriginationNavigation { get; set; }
        public Patient Patient { get; set; }
        public Diseasecode PresentationNavigation { get; set; }
        public Pppu PrivacyPppu { get; set; }
        public AppRole RoleO { get; set; }
        public AppRole RoleOidAdminNavigation { get; set; }
        public Diseasecode SepDiag { get; set; }
        public Shortcode SepOutcome { get; set; }
        public Pppu ServicePos { get; set; }
        public Shortcode ShcdCaseriskNavigation { get; set; }
        public Shortcode ShcdDischargedto { get; set; }
        public Shortcode ShcdPriority { get; set; }
        public Shortcode ShcdSource1Navigation { get; set; }
        public Shortcode ShcdSource2Navigation { get; set; }
        public CdoTermsetConcept SourceNavigation { get; set; }
        public ICollection<Appointment> Appointment { get; set; }
        public ICollection<CareTeam> CareTeam { get; set; }
        public ICollection<CaseAudit> CaseAudit { get; set; }
        public ICollection<CaseMergeLog> CaseMergeLogMaster { get; set; }
        public ICollection<CaseMergeLog> CaseMergeLogSub { get; set; }
        public ICollection<CdoTrans> CdoTrans { get; set; }
        public ICollection<ContactActionLink> ContactActionLink { get; set; }
        public ICollection<Patientproblem> Patientproblem { get; set; }
        public ICollection<Patientrecallvisit> Patientrecallvisit { get; set; }
    }
}
