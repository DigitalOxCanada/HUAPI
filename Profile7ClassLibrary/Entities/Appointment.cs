using System;
using System.Collections.Generic;

namespace Profile7ClassLibrary.Entities
{
    public partial class Appointment
    {
        public Appointment()
        {
            Appointmentaudit = new HashSet<Appointmentaudit>();
            CdoTrans = new HashSet<CdoTrans>();
            InverseApntGroupNavigation = new HashSet<Appointment>();
            InverseApntMainAppt = new HashSet<Appointment>();
        }

        public long ApntId { get; set; }
        public DateTime? ApntArrivaltime { get; set; }
        public DateTime? ApntSeentime { get; set; }
        public DateTime? ApntInvoicetime { get; set; }
        public DateTime ApntBooktime { get; set; }
        public long ApntVersion { get; set; }
        public long? SrvcIdReason { get; set; }
        public string ApntReasondescription { get; set; }
        public long? PtntId { get; set; }
        public long? ShcdIdType { get; set; }
        public short ApntIslocked { get; set; }
        public short ApntIsdeleted { get; set; }
        public long ApntDuration { get; set; }
        public long? ApntFlags { get; set; }
        public string ApntComment { get; set; }
        public long? ApntPrvsId { get; set; }
        public long? ApntCaseId { get; set; }
        public long? ApntReferralId { get; set; }
        public long? ApntPrappovId { get; set; }
        public short ApntIsclosed { get; set; }
        public DateTime? ApntDischargetime { get; set; }
        public long? PppuIdPos { get; set; }
        public long? PppuIdProvider { get; set; }
        public DateTime? ApntConfirmtime { get; set; }
        public long? ApntStatus { get; set; }
        public short ApntNeedconfirmation { get; set; }
        public long? ApntGroup { get; set; }
        public short ApntIsdna { get; set; }
        public short ApntIscancelled { get; set; }
        public long? PppuIdSeenby { get; set; }
        public long? ShcdIdPriority { get; set; }
        public long? ShcdIdLocation { get; set; }
        public long? ApntRecurrency { get; set; }
        public long? Cid { get; set; }
        public long? ShcdIdPaycode { get; set; }
        public float? ApntKm { get; set; }
        public long? ApntSeenDuration { get; set; }
        public short ApntIsMeeting { get; set; }
        public long? RoleId { get; set; }
        public short ApntIsreschedule { get; set; }
        public DateTime? ApntEndtime { get; set; }
        public long PartitionId { get; set; }
        public string RefSys { get; set; }
        public string RefId { get; set; }
        public DateTime DtModified { get; set; }
        public long? EarlierRequest { get; set; }
        public DateTime? ApntCreatedOn { get; set; }
        public long? ApntFrontDeskNoteId { get; set; }
        public DateTime? ApntConsultDuration { get; set; }
        public long? ApntMeetingLimit { get; set; }
        public long? ApntSessionId { get; set; }
        public short ApntLetter { get; set; }
        public short ApntUnbooked { get; set; }
        public short ApntAnonymous { get; set; }
        public long? ApntMainApptId { get; set; }
        public short ApntInternallyInitiated { get; set; }
        public short ApntAcknowledged { get; set; }
        public short ApntIsManuallyClosed { get; set; }
        public long? PrivacyPppuId { get; set; }
        public long? PrivacyOrg { get; set; }
        public DateTime? ApntPendingInvoice { get; set; }
        public string ObjGuid { get; set; }
        public short ApntIsNotified { get; set; }
        public string ApntLastNotificationRslt { get; set; }
        public string ApntSourceref { get; set; }
        public long? Createdby { get; set; }
        public long? Modifiedby { get; set; }
        public long? ApntCancellationReason { get; set; }
        public long? ApntLocationType { get; set; }
        public long? ApntLocationAddressId { get; set; }

        public Shortcode ApntCancellationReasonNavigation { get; set; }
        public Bcase ApntCase { get; set; }
        public Appointment ApntGroupNavigation { get; set; }
        public Address ApntLocationAddress { get; set; }
        public Appointment ApntMainAppt { get; set; }
        public Patientrecallvisit ApntPrvs { get; set; }
        public Pppu CreatedbyNavigation { get; set; }
        public Pppu ModifiedbyNavigation { get; set; }
        public Pppu PppuIdPosNavigation { get; set; }
        public Pppu PppuIdProviderNavigation { get; set; }
        public Pppu PppuIdSeenbyNavigation { get; set; }
        public Pppu PrivacyPppu { get; set; }
        public Patient Ptnt { get; set; }
        public AppRole Role { get; set; }
        public Shortcode ShcdIdLocationNavigation { get; set; }
        public Shortcode ShcdIdPaycodeNavigation { get; set; }
        public Shortcode ShcdIdPriorityNavigation { get; set; }
        public Shortcode ShcdIdTypeNavigation { get; set; }
        public ICollection<Appointmentaudit> Appointmentaudit { get; set; }
        public ICollection<CdoTrans> CdoTrans { get; set; }
        public ICollection<Appointment> InverseApntGroupNavigation { get; set; }
        public ICollection<Appointment> InverseApntMainAppt { get; set; }
    }
}
