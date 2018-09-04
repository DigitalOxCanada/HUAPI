using System;
using System.Collections.Generic;

namespace Profile7ClassLibrary.Entities
{
    public partial class AppRole
    {
        public AppRole()
        {
            Appointment = new HashSet<Appointment>();
            BcaseCaseRole = new HashSet<Bcase>();
            BcaseRoleO = new HashSet<Bcase>();
            BcaseRoleOidAdminNavigation = new HashSet<Bcase>();
            CareTeamCtPppuRoleNavigation = new HashSet<CareTeam>();
            CareTeamCtPrivacy = new HashSet<CareTeam>();
            CaseTemplatesAdminPrivacyNavigation = new HashSet<CaseTemplates>();
            CaseTemplatesCasePrivacyNavigation = new HashSet<CaseTemplates>();
            CaseTemplatesClinicalPrivacyNavigation = new HashSet<CaseTemplates>();
            CdoTrans = new HashSet<CdoTrans>();
            InverseParentRoleNavigation = new HashSet<AppRole>();
            OrgStructureOsAdmRole = new HashSet<OrgStructure>();
            OrgStructureOsCaseRole = new HashSet<OrgStructure>();
            OrgStructureOsClnRole = new HashSet<OrgStructure>();
            OrgStructureOsGuessedRole = new HashSet<OrgStructure>();
            Patientproblem = new HashSet<Patientproblem>();
            Patientrecallvisit = new HashSet<Patientrecallvisit>();
            Pppupos = new HashSet<Pppupos>();
            ProfilePatientGroup = new HashSet<ProfilePatientGroup>();
            Shortcode = new HashSet<Shortcode>();
        }

        public long Cid { get; set; }
        public long Oid { get; set; }
        public long? ParentRole { get; set; }
        public string RoleName { get; set; }
        public long? Createdby { get; set; }
        public DateTime? Createdon { get; set; }
        public byte[] EnabledOps { get; set; }
        public byte[] DisabledOps { get; set; }
        public long Roletype { get; set; }
        public long? UseForPrivacy { get; set; }
        public long? EncountersStyle { get; set; }
        public byte[] ObjectRights { get; set; }
        public long? MaxNewenc { get; set; }
        public long? DefCefformId { get; set; }
        public byte[] Conditions { get; set; }
        public long PartitionId { get; set; }
        public string RefSys { get; set; }
        public string RefId { get; set; }
        public DateTime DtModified { get; set; }
        public long Deletedid { get; set; }
        public long? MaxEmrs { get; set; }
        public long? MaxCases { get; set; }
        public long? MaxEmrsAndCases { get; set; }
        public short EmrIsReadonly { get; set; }
        public short LimitEmrsAndCases { get; set; }
        public string RemotePrivacy { get; set; }
        public long? PrivacyEntryId { get; set; }
        public string ObjGuid { get; set; }
        public long EncountersWindowStyle { get; set; }
        public short UpdateCaseDependencies { get; set; }

        public Pppu CreatedbyNavigation { get; set; }
        public CdoTransdata DefCefform { get; set; }
        public AppRole ParentRoleNavigation { get; set; }
        public ICollection<Appointment> Appointment { get; set; }
        public ICollection<Bcase> BcaseCaseRole { get; set; }
        public ICollection<Bcase> BcaseRoleO { get; set; }
        public ICollection<Bcase> BcaseRoleOidAdminNavigation { get; set; }
        public ICollection<CareTeam> CareTeamCtPppuRoleNavigation { get; set; }
        public ICollection<CareTeam> CareTeamCtPrivacy { get; set; }
        public ICollection<CaseTemplates> CaseTemplatesAdminPrivacyNavigation { get; set; }
        public ICollection<CaseTemplates> CaseTemplatesCasePrivacyNavigation { get; set; }
        public ICollection<CaseTemplates> CaseTemplatesClinicalPrivacyNavigation { get; set; }
        public ICollection<CdoTrans> CdoTrans { get; set; }
        public ICollection<AppRole> InverseParentRoleNavigation { get; set; }
        public ICollection<OrgStructure> OrgStructureOsAdmRole { get; set; }
        public ICollection<OrgStructure> OrgStructureOsCaseRole { get; set; }
        public ICollection<OrgStructure> OrgStructureOsClnRole { get; set; }
        public ICollection<OrgStructure> OrgStructureOsGuessedRole { get; set; }
        public ICollection<Patientproblem> Patientproblem { get; set; }
        public ICollection<Patientrecallvisit> Patientrecallvisit { get; set; }
        public ICollection<Pppupos> Pppupos { get; set; }
        public ICollection<ProfilePatientGroup> ProfilePatientGroup { get; set; }
        public ICollection<Shortcode> Shortcode { get; set; }
    }
}
