using System;
using System.Collections.Generic;

namespace Profile7ClassLibrary.Entities
{
    public partial class Shortcode
    {
        public Shortcode()
        {
            Address = new HashSet<Address>();
            AppointmentApntCancellationReasonNavigation = new HashSet<Appointment>();
            AppointmentRulesDefTypeNavigation = new HashSet<AppointmentRules>();
            AppointmentRulesTempCommonTypeNavigation = new HashSet<AppointmentRules>();
            AppointmentShcdIdLocationNavigation = new HashSet<Appointment>();
            AppointmentShcdIdPaycodeNavigation = new HashSet<Appointment>();
            AppointmentShcdIdPriorityNavigation = new HashSet<Appointment>();
            AppointmentShcdIdTypeNavigation = new HashSet<Appointment>();
            BcaseCaseSettingsNavigation = new HashSet<Bcase>();
            BcaseConditionNavigation = new HashSet<Bcase>();
            BcaseSepOutcome = new HashSet<Bcase>();
            BcaseShcdCaseriskNavigation = new HashSet<Bcase>();
            BcaseShcdDischargedto = new HashSet<Bcase>();
            BcaseShcdPriority = new HashSet<Bcase>();
            BcaseShcdSource1Navigation = new HashSet<Bcase>();
            BcaseShcdSource2Navigation = new HashSet<Bcase>();
            CareTeam = new HashSet<CareTeam>();
            CaseTemplates = new HashSet<CaseTemplates>();
            CdoTransContactType = new HashSet<CdoTrans>();
            CdoTransDocCategory = new HashSet<CdoTrans>();
            CdoTransEncounterTypeNavigation = new HashSet<CdoTrans>();
            CdoTransLocation = new HashSet<CdoTrans>();
            ContactActionLink = new HashSet<ContactActionLink>();
            Diseasecode = new HashSet<Diseasecode>();
            Headline = new HashSet<Headline>();
            InverseShcdParent = new HashSet<Shortcode>();
            OrgStructureDefaultAlerttypeNavigation = new HashSet<OrgStructure>();
            OrgStructureOsContactTypeNavigation = new HashSet<OrgStructure>();
            OrgStructureSchdAdminEncMacroNavigation = new HashSet<OrgStructure>();
            OrgStructureSchdClinicalEncMacroNavigation = new HashSet<OrgStructure>();
            OrgStructureShcdCareTypeNavigation = new HashSet<OrgStructure>();
            OrgStructureShcdSubtype = new HashSet<OrgStructure>();
            OrgStructureWtbdFromgroupNavigation = new HashSet<OrgStructure>();
            OrgStructureWtbdTogroupNavigation = new HashSet<OrgStructure>();
            PatientPtntNamesuffixNavigation = new HashSet<Patient>();
            PatientShcdIdBenefittypeNavigation = new HashSet<Patient>();
            PatientShcdIdHealthstatusNavigation = new HashSet<Patient>();
            PatientShcdIdHomelanguageNavigation = new HashSet<Patient>();
            PatientShcdIdJournalsNavigation = new HashSet<Patient>();
            PatientShcdIdLivingsituationNavigation = new HashSet<Patient>();
            PatientShcdIdPlanNavigation = new HashSet<Patient>();
            PatientShcdIdPreflanguageNavigation = new HashSet<Patient>();
            PatientShcdIdServicecategoryNavigation = new HashSet<Patient>();
            PatientShcdIdServicediscountNavigation = new HashSet<Patient>();
            PatientShcdIdServicerateNavigation = new HashSet<Patient>();
            PatientShcdIdTargettypeNavigation = new HashSet<Patient>();
            PatientproblemLifeStageFrom = new HashSet<Patientproblem>();
            PatientproblemLifeStageIndication = new HashSet<Patientproblem>();
            PatientproblemLifeStageTo = new HashSet<Patientproblem>();
            PatientproblemPaprCasealerttypeNavigation = new HashSet<Patientproblem>();
            PatientproblemPaprDxnatureNavigation = new HashSet<Patientproblem>();
            PatientproblemPaprOutcome = new HashSet<Patientproblem>();
            PatientrecallvisitPrvsExplanation = new HashSet<Patientrecallvisit>();
            PatientrecallvisitPrvsPriority = new HashSet<Patientrecallvisit>();
            PatientrecallvisitPrvsShcdVisittype = new HashSet<Patientrecallvisit>();
            PatientrecallvisitShcdCompleteform = new HashSet<Patientrecallvisit>();
            PppuPppuAppLocation = new HashSet<Pppu>();
            PppuPppuCoverRuleNavigation = new HashSet<Pppu>();
            PppuPppuExtprovcustomrepmacroNavigation = new HashSet<Pppu>();
            PppuPppuPaycodeNavigation = new HashSet<Pppu>();
            PppuPppuPosSetting = new HashSet<Pppu>();
            PppuPppuRateShcd = new HashSet<Pppu>();
            PppuPppuReferencesystemNavigation = new HashSet<Pppu>();
            PppuposPppuPosReferencesystemNavigation = new HashSet<Pppupos>();
            PppuposPppuPosRrpSccNavigation = new HashSet<Pppupos>();
            UserSecurityLogUslCategory = new HashSet<UserSecurityLog>();
            UserSecurityLogUslEntry = new HashSet<UserSecurityLog>();
        }

