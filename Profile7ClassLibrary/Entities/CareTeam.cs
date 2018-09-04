using System;
using System.Collections.Generic;

namespace Profile7ClassLibrary.Entities
{
    public partial class CareTeam
    {
        public CareTeam()
        {
            InverseMaster = new HashSet<CareTeam>();
        }

        public long Oid { get; set; }
        public long? CtCaseId { get; set; }
        public long? CtRole { get; set; }
        public long? CtType { get; set; }
        public long CtPersonId { get; set; }
        public long? CtStatus { get; set; }
        public string CtComments { get; set; }
        public long? CtClosedBy { get; set; }
        public long? CtPrivacyid { get; set; }
        public long CtPatient { get; set; }
        public short CtPrincipal { get; set; }
        public long PartitionId { get; set; }
        public string RefSys { get; set; }
        public string RefId { get; set; }
        public DateTime DtModified { get; set; }
        public long MasterId { get; set; }
        public long Version { get; set; }
        public DateTime Created { get; set; }
        public DateTime Deleted { get; set; }
        public long? Createdby { get; set; }
        public long? Deletedby { get; set; }
        public long CtSharedPlanPrivacy { get; set; }
        public DateTime CtDate { get; set; }
        public DateTime CtClosedDate { get; set; }
        public DateTime CtDateFrom { get; set; }
        public DateTime CtDateTo { get; set; }
        public long? CtOriginPartitionId { get; set; }
        public short CtIscurrent { get; set; }
        public long? PrivacyPppuId { get; set; }
        public long? PrivacyOrg { get; set; }
        public long? CtPppuRole { get; set; }
        public string ObjGuid { get; set; }
        public long? CtPayerId { get; set; }

        public CdoPerson CreatedbyNavigation { get; set; }
        public Bcase CtCase { get; set; }
        public CdoPerson CtClosedByNavigation { get; set; }
        public Partition CtOriginPartition { get; set; }
        public Patient CtPatientNavigation { get; set; }
        public Patient CtPayer { get; set; }
        public Pppu CtPerson { get; set; }
        public AppRole CtPppuRoleNavigation { get; set; }
        public AppRole CtPrivacy { get; set; }
        public Shortcode CtRoleNavigation { get; set; }
        public CdoPerson DeletedbyNavigation { get; set; }
        public CareTeam Master { get; set; }
        public Pppu PrivacyPppu { get; set; }
        public ICollection<CareTeam> InverseMaster { get; set; }
    }
}
