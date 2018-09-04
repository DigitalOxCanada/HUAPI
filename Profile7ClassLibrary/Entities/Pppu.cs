using System;
using System.Collections.Generic;

namespace Profile7ClassLibrary.Entities
{
    public partial class Pppu
    {
        public Pppu()
        {
            Address = new HashSet<Address>();
            AppRole = new HashSet<AppRole>();
            AppointmentCreatedbyNavigation = new HashSet<Appointment>();
            AppointmentModifiedbyNavigation = new HashSet<Appointment>();
            AppointmentPppuIdPosNavigation = new HashSet<Appointment>();
            AppointmentPppuIdProviderNavigation = new HashSet<Appointment>();
            AppointmentPppuIdSeenbyNavigation = new HashSet<Appointment>();
            AppointmentPrivacyPppu = new HashSet<Appointment>();
            AppointmentRulesPosNavigation = new HashSet<AppointmentRules>();
            AppointmentRulesProviderNavigation = new HashSet<AppointmentRules>();
            Appointmentaudit = new HashSet<Appointmentaudit>();
            Audit = new HashSet<Audit>();
            BcaseAlteredBy = new HashSet<Bcase>();
            BcaseCaseMngr = new HashSet<Bcase>();
            BcaseCreator = new HashSet<Bcase>();
            BcaseLeadProv = new HashSet<Bcase>();
            BcasePrivacyPppu = new HashSet<Bcase>();
            BcaseServicePos = new HashSet<Bcase>();
            CareTeamCtPerson = new HashSet<CareTeam>();
            CareTeamPrivacyPppu = new HashSet<CareTeam>();
            CaseAudit = new HashSet<CaseAudit>();
            CaseMergeLog = new HashSet<CaseMergeLog>();
            CdoTransPos = new HashSet<CdoTrans>();
            CdoTransPrivacyPppu = new HashSet<CdoTrans>();
            CdoTransdata = new HashSet<CdoTransdata>();
            ContactActionLinkCoalPosNavigation = new HashSet<ContactActionLink>();
            ContactActionLinkCoalProviderNavigation = new HashSet<ContactActionLink>();
            DataOutputLog = new HashSet<DataOutputLog>();
            Diseasecode = new HashSet<Diseasecode>();
            InverseDefaultSupplierIdLaboratoryNavigation = new HashSet<Pppu>();
            InverseDefaultSupplierIdPharmacyNavigation = new HashSet<Pppu>();
            InverseDefaultSupplierIdRadiologyNavigation = new HashSet<Pppu>();
            InversePppuIdBasePosNavigation = new HashSet<Pppu>();
            InversePppuIdLocumNavigation = new HashSet<Pppu>();
            InversePppuSupervisorNavigation = new HashSet<Pppu>();
            OrgStructureOsAdminPosNavigation = new HashSet<OrgStructure>();
            OrgStructureOsClinicalPosNavigation = new HashSet<OrgStructure>();
            OrgStructureOsEquipLoanPosNavigation = new HashSet<OrgStructure>();
            OrgStructurePppu = new HashSet<OrgStructure>();
            PatientAudit = new HashSet<PatientAudit>();
            PatientGrp = new HashSet<PatientGrp>();
            PatientInfoAudit = new HashSet<PatientInfoAudit>();
            PatientMergeLog = new HashSet<PatientMergeLog>();
            PatientPppuIdAltdrNavigation = new HashSet<Patient>();
            PatientPppuIdUsualdrNavigation = new HashSet<Patient>();
            PatientPtntDeletedUser = new HashSet<Patient>();
            PatientPtntSocialhxSrcProvider = new HashSet<Patient>();
            PatientPtntSrcProvider = new HashSet<Patient>();
            PatientPtntTransferStatusChangedByNavigation = new HashSet<Patient>();
            PatientproblemClosedbyNavigation = new HashSet<Patientproblem>();
            PatientproblemExpr = new HashSet<Patientproblem>();
            PatientproblemPaprPppuidaddedNavigation = new HashSet<Patientproblem>();
            PatientproblemPaprPppuidalteredNavigation = new HashSet<Patientproblem>();
            PatientproblemPaprPrivateToPosNavigation = new HashSet<Patientproblem>();
            PatientproblemPaprProvider = new HashSet<Patientproblem>();
            PatientproblemPrivacyPppu = new HashSet<Patientproblem>();
            PatientrecallvisitPrivacyPppu = new HashSet<Patientrecallvisit>();
            PatientrecallvisitPrvsExtprovider = new HashSet<Patientrecallvisit>();
            PatientrecallvisitPrvsPerformedby = new HashSet<Patientrecallvisit>();
            PatientrecallvisitPrvsPerformedbyExtprov = new HashSet<Patientrecallvisit>();
            PatientrecallvisitPrvsPppu = new HashSet<Patientrecallvisit>();
            PatientrecallvisitPrvsPppuPos = new HashSet<Patientrecallvisit>();
            PppuposPppu = new HashSet<Pppupos>();
            PppuposPppuPos = new HashSet<Pppupos>();
            PppurolesCreatedbyNavigation = new HashSet<Pppuroles>();
            PppurolesPppu = new HashSet<Pppuroles>();
            ProfilePatientGroupPpgOwnerNavigation = new HashSet<ProfilePatientGroup>();
            ProfilePatientGroupPrivateToNavigation = new HashSet<ProfilePatientGroup>();
            UserSecurityLogUslChangedUserNavigation = new HashSet<UserSecurityLog>();
            UserSecurityLogUslUser = new HashSet<UserSecurityLog>();
            Workstation = new HashSet<Workstation>();
        }