        public long ShcdId { get; set; }
        public string ShcdCode { get; set; }
        public string ShcdDescription { get; set; }
        public long ShcdType { get; set; }
        public long ShcdDeletedid { get; set; }
        public byte[] ShcdRtftext { get; set; }
        public short ShcdOverrun { get; set; }
        public string ShcdBeginnum { get; set; }
        public string ShcdEndnum { get; set; }
        public string ShcdCurnum { get; set; }
        public byte[] ShcdMacro { get; set; }
        public DateTime? ShcdAdded { get; set; }
        public DateTime? ShcdChanged { get; set; }
        public short ShcdIncludefont { get; set; }
        public decimal ShcdRate { get; set; }
        public long? ShcdColor { get; set; }
        public short ShcdReadonly { get; set; }
        public long? ShcdRoleid { get; set; }
        public long? ShcdParentid { get; set; }
        public string ShcdOutput { get; set; }
        public short ShcdPatientcontact { get; set; }
        public long? ShcdTag { get; set; }
        public long PartitionId { get; set; }
        public string RefSys { get; set; }
        public string RefId { get; set; }
        public DateTime DtModified { get; set; }
        public long ShcdOwnerpppuid { get; set; }
        public long? ShcdCaselevel { get; set; }
        public long? ShcdEmphasis { get; set; }
        public long MasterId { get; set; }
        public long Version { get; set; }
        public DateTime Created { get; set; }
        public DateTime Deleted { get; set; }
        public long? Createdby { get; set; }
        public long? Deletedby { get; set; }
        public string ShcdComment { get; set; }
        public string ObjGuid { get; set; }
        public short ShcdExtactivity { get; set; }
        public short ShcdAllowadminenc { get; set; }
        public decimal ShcdRate2 { get; set; }
        public long ShcdSysid { get; set; }

