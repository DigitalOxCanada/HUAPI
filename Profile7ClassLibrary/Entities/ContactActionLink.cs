using System;
using System.Collections.Generic;

namespace Profile7ClassLibrary.Entities
{
    public partial class ContactActionLink
    {
        public long Oid { get; set; }
        public long? CoalCntcOid { get; set; }
        public long? CoalServiceOid { get; set; }
        public long? CoalLinkCid { get; set; }
        public long? CoalLinkOid { get; set; }
        public short CoalIsMasterService { get; set; }
        public long? CoalVerb { get; set; }
        public string CoalDescription { get; set; }
        public long? CoalStatus { get; set; }
        public DateTime? CoalPending { get; set; }
        public DateTime? CoalActioned { get; set; }
        public DateTime? CoalReceived { get; set; }
        public DateTime? CoalConcluded { get; set; }
        public long? CoalHowConcluded { get; set; }
        public short CoalBill { get; set; }
        public long? CoalInvoiceOid { get; set; }
        public string CoalInvoiceNote { get; set; }
        public long? CoalRate { get; set; }
        public long? CoalCaseid { get; set; }
        public long? CoalPos { get; set; }
        public long? CoalProvider { get; set; }
        public long? CoalPatient { get; set; }
        public short CoalSrvforceontonextinv { get; set; }
        public string Code { get; set; }
        public long Version { get; set; }
        public DateTime Created { get; set; }
        public DateTime Deleted { get; set; }
        public long? Createdby { get; set; }
        public long? Deletedby { get; set; }
        public long? CoalParentServiceOid { get; set; }
        public long PartitionId { get; set; }
        public string RefSys { get; set; }
        public string RefId { get; set; }
        public DateTime DtModified { get; set; }
        public long? CoalQuoteId { get; set; }
        public string ObjGuid { get; set; }
        public double? CoalQuantity { get; set; }

        public Bcase CoalCase { get; set; }
        public CdoTransdata CoalCntcO { get; set; }
        public Patient CoalPatientNavigation { get; set; }
        public Pppu CoalPosNavigation { get; set; }
        public Pppu CoalProviderNavigation { get; set; }
        public Shortcode CoalRateNavigation { get; set; }
        public CdoPerson CreatedbyNavigation { get; set; }
        public CdoPerson DeletedbyNavigation { get; set; }
    }
}
