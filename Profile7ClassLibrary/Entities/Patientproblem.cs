using System;
using System.Collections.Generic;

namespace Profile7ClassLibrary.Entities
{
    public partial class Patientproblem
    {
        public Patientproblem()
        {
            InversePaprCoMorbidToNavigation = new HashSet<Patientproblem>();
        }

        public long PaprId { get; set; }
        public long PtntId { get; set; }
        public DateTime PaprDatetimeadded { get; set; }
        public long PaprPppuidadded { get; set; }
        public DateTime? PaprDatetimealtered { get; set; }
        public long? PaprPppuidaltered { get; set; }
        public DateTime PaprDate { get; set; }
        public DateTime? PaprTodate { get; set; }
        public long? PaprTypeid { get; set; }
        public long? PaprPrivacyid { get; set; }
        public long? PaprStatusid { get; set; }
        public long? PaprConfidenceid { get; set; }
        public long? PaprDxid { get; set; }
        public string PaprDxdescription { get; set; }
        public long? ExprId { get; set; }
        public string PaprExtprovname { get; set; }
        public long? PaprDeletedid { get; set; }
        public short PaprAlert { get; set; }
        public byte[] PaprCommentBlob { get; set; }
        public long? PaprPrivateToPos { get; set; }
        public long? PaprProviderId { get; set; }
        public long PaprInsyncValid { get; set; }
        public long? RoleOid { get; set; }
        public string PaprInsyncDisStrmCode { get; set; }
        public long? PaprPresentationId { get; set; }
        public long? PaprAnatomyId { get; set; }
        public long? PaprLocationId { get; set; }
        public long? PaprSeverityId { get; set; }
        public string PaprNature { get; set; }
        public string PaprHospitalname { get; set; }
        public long? CaseId { get; set; }
        public short PaprPrincipal { get; set; }
        public long? PaprOutcomeid { get; set; }
        public byte[] PaprComment2Blob { get; set; }
        public long? PaprDxnature { get; set; }
        public long? PaprAlertscope { get; set; }
        public long? PaprAlertorganisation { get; set; }
        public string Code { get; set; }
        public DateTime Created { get; set; }
        public DateTime Deleted { get; set; }
        public long? Createdby { get; set; }
        public long? Deletedby { get; set; }
        public long Version { get; set; }
        public long PartitionId { get; set; }
        public string RefSys { get; set; }
        public string RefId { get; set; }
        public DateTime DtModified { get; set; }
        public string PaprApproxdatetext { get; set; }
        public short PaprIsapproxdate { get; set; }
        public string PaprApproxtodatetext { get; set; }
        public short PaprIsapproxtodate { get; set; }
        public long? PaprOnsetage { get; set; }
        public string PaprAlerts { get; set; }
        public long? PaprCasealerttype { get; set; }
        public long? PaprCasealertcolor { get; set; }
        public string PaprSourceref { get; set; }
        public DateTime? ClosedDatetime { get; set; }
        public long? Closedby { get; set; }
        public short PaprBlockcnotes { get; set; }
        public short PaprBlockpatacess { get; set; }
        public string ObjGuid { get; set; }
        public long? IndicationId { get; set; }
        public string IndicationDescr { get; set; }
        public DateTime? IndicationDate { get; set; }
        public string ApproxIndicationDate { get; set; }
        public short IsApproxIndicationDate { get; set; }
        public long? ReferralId { get; set; }
        public long? PaprProcedureType { get; set; }
        public long? PaprServiceId { get; set; }
        public long? PrivacyPppuId { get; set; }
        public long? PrivacyOrg { get; set; }
        public long? LifeStageFromId { get; set; }
        public long? LifeStageToId { get; set; }
        public long? LifeStageIndicationId { get; set; }
        public long? PaprOrderWeight { get; set; }
        public long? PaprCoMorbidTo { get; set; }
        public long FromMode { get; set; }
        public long ToMode { get; set; }
        public long IndicationMode { get; set; }
        public long? ExternalEntityId { get; set; }

        public Bcase Case { get; set; }
        public Pppu ClosedbyNavigation { get; set; }
        public CdoPerson CreatedbyNavigation { get; set; }
        public CdoPerson DeletedbyNavigation { get; set; }
        public Pppu Expr { get; set; }
        public Diseasecode Indication { get; set; }
        public Shortcode LifeStageFrom { get; set; }
        public Shortcode LifeStageIndication { get; set; }
        public Shortcode LifeStageTo { get; set; }
        public OrgStructure PaprAlertorganisationNavigation { get; set; }
        public CdoTermsetConcept PaprAnatomy { get; set; }
        public Shortcode PaprCasealerttypeNavigation { get; set; }
        public Patientproblem PaprCoMorbidToNavigation { get; set; }
        public Diseasecode PaprDx { get; set; }
        public Shortcode PaprDxnatureNavigation { get; set; }
        public CdoTermsetConcept PaprLocation { get; set; }
        public Shortcode PaprOutcome { get; set; }
        public Pppu PaprPppuidaddedNavigation { get; set; }
        public Pppu PaprPppuidalteredNavigation { get; set; }
        public Pppu PaprPrivateToPosNavigation { get; set; }
        public Pppu PaprProvider { get; set; }
        public Pppu PrivacyPppu { get; set; }
        public Patient Ptnt { get; set; }
        public AppRole RoleO { get; set; }
        public ICollection<Patientproblem> InversePaprCoMorbidToNavigation { get; set; }
    }
}
