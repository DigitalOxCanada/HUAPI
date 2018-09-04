using System;
using System.Collections.Generic;

namespace Profile7ClassLibrary.Entities
{
    public partial class CdoPerson
    {
        public CdoPerson()
        {
            CareTeamCreatedbyNavigation = new HashSet<CareTeam>();
            CareTeamCtClosedByNavigation = new HashSet<CareTeam>();
            CareTeamDeletedbyNavigation = new HashSet<CareTeam>();
            CdoOrganizationCreatedbyNavigation = new HashSet<CdoOrganization>();
            CdoOrganizationDeletedbyNavigation = new HashSet<CdoOrganization>();
            CdoPersonImage = new HashSet<CdoPersonImage>();
            CdoTermset = new HashSet<CdoTermset>();
            CdoTermsetConcept = new HashSet<CdoTermsetConcept>();
            CdoTermsetTerm = new HashSet<CdoTermsetTerm>();
            CdoTransAqHcpAssignedNavigation = new HashSet<CdoTrans>();
            CdoTransAqHcpAuthorizedNavigation = new HashSet<CdoTrans>();
            CdoTransCreatedbyNavigation = new HashSet<CdoTrans>();
            CdoTransDeletedbyNavigation = new HashSet<CdoTrans>();
            CdoTransFirstcreatedbyNavigation = new HashSet<CdoTrans>();
            CdoTransRef2O = new HashSet<CdoTrans>();
            CdoTransdata = new HashSet<CdoTransdata>();
            ContactActionLinkCreatedbyNavigation = new HashSet<ContactActionLink>();
            ContactActionLinkDeletedbyNavigation = new HashSet<ContactActionLink>();
            PatientAlternatNameCreatedbyNavigation = new HashSet<PatientAlternatName>();
            PatientAlternatNameDeletedbyNavigation = new HashSet<PatientAlternatName>();
            PatientCreatedbyNavigation = new HashSet<Patient>();
            PatientDeletedbyNavigation = new HashSet<Patient>();
            PatientproblemCreatedbyNavigation = new HashSet<Patientproblem>();
            PatientproblemDeletedbyNavigation = new HashSet<Patientproblem>();
            PatientrecallvisitCreatedbyNavigation = new HashSet<Patientrecallvisit>();
            PatientrecallvisitDeletedbyNavigation = new HashSet<Patientrecallvisit>();
            PppuCreatedbyNavigation = new HashSet<Pppu>();
            PppuDeletedbyNavigation = new HashSet<Pppu>();
        }

        public string Name { get; set; }
        public long Cid { get; set; }
        public long RealId { get; set; }
        public long Oid { get; set; }
        public byte[] AccessionPrefs { get; set; }
        public long PartitionId { get; set; }
        public string RefSys { get; set; }
        public string RefId { get; set; }
        public DateTime DtModified { get; set; }
        public string ObjGuid { get; set; }

        public ICollection<CareTeam> CareTeamCreatedbyNavigation { get; set; }
        public ICollection<CareTeam> CareTeamCtClosedByNavigation { get; set; }
        public ICollection<CareTeam> CareTeamDeletedbyNavigation { get; set; }
        public ICollection<CdoOrganization> CdoOrganizationCreatedbyNavigation { get; set; }
        public ICollection<CdoOrganization> CdoOrganizationDeletedbyNavigation { get; set; }
        public ICollection<CdoPersonImage> CdoPersonImage { get; set; }
        public ICollection<CdoTermset> CdoTermset { get; set; }
        public ICollection<CdoTermsetConcept> CdoTermsetConcept { get; set; }
        public ICollection<CdoTermsetTerm> CdoTermsetTerm { get; set; }
        public ICollection<CdoTrans> CdoTransAqHcpAssignedNavigation { get; set; }
        public ICollection<CdoTrans> CdoTransAqHcpAuthorizedNavigation { get; set; }
        public ICollection<CdoTrans> CdoTransCreatedbyNavigation { get; set; }
        public ICollection<CdoTrans> CdoTransDeletedbyNavigation { get; set; }
        public ICollection<CdoTrans> CdoTransFirstcreatedbyNavigation { get; set; }
        public ICollection<CdoTrans> CdoTransRef2O { get; set; }
        public ICollection<CdoTransdata> CdoTransdata { get; set; }
        public ICollection<ContactActionLink> ContactActionLinkCreatedbyNavigation { get; set; }
        public ICollection<ContactActionLink> ContactActionLinkDeletedbyNavigation { get; set; }
        public ICollection<PatientAlternatName> PatientAlternatNameCreatedbyNavigation { get; set; }
        public ICollection<PatientAlternatName> PatientAlternatNameDeletedbyNavigation { get; set; }
        public ICollection<Patient> PatientCreatedbyNavigation { get; set; }
        public ICollection<Patient> PatientDeletedbyNavigation { get; set; }
        public ICollection<Patientproblem> PatientproblemCreatedbyNavigation { get; set; }
        public ICollection<Patientproblem> PatientproblemDeletedbyNavigation { get; set; }
        public ICollection<Patientrecallvisit> PatientrecallvisitCreatedbyNavigation { get; set; }
        public ICollection<Patientrecallvisit> PatientrecallvisitDeletedbyNavigation { get; set; }
        public ICollection<Pppu> PppuCreatedbyNavigation { get; set; }
        public ICollection<Pppu> PppuDeletedbyNavigation { get; set; }
    }
}
