using System;
using System.Collections.Generic;

namespace Profile7ClassLibrary.Entities
{
    public partial class Patient
    {
        public Patient()
        {
            Address = new HashSet<Address>();
            Appointment = new HashSet<Appointment>();
            Appointmentaudit = new HashSet<Appointmentaudit>();
            Bcase = new HashSet<Bcase>();
            CareTeamCtPatientNavigation = new HashSet<CareTeam>();
            CareTeamCtPayer = new HashSet<CareTeam>();
            CaseAudit = new HashSet<CaseAudit>();
            ContactActionLink = new HashSet<ContactActionLink>();
            InversePtntEmployer = new HashSet<Patient>();
            InversePtntIdGuarantorNavigation = new HashSet<Patient>();
            InversePtntIdInsurerNavigation = new HashSet<Patient>();
            InversePtntIdPartnerNavigation = new HashSet<Patient>();
            InversePtntLeadcaregiverNavigation = new HashSet<Patient>();
            InversePtntMasterPtnt = new HashSet<Patient>();
            InversePtntParent1Navigation = new HashSet<Patient>();
            InversePtntParent2Navigation = new HashSet<Patient>();
            InversePtntPayer = new HashSet<Patient>();
            PatientAlternatName = new HashSet<PatientAlternatName>();
            PatientAuditObserverPtnt = new HashSet<PatientAudit>();
            PatientAuditPaudtPtnt = new HashSet<PatientAudit>();
            PatientInfoAuditObserverPtnt = new HashSet<PatientInfoAudit>();
            PatientInfoAuditPiaudPtnt = new HashSet<PatientInfoAudit>();
            PatientMergeLogMaster = new HashSet<PatientMergeLog>();
            PatientMergeLogSub = new HashSet<PatientMergeLog>();
            Patientproblem = new HashSet<Patientproblem>();
            PatientrecallvisitPrvsOtherPatient = new HashSet<Patientrecallvisit>();
            PatientrecallvisitPrvsPerformedbyPatient = new HashSet<Patientrecallvisit>();
            Pppu = new HashSet<Pppu>();
            UserSecurityLog = new HashSet<UserSecurityLog>();
        }

