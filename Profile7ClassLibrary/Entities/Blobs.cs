using System;
using System.Collections.Generic;

namespace Profile7ClassLibrary.Entities
{
    public partial class Blobs
    {
        public Blobs()
        {
            CaseTemplates = new HashSet<CaseTemplates>();
            CdoTermset = new HashSet<CdoTermset>();
            PatientPtntFamilyhxO = new HashSet<Patient>();
            PatientPtntObstetricHxO = new HashSet<Patient>();
            PatientPtntPasthxO = new HashSet<Patient>();
            PatientPtntSocialhxO = new HashSet<Patient>();
            PppuPppuExtprovcustomrepNavigation = new HashSet<Pppu>();
            PppuPppuSignature = new HashSet<Pppu>();
        }

        public byte[] Item { get; set; }
        public long? Cid { get; set; }
        public long Oid { get; set; }
        public long PartitionId { get; set; }
        public string RefSys { get; set; }
        public string RefId { get; set; }
        public DateTime DtModified { get; set; }
        public string ObjGuid { get; set; }

        public ICollection<CaseTemplates> CaseTemplates { get; set; }
        public ICollection<CdoTermset> CdoTermset { get; set; }
        public ICollection<Patient> PatientPtntFamilyhxO { get; set; }
        public ICollection<Patient> PatientPtntObstetricHxO { get; set; }
        public ICollection<Patient> PatientPtntPasthxO { get; set; }
        public ICollection<Patient> PatientPtntSocialhxO { get; set; }
        public ICollection<Pppu> PppuPppuExtprovcustomrepNavigation { get; set; }
        public ICollection<Pppu> PppuPppuSignature { get; set; }
    }
}
