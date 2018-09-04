using System;
using System.Collections.Generic;

namespace Profile7ClassLibrary.Entities
{
    public partial class PatientAlternatName
    {
        public PatientAlternatName()
        {
            InverseMaster = new HashSet<PatientAlternatName>();
        }

        public long Oid { get; set; }
        public long MasterId { get; set; }
        public DateTime Created { get; set; }
        public DateTime Deleted { get; set; }
        public long? Createdby { get; set; }
        public long? Deletedby { get; set; }
        public long Version { get; set; }
        public long PtanPtntId { get; set; }
        public string PtanName { get; set; }
        public string PtanNameupper { get; set; }
        public long PartitionId { get; set; }
        public string RefSys { get; set; }
        public string RefId { get; set; }
        public DateTime DtModified { get; set; }
        public string ObjGuid { get; set; }

        public CdoPerson CreatedbyNavigation { get; set; }
        public CdoPerson DeletedbyNavigation { get; set; }
        public PatientAlternatName Master { get; set; }
        public Patient PtanPtnt { get; set; }
        public ICollection<PatientAlternatName> InverseMaster { get; set; }
    }
}