        public long PtntId { get; set; }
        public long? LklsIdEthnicity { get; set; }
        public long? LklsIdReligion { get; set; }
        public long? LklsIdOccupation { get; set; }
        public long? PppuIdUsualdr { get; set; }
        public long? PppuIdAltdr { get; set; }
        public long? PtntStatus { get; set; }
        public long? PtntIdPartner { get; set; }
        public long? PtntIdGuarantor { get; set; }
        public string PtntTitle { get; set; }
        public string PtntSurname { get; set; }
        public string PtntFirstname { get; set; }
        public string PtntPrefname { get; set; }
        public string PtntSex { get; set; }
        public DateTime? PtntDob { get; set; }
        public DateTime? PtntDod { get; set; }
        public string PtntStreet1 { get; set; }
        public string PtntStreet2 { get; set; }
        public string PtntStreet3 { get; set; }
        public string PtntStreetcode { get; set; }
        public string PtntPostal1 { get; set; }
        public string PtntPostal2 { get; set; }
        public string PtntPostal3 { get; set; }
        public string PtntPostalcode { get; set; }
        public string PtntWorkname { get; set; }
        public string PtntWork1 { get; set; }
        public string PtntWork2 { get; set; }
        public string PtntWork3 { get; set; }
        public string PtntWorkcode { get; set; }
        public string PtntHomephone { get; set; }
        public string PtntOtherphone { get; set; }
        public string PtntHomefax { get; set; }
        public string PtntCellphone { get; set; }
        public string PtntEmailaddr { get; set; }
        public string PtntWorkphone { get; set; }
        public string PtntIndex { get; set; }
        public string PtntNationalnum { get; set; }
        public string PtntCodes { get; set; }
        public string PtntOccupation { get; set; }
        public string PtntPlaceofbirth { get; set; }
        public string PtntFolder { get; set; }
        public string PtntUser1 { get; set; }
        public string PtntUser2 { get; set; }
        public string PtntUser3 { get; set; }
        public string PtntUser4 { get; set; }
        public string PtntUser5 { get; set; }
        public string PtntMaidenname { get; set; }
        public string PtntMiddleinitial { get; set; }
        public long? PtntType { get; set; }
        public long? LklsIdMaritalstatus { get; set; }
        public string PtntSurnameupper { get; set; }
        public string PtntFirstnameupper { get; set; }
        public long PtntDeletedid { get; set; }
        public short PtntAutocase { get; set; }
        public short PtntUsestreetpostal { get; set; }
        public short PtntFamilyhead { get; set; }
        public short PtntResident { get; set; }
        public DateTime? PtntDatefirstseen { get; set; }
        public DateTime? PtntDatelastseen { get; set; }
        public string PtntGms { get; set; }
        public DateTime? PtntLastarrivaldate { get; set; }
        public string PtntAliasname { get; set; }
        public DateTime PtntDatelastchanged { get; set; }
        public long? PtntStreetstate { get; set; }
        public long? PtntPostalstate { get; set; }
        public long? PtntWorkstate { get; set; }
        public long PtntUsualpaymentmethod { get; set; }
        public short PtntShouldalwaysreconcile { get; set; }
        public short PtntShouldholdaccount { get; set; }
        public short PtntAlwaystogurantor { get; set; }
        public long? ShcdIdServicerate { get; set; }
        public long? ShcdIdServicediscount { get; set; }
        public long? PtntIdInsurer { get; set; }
        public long? ShcdIdPlan { get; set; }
        public string PtntMemberid { get; set; }
        public short PtntPasstoinsurer { get; set; }
        public decimal PtntCoinsurancepercentage { get; set; }
        public long? PtntFamilyhxOid { get; set; }
        public long? PtntPasthxOid { get; set; }
        public long? PtntSocialhxOid { get; set; }
        public DateTime? RegDate { get; set; }
        public string PtntBuildingstreet { get; set; }
        public string PtntBuildingpostal { get; set; }
        public long? LklsIdEthnicity2 { get; set; }
        public long? LklsIdEthnicity3 { get; set; }
        public string PtntIwi { get; set; }
        public long? PtntLeadcaregiver { get; set; }
        public string PtntMathapu { get; set; }
        public string PtntMatheritage { get; set; }
        public string PtntPathapu { get; set; }
        public string PtntPatheritage { get; set; }
        public long? PtntLabel { get; set; }
        public DateTime? LastconfirmedDate { get; set; }
        public string PtntEmailaddrupper { get; set; }
        public string PtntWebusername { get; set; }
        public string PtntWebpassword { get; set; }
        public DateTime? PtntWeblastvisit { get; set; }
        public string PtntHerecomputer { get; set; }
        public DateTime? PtntHeredatetime { get; set; }
        public DateTime? PtntGonedatetime { get; set; }
        public long? PtntPayerId { get; set; }
        public short PtntEmlduerecallsnotif { get; set; }
        public short PtntEmlappntreminders { get; set; }
        public long? PtntEmployerId { get; set; }
        public long? UsualPayerType { get; set; }
        public string PtntGeoCoordX { get; set; }
        public string PtntGeoCoordY { get; set; }
        public string PtntMeshblock { get; set; }
        public string PtntQuintile { get; set; }
        public DateTime? LastCheckedDate { get; set; }
        public string PtntGeoDhb { get; set; }
        public string PtntGeoUncertaintycode { get; set; }
        public short PtntAllowcapitation { get; set; }
        public double? PtntGeoLatitude { get; set; }
        public double? PtntGeoLongitude { get; set; }
        public string PtntSourceref { get; set; }
        public long? PtntStreetCountry { get; set; }
        public long? PtntPostCountry { get; set; }
        public long? PtntWorkCountry { get; set; }
        public long? ShcdIdPreflanguage { get; set; }
        public long? ShcdIdHomelanguage { get; set; }
        public short PtntInterpreterrequired { get; set; }
        public long? PtntObstetricHxOid { get; set; }
        public string PtntBloodGroup { get; set; }
        public long? PtntDeletedUserid { get; set; }
        public string PtntDeletedReason { get; set; }
        public DateTime? PtntDeletedDate { get; set; }
        public long? ShcdIdJournals { get; set; }
        public short PtntShowintotals { get; set; }
        public string PtntMpi { get; set; }
        public DateTime? PtntLastmpidatetime { get; set; }
        public short PtntApplyGst { get; set; }
        public short PtntSenddischarge { get; set; }
        public short PtntAccredited { get; set; }
        public long? PtntTpaId { get; set; }
        public DateTime? PtntLastaddresschanged { get; set; }
        public string PtntMaidennameupper { get; set; }
        public string PtntAliasnameupper { get; set; }
        public long? ShcdIdServicecategory { get; set; }
        public long? ShcdIdLivingsituation { get; set; }
        public long? ShcdIdBenefittype { get; set; }
        public long? ShcdIdHealthstatus { get; set; }
        public long? ShcdIdTargettype { get; set; }
        public long? PtntOrgId { get; set; }
        public long? PtntWebprofileid { get; set; }
        public string PtntDomicileCode { get; set; }
        public long? PtntCountryOfBirth { get; set; }
        public long? PtntMasterPtntId { get; set; }
        public string Code { get; set; }
        public DateTime Created { get; set; }
        public DateTime Deleted { get; set; }
        public long? Createdby { get; set; }
        public long? Deletedby { get; set; }
        public long Version { get; set; }
        public string PtntPatientcode { get; set; }
        public long PtntGeoStatus { get; set; }
        public short PtntInfantOrDependent { get; set; }
        public string PtntNationalnumSystem { get; set; }
        public long PartitionId { get; set; }
        public string RefSys { get; set; }
        public string RefId { get; set; }
        public DateTime DtModified { get; set; }
        public string PtntPrefnameupper { get; set; }
        public short Sealed { get; set; }
        public long? PtntShcdIdIwi { get; set; }
        public short PtntOnlineEligibility { get; set; }
        public string PtntSoundexSurname { get; set; }
        public string PtntSoundexFirstname { get; set; }
        public string PtntDhb { get; set; }
        public string PtntPersonalotherphone { get; set; }
        public DateTime? PtntInactivationdate { get; set; }
        public long? PtntInactivationreason { get; set; }
        public long? PtntPosid { get; set; }
        public short PtntCheckprivacy { get; set; }
        public long? PtntPrivacyid { get; set; }
        public short PtntNotableperson { get; set; }
        public string PtntVersioncode { get; set; }
        public long PtntPreferredPhoneType { get; set; }
        public long? PtntPreferredPhoneId { get; set; }
        public long PtntPreferredEmailType { get; set; }
        public long? PtntPreferredEmailId { get; set; }
        public short PtntIssmscellphone { get; set; }
        public short ForceWebPassChange { get; set; }
        public short PtntWebenable { get; set; }
        public string MpiSystemName { get; set; }
        public string Residency { get; set; }
        public long? PatientTouchId { get; set; }
        public short ShowAcknowledgment { get; set; }
        public DateTime? AcknowledgmentLastRead { get; set; }
        public short PtntJoinCentralAbility { get; set; }
        public string PtntPatientcodesort { get; set; }
        public long? PrivacyOrg { get; set; }
        public short PtntOptOutSharing { get; set; }
        public long PtntIhnOpt { get; set; }
        public short PtntDirectLogonList { get; set; }
        public string PtntIhnPassword { get; set; }
        public string PtntIhnPasswordHint { get; set; }
        public DateTime? PtntIhnPasschanged { get; set; }
        public DateTime? PasswordExpiryDate { get; set; }
        public string ObjGuid { get; set; }
        public short PtntIsemailnotifyallowed { get; set; }
        public long? PtntPreferrednotifymethod { get; set; }
        public DateTime? PtntEmploymentFrom { get; set; }
        public string PtntEmploymentPosition { get; set; }
        public string PtntBuildingWork { get; set; }
        public long? PtntNamesuffix { get; set; }
        public long? PtntTransferStatus { get; set; }
        public long? PtntTransferStatusChangedBy { get; set; }
        public DateTime? PtntTransferStatusChangedOn { get; set; }
        public DateTime? PtntStatusChanged { get; set; }
        public short PtntIgnoredDuplSearch { get; set; }
        public long PtntAllowEprescr { get; set; }
        public string PtntDecile { get; set; }
        public string PtntTlaName { get; set; }
        public string PtntDomicileDescription { get; set; }
        public DateTime? PtntNationalnumExpiry { get; set; }
        public long PtntRegistered { get; set; }
        public long? PtntSrcProviderid { get; set; }
        public long? PtntSocialhxSrcProviderid { get; set; }
        public long? PtntParent1 { get; set; }
        public long? PtntParent1rel { get; set; }
        public long? PtntParent2 { get; set; }
        public long? PtntParent2rel { get; set; }
        public long? PtntLeadcarerel { get; set; }
        public DateTime PtntLastactivitydate { get; set; }
        public short PtntCtgRegistered { get; set; }
        public string PtntWebPasswordHash { get; set; }
        public long? LklsIdEthnicity4 { get; set; }
        public long? LklsIdEthnicity5 { get; set; }
        public long? LklsIdEthnicity6 { get; set; }
        public short StreetAddressUnknown { get; set; }

