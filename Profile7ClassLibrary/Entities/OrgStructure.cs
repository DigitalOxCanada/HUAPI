using System;
using System.Collections.Generic;

namespace Profile7ClassLibrary.Entities
{
    public partial class OrgStructure
    {
        public OrgStructure()
        {
            BcaseForceCaseNavigation = new HashSet<Bcase>();
            BcaseOrgStructure = new HashSet<Bcase>();
            Headline = new HashSet<Headline>();
            InverseAlertOrganisationNavigation = new HashSet<OrgStructure>();
            InverseParent = new HashSet<OrgStructure>();
            Patient = new HashSet<Patient>();
            Patientproblem = new HashSet<Patientproblem>();
            PppuNavigation = new HashSet<Pppu>();
        }

        public long Oid { get; set; }
        public long? PppuId { get; set; }
        public long? ParentId { get; set; }
        public long? ShcdSubtypeId { get; set; }
        public string Name { get; set; }
        public long? Deletedid { get; set; }
        public long? TemplateId { get; set; }
        public long? ShcdCareType { get; set; }
        public long? OsAdmRoleId { get; set; }
        public long? OsClnRoleId { get; set; }
        public short SelectPatientCase { get; set; }
        public short AllowPatientContext { get; set; }
        public short ForceAutocase { get; set; }
        public string ForceCaseTitle { get; set; }
        public short RequireCaseForBe { get; set; }
        public short RequireCaseForGs { get; set; }
        public short CsPromptForNewService { get; set; }
        public short CsAutoCloseServices { get; set; }
        public short OsIsEquipLoan { get; set; }
        public long OsEncounterDescType { get; set; }
        public short AllowSectionType { get; set; }
        public short IncludeOtherPatients { get; set; }
        public short LockClosedCase { get; set; }
        public long DefObjectRightsType { get; set; }
        public string RefCode { get; set; }
        public long? OsContactType { get; set; }
        public string OsCauseGroup { get; set; }
        public long? AlertScope { get; set; }
        public long? AlertOrganisation { get; set; }
        public short AlertOpenonly { get; set; }
        public short PrnFormHeaderFooter { get; set; }
        public short AddJobTitle { get; set; }
        public long? OsAdminPos { get; set; }
        public long PartitionId { get; set; }
        public string RefSys { get; set; }
        public string RefId { get; set; }
        public DateTime DtModified { get; set; }
        public short OsUseGuessedRole { get; set; }
        public long? OsGuessedRoleId { get; set; }
        public long? OsAppSystemId { get; set; }
        public long? OsEquipLoanPos { get; set; }
        public short AutoUpdateFirstVisit { get; set; }
        public long? DefaultAlerttype { get; set; }
        public long? OsCaseRoleId { get; set; }
        public short EncryptDataOnexport { get; set; }
        public short WtbdAutoEncounter { get; set; }
        public short WtbdFromgroupEnabled { get; set; }
        public short WtbdTogroupEnabled { get; set; }
        public long? WtbdFromgroup { get; set; }
        public long? WtbdTogroup { get; set; }
        public string Defaultcasetype { get; set; }
        public short Promtcasetype { get; set; }
        public short Allowsingleopencase { get; set; }
        public short Allowcasetypenull { get; set; }
        public short RelaxRulesOnObjectives { get; set; }
        public short AllowAssignProvsOutOrg { get; set; }
        public short InsertComplCmntsInCnotes { get; set; }
        public long ComplCommentsType { get; set; }
        public byte[] OmitFromCloseAll { get; set; }
        public byte[] ComplCommentsMacro { get; set; }
        public short AllowPlanInEmr { get; set; }
        public long PlanPromtType { get; set; }
        public short UseUnifiedCarePlan { get; set; }
        public string UnifiedStandardTmpltCode { get; set; }
        public byte[] UnifiedExcludedPlans { get; set; }
        public byte[] ValidateCarePlanMacro { get; set; }
        public long ObjectivesMergeRule { get; set; }
        public long ObjectivesMatchRule { get; set; }
        public long InterventionsMergeRule { get; set; }
        public long InterventionsMatchRule { get; set; }
        public long? RxSystemId { get; set; }
        public short UseAlternatePatientViews { get; set; }
        public long? SchdClinicalEncMacro { get; set; }
        public long? SchdAdminEncMacro { get; set; }
        public long? UnifiedProviders { get; set; }
        public long? UnifiedInternalRule { get; set; }
        public byte[] UnifiedInternalRuleMacro { get; set; }
        public long? WtbdDelay { get; set; }
        public long OverviewHyperlinks { get; set; }
        public short SyncReferralAndEmbdLetter { get; set; }
        public short AddEncounterCreatedDate { get; set; }
        public short ShowUnsigned { get; set; }
        public short AllowMultipleAdmissions { get; set; }
        public short AllowPrivacyMe { get; set; }
        public long? NewpatientFormid { get; set; }
        public long? AlterpatientFormid { get; set; }
        public long? DisplaypatientFormid { get; set; }
        public short AlterpatientSuppresslookup { get; set; }
        public short DisplaypatientSuppresslookup { get; set; }
        public string ObjGuid { get; set; }
        public short UcpShowLuckyButton { get; set; }
        public short HideCaseList { get; set; }
        public short ShowPos { get; set; }
        public short IsFinancialGroup { get; set; }
        public string CaseForImportedImm { get; set; }
        public long? OsClinicalPos { get; set; }

        public OrgStructure AlertOrganisationNavigation { get; set; }
        public CdoTransdata AlterpatientForm { get; set; }
        public Shortcode DefaultAlerttypeNavigation { get; set; }
        public CdoTransdata DisplaypatientForm { get; set; }
        public CdoTransdata NewpatientForm { get; set; }
        public AppRole OsAdmRole { get; set; }
        public Pppu OsAdminPosNavigation { get; set; }
        public AppRole OsCaseRole { get; set; }
        public Pppu OsClinicalPosNavigation { get; set; }
        public AppRole OsClnRole { get; set; }
        public Shortcode OsContactTypeNavigation { get; set; }
        public Pppu OsEquipLoanPosNavigation { get; set; }
        public AppRole OsGuessedRole { get; set; }
        public OrgStructure Parent { get; set; }
        public Pppu Pppu { get; set; }
        public Shortcode SchdAdminEncMacroNavigation { get; set; }
        public Shortcode SchdClinicalEncMacroNavigation { get; set; }
        public Shortcode ShcdCareTypeNavigation { get; set; }
        public Shortcode ShcdSubtype { get; set; }
        public CdoTransdata Template { get; set; }
        public Shortcode WtbdFromgroupNavigation { get; set; }
        public Shortcode WtbdTogroupNavigation { get; set; }
        public ICollection<Bcase> BcaseForceCaseNavigation { get; set; }
        public ICollection<Bcase> BcaseOrgStructure { get; set; }
        public ICollection<Headline> Headline { get; set; }
        public ICollection<OrgStructure> InverseAlertOrganisationNavigation { get; set; }
        public ICollection<OrgStructure> InverseParent { get; set; }
        public ICollection<Patient> Patient { get; set; }
        public ICollection<Patientproblem> Patientproblem { get; set; }
        public ICollection<Pppu> PppuNavigation { get; set; }
    }
}