        public long PppuId { get; set; }
        public string PppuCode { get; set; }
        public string PppuLastname { get; set; }
        public string PppuPrefname { get; set; }
        public string PppuTitle { get; set; }
        public string PppuStreet1 { get; set; }
        public string PppuStreet2 { get; set; }
        public string PppuStreet3 { get; set; }
        public string PppuStreetcode { get; set; }
        public string PppuPostal1 { get; set; }
        public string PppuPostal2 { get; set; }
        public string PppuPostal3 { get; set; }
        public string PppuPostalcode { get; set; }
        public string PppuPhone1 { get; set; }
        public string PppuPhone2 { get; set; }
        public string PppuFax { get; set; }
        public string PppuCellphone { get; set; }
        public string PppuPager { get; set; }
        public string PppuEmail { get; set; }
        public long? PppuReferenceid { get; set; }
        public string PppuReferencecode { get; set; }
        public long? PppuCategory { get; set; }
        public long? PppuType { get; set; }
        public long? PppuSpecialty { get; set; }
        public long? PppuStatus { get; set; }
        public long PppuDeletedid { get; set; }
        public short PppuAutocase { get; set; }
        public short PppuUsestreet { get; set; }
        public DateTime? PppuDateadded { get; set; }
        public DateTime? PppuDatechanged { get; set; }
        public long? PppuIdLocum { get; set; }
        public string PppuEdiaddress { get; set; }
        public string PppuEdikey { get; set; }
        public DateTime? PppuNextagedate { get; set; }
        public DateTime? PppuAppt1stmonday { get; set; }
        public long? PppuApptcycleweeks { get; set; }
        public string PppuFullname { get; set; }
        public long? PppuStreetstate { get; set; }
        public long? PppuPostalstate { get; set; }
        public short PppuLocumactive { get; set; }
        public DateTime? PppuLocumexpirydate { get; set; }
        public short PppuBkgndimageHide { get; set; }
        public long PppuBkgndimagestyle { get; set; }
        public short PppuBkgndimagetransp { get; set; }
        public short PppuSxcopayExtractOn { get; set; }
        public long? PppuSxcopayStartTrnsid { get; set; }
        public string PppuNpicode { get; set; }
        public long? PppuTypeconceptid { get; set; }
        public long? PppuSpecialtyconceptid { get; set; }
        public long? PppuReferencesystem { get; set; }
        public long? PppuPrincipalgroup { get; set; }
        public long? PppuApntSlipId { get; set; }
        public long? PppuRateShcdId { get; set; }
        public long? PppuStreetCountry { get; set; }
        public long? PppuPostCountry { get; set; }
        public short PppuIsDominant { get; set; }
        public string PayeeId { get; set; }
        public short PppuIsLmo { get; set; }
        public short PppuOtherInCefmenu { get; set; }
        public long? PppuSupervisor { get; set; }
        public long? PppuPaycode { get; set; }
        public string PppuLocationcertificate { get; set; }
        public long? PppuAssociatesDetailId { get; set; }
        public long? PppuFrontPageId { get; set; }
        public string PppuUsersid { get; set; }
        public string PppuJobtitle { get; set; }
        public string Code { get; set; }
        public DateTime Created { get; set; }
        public DateTime Deleted { get; set; }
        public long? Createdby { get; set; }
        public long? Deletedby { get; set; }
        public long Version { get; set; }
        public string PppuPlacename { get; set; }
        public string PppuEdipublickey { get; set; }
        public string PppuEdiprivatekey { get; set; }
        public string PppuQualifications { get; set; }
        public string PppuBuildingpostal { get; set; }
        public string PppuBuildingstreet { get; set; }
        public short PppuIsltrprint { get; set; }
        public short PppuIsltrfax { get; set; }
        public short PppuIsltremail { get; set; }
        public short PppuIsltrmessage { get; set; }
        public short PppuIsexternal { get; set; }
        public string PppuGeoX { get; set; }
        public string PppuGeoY { get; set; }
        public string PppuGeoMeshblock { get; set; }
        public string PppuGeoQuintile { get; set; }
        public string PppuGeoDhb { get; set; }
        public string PppuGeoUncertaintycode { get; set; }
        public double? PppuGeoLatitude { get; set; }
        public double? PppuGeoLongitude { get; set; }
        public long PppuGeoStatus { get; set; }
        public long PartitionId { get; set; }
        public string RefSys { get; set; }
        public string RefId { get; set; }
        public DateTime DtModified { get; set; }
        public long PppuIdBasePos { get; set; }
        public short PppuUseprovsrv { get; set; }
        public string PppuStreet4 { get; set; }
        public string PppuPostal4 { get; set; }
        public short PppuAutolocking { get; set; }
        public long? PppuAutolockMin { get; set; }
        public DateTime? DateLastPassChange { get; set; }
        public short ForcePassChange { get; set; }
        public DateTime? PppuLocumchanged { get; set; }
        public long? PppuTimezoneId { get; set; }
        public long? PppuPreferprecedence { get; set; }
        public long? PppuProvidergroup { get; set; }
        public short PppuGroupbasedpreference { get; set; }
        public DateTime? PppuWeblastvisit { get; set; }
        public short PppuTakingNewPatients { get; set; }
        public string PppuSex { get; set; }
        public DateTime? PppuDob { get; set; }
        public byte[] PppuGeneralComments { get; set; }
        public string PppuGeneralCommentsPlain { get; set; }
        public string PppuPersonalUrl { get; set; }
        public long? PppuPosSettingId { get; set; }
        public long? PppuOrgLevel { get; set; }
        public short PppuAccessionAccess { get; set; }
        public long? PppuCoverSplit { get; set; }
        public long? PppuCoverRule { get; set; }
        public long? PppuAccessProfileId { get; set; }
        public string PppuEdireferralsSubpath { get; set; }
        public string PppuAspDeliveryId { get; set; }
        public long? PppuReferralEserviceId { get; set; }
        public long? PppuEformatId { get; set; }
        public short PppuEformatAlsoPrint { get; set; }
        public long? PppuExtprovcustomrep { get; set; }
        public long? PppuExtprovcustomrepmacro { get; set; }
        public long? OrgPayerId { get; set; }
        public long PppuInvoiceMedicareType { get; set; }
        public DateTime? PasswordExpiryDate { get; set; }
        public long? PppuSignatureId { get; set; }
        public long PppuSignatureScale { get; set; }
        public string ObjGuid { get; set; }
        public DateTime? DateLastResult { get; set; }
        public DateTime? DateLastQuery { get; set; }
        public long? PppuAppLocationId { get; set; }
        public short PppuIsRo { get; set; }
        public short PppuIsOmo { get; set; }
        public string PppuHpiO { get; set; }
        public string PppuHpiI { get; set; }
        public string PppuUsersidDescription { get; set; }
        public long? DefaultSupplierIdLaboratory { get; set; }
        public long? DefaultSupplierIdRadiology { get; set; }
        public long? DefaultSupplierIdPharmacy { get; set; }
        public long? PppuAltEserviceId { get; set; }
        public short PppuUsesmddelivery { get; set; }
        public short PppuMobileDeviceAccess { get; set; }
        public long? PppuOnthegoId { get; set; }
        public string PppuGeoDecile { get; set; }
        public string PppuGeoDomicileCode { get; set; }
        public string PppuGeoTlaName { get; set; }
        public long PppuPreferredCommMethod { get; set; }
        public string PppuGeoDomicileDescription { get; set; }
        public short PppuIsimported { get; set; }
        public string PppuExternalorgcodeset { get; set; }
        public string PppuExternalorgcode { get; set; }
        public string PppuExternalorgname { get; set; }
        public short PppuOhipProvider { get; set; }
        public string PppuOhipUserid { get; set; }
        public string PppuOhipPassword { get; set; }

