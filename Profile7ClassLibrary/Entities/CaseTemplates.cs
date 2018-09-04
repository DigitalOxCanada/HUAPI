using System;
using System.Collections.Generic;

namespace Profile7ClassLibrary.Entities
{
    public partial class CaseTemplates
    {
        public CaseTemplates()
        {
            Bcase = new HashSet<Bcase>();
        }

        public long Oid { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public short CasePrivacyEnabled { get; set; }
        public short AdminPrivacyEnabled { get; set; }
        public short ClinicalPrivacyEnabled { get; set; }
        public short ColourEnabled { get; set; }
        public short TitleEnabled { get; set; }
        public short CaseSettingEnabled { get; set; }
        public long? CasePrivacy { get; set; }
        public long? AdminPrivacy { get; set; }
        public long? ClinicalPrivacy { get; set; }
        public long? Colour { get; set; }
        public string Title { get; set; }
        public long? CaseSetting { get; set; }
        public long Deletedid { get; set; }
        public long PartitionId { get; set; }
        public string RefSys { get; set; }
        public string RefId { get; set; }
        public DateTime DtModified { get; set; }
        public short EventTemplateEnabled { get; set; }
        public long? EventTemplate { get; set; }
        public string ObjGuid { get; set; }
        public short CareplanEnabled { get; set; }
        public short MixEnabled { get; set; }
        public short MixCommentEnabled { get; set; }
        public short MacroEnabled { get; set; }
        public long? Mix { get; set; }
        public string MixComment { get; set; }
        public long? Careplan { get; set; }
        public long? Macro { get; set; }

        public AppRole AdminPrivacyNavigation { get; set; }
        public AppRole CasePrivacyNavigation { get; set; }
        public Shortcode CaseSettingNavigation { get; set; }
        public AppRole ClinicalPrivacyNavigation { get; set; }
        public CdoTransdata EventTemplateNavigation { get; set; }
        public Blobs MacroNavigation { get; set; }
        public ICollection<Bcase> Bcase { get; set; }
    }
}
