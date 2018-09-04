using System;
using System.Collections.Generic;

namespace Profile7ClassLibrary.Entities
{
    public partial class CdoTransdata
    {
        public CdoTransdata()
        {
            AppRole = new HashSet<AppRole>();
            CaseTemplates = new HashSet<CaseTemplates>();
            ContactActionLink = new HashSet<ContactActionLink>();
            InverseCollectionNavigation = new HashSet<CdoTransdata>();
            InverseObsrefNavigation = new HashSet<CdoTransdata>();
            OrgStructureAlterpatientForm = new HashSet<OrgStructure>();
            OrgStructureDisplaypatientForm = new HashSet<OrgStructure>();
            OrgStructureNewpatientForm = new HashSet<OrgStructure>();
            OrgStructureTemplate = new HashSet<OrgStructure>();
            PatientrecallvisitContactO = new HashSet<Patientrecallvisit>();
            PatientrecallvisitPrvsContact = new HashSet<Patientrecallvisit>();
        }

        public string AbnormalCode { get; set; }
        public short BlockFromPtnt { get; set; }
        public long Cid { get; set; }
        public long Code { get; set; }
        public long? Collection { get; set; }
        public long? Concept { get; set; }
        public long? Conceptvalue { get; set; }
        public long? DataE { get; set; }
        public DateTime? Dt1 { get; set; }
        public DateTime? Dtobserved { get; set; }
        public DateTime DtModified { get; set; }
        public string Emphasis { get; set; }
        public short InclInCumulative { get; set; }
        public long? Infoprovider { get; set; }
        public long? LinkedobjectCid { get; set; }
        public long? LinkedobjectOid { get; set; }
        public string ObjGuid { get; set; }
        public long? Obsref { get; set; }
        public long Oid { get; set; }
        public long? Ord { get; set; }
        public long PartitionId { get; set; }
        public long? PosId { get; set; }
        public float? Qmax { get; set; }
        public float? Qmin { get; set; }
        public long? Qunit { get; set; }
        public long? Qunit2 { get; set; }
        public float? Qvalue { get; set; }
        public string RefId { get; set; }
        public string RefSys { get; set; }
        public long? Term { get; set; }
        public byte[] Texts { get; set; }
        public long Trans { get; set; }
        public long Versionmax { get; set; }
        public long Versionmin { get; set; }

        public CdoTransdata CollectionNavigation { get; set; }
        public CdoTermsetConcept ConceptNavigation { get; set; }
        public CdoTermsetConcept ConceptvalueNavigation { get; set; }
        public CdoPerson InfoproviderNavigation { get; set; }
        public CdoTransdata ObsrefNavigation { get; set; }
        public Pppu Pos { get; set; }
        public CdoTermsetTerm TermNavigation { get; set; }
        public CdoTrans TransNavigation { get; set; }
        public ICollection<AppRole> AppRole { get; set; }
        public ICollection<CaseTemplates> CaseTemplates { get; set; }
        public ICollection<ContactActionLink> ContactActionLink { get; set; }
        public ICollection<CdoTransdata> InverseCollectionNavigation { get; set; }
        public ICollection<CdoTransdata> InverseObsrefNavigation { get; set; }
        public ICollection<OrgStructure> OrgStructureAlterpatientForm { get; set; }
        public ICollection<OrgStructure> OrgStructureDisplaypatientForm { get; set; }
        public ICollection<OrgStructure> OrgStructureNewpatientForm { get; set; }
        public ICollection<OrgStructure> OrgStructureTemplate { get; set; }
        public ICollection<Patientrecallvisit> PatientrecallvisitContactO { get; set; }
        public ICollection<Patientrecallvisit> PatientrecallvisitPrvsContact { get; set; }
    }
}