        public CdoPerson CreatedbyNavigation { get; set; }
        public Pppu DefaultSupplierIdLaboratoryNavigation { get; set; }
        public Pppu DefaultSupplierIdPharmacyNavigation { get; set; }
        public Pppu DefaultSupplierIdRadiologyNavigation { get; set; }
        public CdoPerson DeletedbyNavigation { get; set; }
        public Patient OrgPayer { get; set; }
        public Shortcode PppuAppLocation { get; set; }
        public Shortcode PppuCoverRuleNavigation { get; set; }
        public Blobs PppuExtprovcustomrepNavigation { get; set; }
        public Shortcode PppuExtprovcustomrepmacroNavigation { get; set; }
        public Pppu PppuIdBasePosNavigation { get; set; }
        public Pppu PppuIdLocumNavigation { get; set; }
        public OrgStructure PppuOrgLevelNavigation { get; set; }
        public Shortcode PppuPaycodeNavigation { get; set; }
        public Shortcode PppuPosSetting { get; set; }
        public Lookuplist PppuPostalstateNavigation { get; set; }
        public Shortcode PppuRateShcd { get; set; }
        public Shortcode PppuReferencesystemNavigation { get; set; }
        public Blobs PppuSignature { get; set; }
        public CdoTermsetConcept PppuSpecialtyconcept { get; set; }
        public Lookuplist PppuStreetstateNavigation { get; set; }
        public Pppu PppuSupervisorNavigation { get; set; }
        public CdoTermsetConcept PppuTypeconcept { get; set; }
        public Pppuimage Pppuimage { get; set; }
        public Pppusecurity Pppusecurity { get; set; }
        public ICollection<Address> Address { get; set; }
        public ICollection<AppRole> AppRole { get; set; }
        public ICollection<Appointment> AppointmentCreatedbyNavigation { get; set; }
        public ICollection<Appointment> AppointmentModifiedbyNavigation { get; set; }
        public ICollection<Appointment> AppointmentPppuIdPosNavigation { get; set; }
        public ICollection<Appointment> AppointmentPppuIdProviderNavigation { get; set; }
        public ICollection<Appointment> AppointmentPppuIdSeenbyNavigation { get; set; }
        public ICollection<Appointment> AppointmentPrivacyPppu { get; set; }
        public ICollection<AppointmentRules> AppointmentRulesPosNavigation { get; set; }
        public ICollection<AppointmentRules> AppointmentRulesProviderNavigation { get; set; }
        public ICollection<Appointmentaudit> Appointmentaudit { get; set; }
        public ICollection<Audit> Audit { get; set; }
        public ICollection<Bcase> BcaseAlteredBy { get; set; }
        public ICollection<Bcase> BcaseCaseMngr { get; set; }
        public ICollection<Bcase> BcaseCreator { get; set; }
        public ICollection<Bcase> BcaseLeadProv { get; set; }
        public ICollection<Bcase> BcasePrivacyPppu { get; set; }
        public ICollection<Bcase> BcaseServicePos { get; set; }
        public ICollection<CareTeam> CareTeamCtPerson { get; set; }
        public ICollection<CareTeam> CareTeamPrivacyPppu { get; set; }
        public ICollection<CaseAudit> CaseAudit { get; set; }
        public ICollection<CaseMergeLog> CaseMergeLog { get; set; }
        public ICollection<CdoTrans> CdoTransPos { get; set; }
        public ICollection<CdoTrans> CdoTransPrivacyPppu { get; set; }
        public ICollection<CdoTransdata> CdoTransdata { get; set; }
        public ICollection<ContactActionLink> ContactActionLinkCoalPosNavigation { get; set; }
        public ICollection<ContactActionLink> ContactActionLinkCoalProviderNavigation { get; set; }
        public ICollection<DataOutputLog> DataOutputLog { get; set; }
        public ICollection<Diseasecode> Diseasecode { get; set; }
        public ICollection<Pppu> InverseDefaultSupplierIdLaboratoryNavigation { get; set; }
        public ICollection<Pppu> InverseDefaultSupplierIdPharmacyNavigation { get; set; }
        public ICollection<Pppu> InverseDefaultSupplierIdRadiologyNavigation { get; set; }
        public ICollection<Pppu> InversePppuIdBasePosNavigation { get; set; }
        public ICollection<Pppu> InversePppuIdLocumNavigation { get; set; }
        public ICollection<Pppu> InversePppuSupervisorNavigation { get; set; }
        public ICollection<OrgStructure> OrgStructureOsAdminPosNavigation { get; set; }
        public ICollection<OrgStructure> OrgStructureOsClinicalPosNavigation { get; set; }
        public ICollection<OrgStructure> OrgStructureOsEquipLoanPosNavigation { get; set; }
        public ICollection<OrgStructure> OrgStructurePppu { get; set; }
        public ICollection<PatientAudit> PatientAudit { get; set; }
        public ICollection<PatientGrp> PatientGrp { get; set; }
        public ICollection<PatientInfoAudit> PatientInfoAudit { get; set; }
        public ICollection<PatientMergeLog> PatientMergeLog { get; set; }
        public ICollection<Patient> PatientPppuIdAltdrNavigation { get; set; }
        public ICollection<Patient> PatientPppuIdUsualdrNavigation { get; set; }
        public ICollection<Patient> PatientPtntDeletedUser { get; set; }
        public ICollection<Patient> PatientPtntSocialhxSrcProvider { get; set; }
        public ICollection<Patient> PatientPtntSrcProvider { get; set; }
        public ICollection<Patient> PatientPtntTransferStatusChangedByNavigation { get; set; }
        public ICollection<Patientproblem> PatientproblemClosedbyNavigation { get; set; }
        public ICollection<Patientproblem> PatientproblemExpr { get; set; }
        public ICollection<Patientproblem> PatientproblemPaprPppuidaddedNavigation { get; set; }
        public ICollection<Patientproblem> PatientproblemPaprPppuidalteredNavigation { get; set; }
        public ICollection<Patientproblem> PatientproblemPaprPrivateToPosNavigation { get; set; }
        public ICollection<Patientproblem> PatientproblemPaprProvider { get; set; }
        public ICollection<Patientproblem> PatientproblemPrivacyPppu { get; set; }
        public ICollection<Patientrecallvisit> PatientrecallvisitPrivacyPppu { get; set; }
        public ICollection<Patientrecallvisit> PatientrecallvisitPrvsExtprovider { get; set; }
        public ICollection<Patientrecallvisit> PatientrecallvisitPrvsPerformedby { get; set; }
        public ICollection<Patientrecallvisit> PatientrecallvisitPrvsPerformedbyExtprov { get; set; }
        public ICollection<Patientrecallvisit> PatientrecallvisitPrvsPppu { get; set; }
        public ICollection<Patientrecallvisit> PatientrecallvisitPrvsPppuPos { get; set; }
        public ICollection<Pppupos> PppuposPppu { get; set; }
        public ICollection<Pppupos> PppuposPppuPos { get; set; }
        public ICollection<Pppuroles> PppurolesCreatedbyNavigation { get; set; }
        public ICollection<Pppuroles> PppurolesPppu { get; set; }
        public ICollection<ProfilePatientGroup> ProfilePatientGroupPpgOwnerNavigation { get; set; }
        public ICollection<ProfilePatientGroup> ProfilePatientGroupPrivateToNavigation { get; set; }
        public ICollection<UserSecurityLog> UserSecurityLogUslChangedUserNavigation { get; set; }
        public ICollection<UserSecurityLog> UserSecurityLogUslUser { get; set; }
        public ICollection<Workstation> Workstation { get; set; }
    }
}
