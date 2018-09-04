using System;
using System.Collections.Generic;

namespace Profile7ClassLibrary.Entities
{
    public partial class CdoTrans
    {
        public CdoTrans()
        {
            CdoTransdata = new HashSet<CdoTransdata>();
        }

        public long Accessrights { get; set; }
        public long Amendrights { get; set; }
        public DateTime? AqDtAuthorized { get; set; }
        public long? AqHcpAssigned { get; set; }
        public long? AqHcpAssignedCid { get; set; }
        public long? AqHcpAuthorized { get; set; }
        public long? AqHcpAuthorizedCid { get; set; }
        public long? AqSource { get; set; }
        public string AqSourcetransref { get; set; }
        public long? AqWasgehr { get; set; }
        public long? AttendanceId { get; set; }
        public long? BcaseOid { get; set; }
        public short BlockFromPtnt { get; set; }
        public long? CaseServiceId { get; set; }
        public short Childprotect { get; set; }
        public long Cid { get; set; }
        public string Code { get; set; }
        public long? ContactTypeId { get; set; }
        public DateTime Created { get; set; }
        public long? Createdby { get; set; }
        public DateTime Deleted { get; set; }
        public long? Deletedby { get; set; }
        public long? Direction { get; set; }
        public DateTime? Dt1 { get; set; }
        public DateTime? Dt2 { get; set; }
        public DateTime Dtdisplay { get; set; }
        public DateTime DtModified { get; set; }
        public long Ehcr { get; set; }
        public long? EncounterType { get; set; }
        public long FilingCategory { get; set; }
        public DateTime Firstcreated { get; set; }
        public long? GroupSessionId { get; set; }
        public long? HcpA { get; set; }
        public long? HcpACid { get; set; }
        public long? HcpL { get; set; }
        public long? HcpLCid { get; set; }
        public short InclInCumulative { get; set; }
        public short IsAbnormal { get; set; }
        public long? LocationId { get; set; }
        public string ObjGuid { get; set; }
        public long Oid { get; set; }
        public long? Organization { get; set; }
        public long PartitionId { get; set; }
        public short PatientConsentBlock { get; set; }
        public long? PosId { get; set; }
        public long? PrivacyOrg { get; set; }
        public long? PrivacyPppuId { get; set; }
        public long? Ref1 { get; set; }
        public long? Ref1Cid { get; set; }
        public long? Ref2Cid { get; set; }
        public long? Ref2Oid { get; set; }
        public string RefId { get; set; }
        public string RefSys { get; set; }
        public long? RoleOid { get; set; }
        public long? ServiceId { get; set; }
        public long Status { get; set; }
        public byte[] Texts { get; set; }
        public long? Transdatatype { get; set; }
        public long? Transtype { get; set; }
        public short Unmatchedcopyto { get; set; }
        public short Unmatchedhrm { get; set; }
        public long Version { get; set; }
        public long? DocCategoryId { get; set; }
        public long? Firstcreatedby { get; set; }

        public CdoPerson AqHcpAssignedNavigation { get; set; }
        public CdoPerson AqHcpAuthorizedNavigation { get; set; }
        public CdoOrganization AqSourceNavigation { get; set; }
        public Appointment Attendance { get; set; }
        public Bcase BcaseO { get; set; }
        public Shortcode ContactType { get; set; }
        public CdoPerson CreatedbyNavigation { get; set; }
        public CdoPerson DeletedbyNavigation { get; set; }
        public Shortcode DocCategory { get; set; }
        public Shortcode EncounterTypeNavigation { get; set; }
        public CdoPerson FirstcreatedbyNavigation { get; set; }
        public Shortcode Location { get; set; }
        public CdoOrganization OrganizationNavigation { get; set; }
        public Pppu Pos { get; set; }
        public Pppu PrivacyPppu { get; set; }
        public CdoPerson Ref2O { get; set; }
        public AppRole RoleO { get; set; }
        public ICollection<CdoTransdata> CdoTransdata { get; set; }
    }
}
