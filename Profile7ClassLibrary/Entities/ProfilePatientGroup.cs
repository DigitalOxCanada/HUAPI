using System;
using System.Collections.Generic;

namespace Profile7ClassLibrary.Entities
{
    public partial class ProfilePatientGroup
    {
        public ProfilePatientGroup()
        {
            InversePpgFirstGroupNavigation = new HashSet<ProfilePatientGroup>();
            InversePpgSecondGroupNavigation = new HashSet<ProfilePatientGroup>();
        }

        public long Oid { get; set; }
        public long Cid { get; set; }
        public long? ComplexFilterOid { get; set; }
        public long? PrivateTo { get; set; }
        public long PpgStatus { get; set; }
        public long? PpgPrivacy { get; set; }
        public long? PpgFirstGroup { get; set; }
        public long? PpgSecondGroup { get; set; }
        public long PpgOperation { get; set; }
        public long Deletedid { get; set; }
        public long PartitionId { get; set; }
        public string RefSys { get; set; }
        public string RefId { get; set; }
        public DateTime DtModified { get; set; }
        public byte[] PpgConditions { get; set; }
        public string Name { get; set; }
        public string ObjGuid { get; set; }
        public short PpgShowOnMobileDevices { get; set; }
        public long? PpgGroupKind { get; set; }
        public long? PpgOwner { get; set; }
        public string PpgDescription { get; set; }
        public long PpgViewsettingssource { get; set; }
        public byte[] PpgViewsettings { get; set; }
        public byte[] PpgDenominatorConditions { get; set; }
        public short PpgComparisonOutputEnabled { get; set; }
        public string PpgComparisonDescription { get; set; }
        public string PpgNumeratorDescription { get; set; }
        public short PpgNumeratorCountVisible { get; set; }
        public short PpgNumeratorPercentVisible { get; set; }
        public string PpgDenominatorDescription { get; set; }
        public short PpgDenominatorCountVisible { get; set; }
        public long GroupCategoryId { get; set; }

        public ProfilePatientGroup PpgFirstGroupNavigation { get; set; }
        public Pppu PpgOwnerNavigation { get; set; }
        public AppRole PpgPrivacyNavigation { get; set; }
        public ProfilePatientGroup PpgSecondGroupNavigation { get; set; }
        public Pppu PrivateToNavigation { get; set; }
        public ICollection<ProfilePatientGroup> InversePpgFirstGroupNavigation { get; set; }
        public ICollection<ProfilePatientGroup> InversePpgSecondGroupNavigation { get; set; }
    }
}