        public CdoPerson CreatedbyNavigation { get; set; }
        public CdoPerson DeletedbyNavigation { get; set; }
        public Lookuplist LklsIdEthnicity2Navigation { get; set; }
        public Lookuplist LklsIdEthnicity3Navigation { get; set; }
        public Lookuplist LklsIdEthnicity4Navigation { get; set; }
        public Lookuplist LklsIdEthnicity5Navigation { get; set; }
        public Lookuplist LklsIdEthnicity6Navigation { get; set; }
        public Lookuplist LklsIdEthnicityNavigation { get; set; }
        public Lookuplist LklsIdMaritalstatusNavigation { get; set; }
        public Lookuplist LklsIdOccupationNavigation { get; set; }
        public Lookuplist LklsIdReligionNavigation { get; set; }
        public Pppu PppuIdAltdrNavigation { get; set; }
        public Pppu PppuIdUsualdrNavigation { get; set; }
        public Pppu PtntDeletedUser { get; set; }
        public Patient PtntEmployer { get; set; }
        public Blobs PtntFamilyhxO { get; set; }
        public Patient PtntIdGuarantorNavigation { get; set; }
        public Patient PtntIdInsurerNavigation { get; set; }
        public Patient PtntIdPartnerNavigation { get; set; }
        public Patient PtntLeadcaregiverNavigation { get; set; }
        public Lookuplist PtntLeadcarerelNavigation { get; set; }
        public Patient PtntMasterPtnt { get; set; }
        public Shortcode PtntNamesuffixNavigation { get; set; }
        public Blobs PtntObstetricHxO { get; set; }
        public OrgStructure PtntOrg { get; set; }
        public Patient PtntParent1Navigation { get; set; }
        public Lookuplist PtntParent1relNavigation { get; set; }
        public Patient PtntParent2Navigation { get; set; }
        public Lookuplist PtntParent2relNavigation { get; set; }
        public Blobs PtntPasthxO { get; set; }
        public Patient PtntPayer { get; set; }
        public Lookuplist PtntPostalstateNavigation { get; set; }
        public Blobs PtntSocialhxO { get; set; }
        public Pppu PtntSocialhxSrcProvider { get; set; }
        public Pppu PtntSrcProvider { get; set; }
        public Lookuplist PtntStreetstateNavigation { get; set; }
        public Pppu PtntTransferStatusChangedByNavigation { get; set; }
        public Lookuplist PtntWorkstateNavigation { get; set; }
        public Shortcode ShcdIdBenefittypeNavigation { get; set; }
        public Shortcode ShcdIdHealthstatusNavigation { get; set; }
        public Shortcode ShcdIdHomelanguageNavigation { get; set; }
        public Shortcode ShcdIdJournalsNavigation { get; set; }
        public Shortcode ShcdIdLivingsituationNavigation { get; set; }
        public Shortcode ShcdIdPlanNavigation { get; set; }
        public Shortcode ShcdIdPreflanguageNavigation { get; set; }
        public Shortcode ShcdIdServicecategoryNavigation { get; set; }
        public Shortcode ShcdIdServicediscountNavigation { get; set; }
        public Shortcode ShcdIdServicerateNavigation { get; set; }
        public Shortcode ShcdIdTargettypeNavigation { get; set; }
        public ICollection<Address> Address { get; set; }
        public ICollection<Appointment> Appointment { get; set; }
        public ICollection<Appointmentaudit> Appointmentaudit { get; set; }
        public ICollection<Bcase> Bcase { get; set; }
        public ICollection<CareTeam> CareTeamCtPatientNavigation { get; set; }
        public ICollection<CareTeam> CareTeamCtPayer { get; set; }
        public ICollection<CaseAudit> CaseAudit { get; set; }
        public ICollection<ContactActionLink> ContactActionLink { get; set; }
        public ICollection<Patient> InversePtntEmployer { get; set; }
        public ICollection<Patient> InversePtntIdGuarantorNavigation { get; set; }
        public ICollection<Patient> InversePtntIdInsurerNavigation { get; set; }
        public ICollection<Patient> InversePtntIdPartnerNavigation { get; set; }
        public ICollection<Patient> InversePtntLeadcaregiverNavigation { get; set; }
        public ICollection<Patient> InversePtntMasterPtnt { get; set; }
        public ICollection<Patient> InversePtntParent1Navigation { get; set; }
        public ICollection<Patient> InversePtntParent2Navigation { get; set; }
        public ICollection<Patient> InversePtntPayer { get; set; }
        public ICollection<PatientAlternatName> PatientAlternatName { get; set; }
        public ICollection<PatientAudit> PatientAuditObserverPtnt { get; set; }
        public ICollection<PatientAudit> PatientAuditPaudtPtnt { get; set; }
        public ICollection<PatientInfoAudit> PatientInfoAuditObserverPtnt { get; set; }
        public ICollection<PatientInfoAudit> PatientInfoAuditPiaudPtnt { get; set; }
        public ICollection<PatientMergeLog> PatientMergeLogMaster { get; set; }
        public ICollection<PatientMergeLog> PatientMergeLogSub { get; set; }
        public ICollection<Patientproblem> Patientproblem { get; set; }
        public ICollection<Patientrecallvisit> PatientrecallvisitPrvsOtherPatient { get; set; }
        public ICollection<Patientrecallvisit> PatientrecallvisitPrvsPerformedbyPatient { get; set; }
        public ICollection<Pppu> Pppu { get; set; }
        public ICollection<UserSecurityLog> UserSecurityLog { get; set; }
    }
}