        public Shortcode ShcdParent { get; set; }
        public AppRole ShcdRole { get; set; }
        public ShortcodeType ShcdTypeNavigation { get; set; }
        public ICollection<Address> Address { get; set; }
        public ICollection<Appointment> AppointmentApntCancellationReasonNavigation { get; set; }
        public ICollection<AppointmentRules> AppointmentRulesDefTypeNavigation { get; set; }
        public ICollection<AppointmentRules> AppointmentRulesTempCommonTypeNavigation { get; set; }
        public ICollection<Appointment> AppointmentShcdIdLocationNavigation { get; set; }
        public ICollection<Appointment> AppointmentShcdIdPaycodeNavigation { get; set; }
        public ICollection<Appointment> AppointmentShcdIdPriorityNavigation { get; set; }
        public ICollection<Appointment> AppointmentShcdIdTypeNavigation { get; set; }
        public ICollection<Bcase> BcaseCaseSettingsNavigation { get; set; }
        public ICollection<Bcase> BcaseConditionNavigation { get; set; }
        public ICollection<Bcase> BcaseSepOutcome { get; set; }
        public ICollection<Bcase> BcaseShcdCaseriskNavigation { get; set; }
        public ICollection<Bcase> BcaseShcdDischargedto { get; set; }
        public ICollection<Bcase> BcaseShcdPriority { get; set; }
        public ICollection<Bcase> BcaseShcdSource1Navigation { get; set; }
        public ICollection<Bcase> BcaseShcdSource2Navigation { get; set; }
        public ICollection<CareTeam> CareTeam { get; set; }
        public ICollection<CaseTemplates> CaseTemplates { get; set; }
        public ICollection<CdoTrans> CdoTransContactType { get; set; }
        public ICollection<CdoTrans> CdoTransDocCategory { get; set; }
        public ICollection<CdoTrans> CdoTransEncounterTypeNavigation { get; set; }
        public ICollection<CdoTrans> CdoTransLocation { get; set; }
        public ICollection<ContactActionLink> ContactActionLink { get; set; }
        public ICollection<Diseasecode> Diseasecode { get; set; }
        public ICollection<Headline> Headline { get; set; }
        public ICollection<Shortcode> InverseShcdParent { get; set; }
        public ICollection<OrgStructure> OrgStructureDefaultAlerttypeNavigation { get; set; }
        public ICollection<OrgStructure> OrgStructureOsContactTypeNavigation { get; set; }
        public ICollection<OrgStructure> OrgStructureSchdAdminEncMacroNavigation { get; set; }
        public ICollection<OrgStructure> OrgStructureSchdClinicalEncMacroNavigation { get; set; }
        public ICollection<OrgStructure> OrgStructureShcdCareTypeNavigation { get; set; }
        public ICollection<OrgStructure> OrgStructureShcdSubtype { get; set; }
        public ICollection<OrgStructure> OrgStructureWtbdFromgroupNavigation { get; set; }
        public ICollection<OrgStructure> OrgStructureWtbdTogroupNavigation { get; set; }
        public ICollection<Patient> PatientPtntNamesuffixNavigation { get; set; }
        public ICollection<Patient> PatientShcdIdBenefittypeNavigation { get; set; }
        public ICollection<Patient> PatientShcdIdHealthstatusNavigation { get; set; }
        public ICollection<Patient> PatientShcdIdHomelanguageNavigation { get; set; }
        public ICollection<Patient> PatientShcdIdJournalsNavigation { get; set; }
        public ICollection<Patient> PatientShcdIdLivingsituationNavigation { get; set; }
        public ICollection<Patient> PatientShcdIdPlanNavigation { get; set; }
        public ICollection<Patient> PatientShcdIdPreflanguageNavigation { get; set; }
        public ICollection<Patient> PatientShcdIdServicecategoryNavigation { get; set; }
        public ICollection<Patient> PatientShcdIdServicediscountNavigation { get; set; }
        public ICollection<Patient> PatientShcdIdServicerateNavigation { get; set; }
        public ICollection<Patient> PatientShcdIdTargettypeNavigation { get; set; }
        public ICollection<Patientproblem> PatientproblemLifeStageFrom { get; set; }
        public ICollection<Patientproblem> PatientproblemLifeStageIndication { get; set; }
        public ICollection<Patientproblem> PatientproblemLifeStageTo { get; set; }
        public ICollection<Patientproblem> PatientproblemPaprCasealerttypeNavigation { get; set; }
        public ICollection<Patientproblem> PatientproblemPaprDxnatureNavigation { get; set; }
        public ICollection<Patientproblem> PatientproblemPaprOutcome { get; set; }
        public ICollection<Patientrecallvisit> PatientrecallvisitPrvsExplanation { get; set; }
        public ICollection<Patientrecallvisit> PatientrecallvisitPrvsPriority { get; set; }
        public ICollection<Patientrecallvisit> PatientrecallvisitPrvsShcdVisittype { get; set; }
        public ICollection<Patientrecallvisit> PatientrecallvisitShcdCompleteform { get; set; }
        public ICollection<Pppu> PppuPppuAppLocation { get; set; }
        public ICollection<Pppu> PppuPppuCoverRuleNavigation { get; set; }
        public ICollection<Pppu> PppuPppuExtprovcustomrepmacroNavigation { get; set; }
        public ICollection<Pppu> PppuPppuPaycodeNavigation { get; set; }
        public ICollection<Pppu> PppuPppuPosSetting { get; set; }
        public ICollection<Pppu> PppuPppuRateShcd { get; set; }
        public ICollection<Pppu> PppuPppuReferencesystemNavigation { get; set; }
        public ICollection<Pppupos> PppuposPppuPosReferencesystemNavigation { get; set; }
        public ICollection<Pppupos> PppuposPppuPosRrpSccNavigation { get; set; }
        public ICollection<UserSecurityLog> UserSecurityLogUslCategory { get; set; }
        public ICollection<UserSecurityLog> UserSecurityLogUslEntry { get; set; }
    }
}
