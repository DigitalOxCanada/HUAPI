using System;
using System.Collections;
using System.Collections.Specialized;

namespace HUAPICore.Services.Jaffa
{
    /// <summary>
    /// Enum of all the types
    /// </summary>
    public enum JaffaRecordType
    {
        ///Abnormal Presents
        ABPR,
        ///Accession Alerts Structure File
        ACAF,
        ///ACC Occupation Codes
        ACCC,
        ///ACEP
        ACEP,
        ///Accession Profile File
        ACPF,
        ///Accession Text Items File
        ACTI,
        ///All Data
        ADTA,
        ///Auto Execute JFA Records
        AEJF,
        ///Allergies
        ALGY,
        ///Alerts
        ALRT,
        ///Appointments
        APPT,
        ///Appt Templates
        APTM,
        ///Associations
        ASCS,
        ///Appt Rule
        ATMP,
        ///Brought Forward 30 Days
        BF30,
        ///Brought Forward 60 Days
        BF60,
        ///Brought Forward 90 Days
        BF90,
        ///Brought Forward Current
        BFCU,
        ///Transactions
        BFWD,
        ///Macro Button Collection
        BUCO,
        ///Cards and Plans
        CARD,
        ///Case
        CASE,
        ///Care Team
        CATE,
        ///CDO Forms
        CFRM,
        ///Health Record Collection
        CHRC,
        ///ACR Notes
        CNCA,
        ///ACR Notes Backup
        CNCB,
        ///ACR Encounters
        CNCC,
        ///ACR EncountersE
        CNCE,
        ///GPDat Notes
        CNCG,
        ///ACR EncountersI
        CNCI,
        ///ACR EncountersS
        CNCS,
        ///Contacts
        CNCT,
        ///Care Plan Template Group
        CPGR,
        ///Care Plan Templates
        CPLN,
        ///Case Template
        CSTT,
        ///Database Info
        DBNF,
        ///Document Library
        DCLB,
        ///Demonstration Maker
        DEMO,
        ///CDO Dictionary
        DICT,
        ///Disease Codes
        DISC,
        ///Disease Monitors
        DISM,
        ///Drug Database
        DRDB,
        ///External Codes
        ECDE,
        ///ExtProvider Electronic Format
        EFRM,
        ///eMessage services file
        EMSF,
        ///Encounter Messages
        ENME,
        ///Explanation of benefit Codes
        EOBC,
        ///External Providers
        EPRV,
        ///Flow Sheet Definitions
        FCDF,
        ///Form Migrated Wizard
        FFMW,
        ///Filters
        FLTS,
        ///Formulary
        FMLY,
        ///Find Objects Group
        FOGR,
        ///Forms
        FORM,
        ///Gp2Gp Format
        G2GF,
        ///Guidelines
        GDLS,
        ///Guarantor Links
        GUAR,
        ///HeadLine
        HDLF,
        ///Investigation Form Data
        IFDT,
        ///Images
        IMAG,
        ///Instruction template
        INTT,
        ///Invoices
        INVC,
        ///Investigation
        INVE,
        ///Prior Investigations
        INVP,
        ///Investigation
        INVR,
        ///Joints Forms
        JNTF,
        ///KPI
        KPIF,
        ///Short Code
        LKUP,
        ///ACR Education
        LTRE,
        ///ACR Education Files
        LTRF,
        ///Document Templates
        LTRT,
        ///Letters
        LTTR,
        ///Emails
        MAIL,
        ///Manual Transactions
        MATR,
        ///Manual Transaction Templates
        MATT,
        ///Measure
        MEAS,
        ///MHP Messages
        MHPM,
        ///Mental Health
        MTHL,
        ///Obstetric
        OBST,
        ///CDO Observations
        OBSV,
        ///Occupation Codes
        OCCN,
        ///Orders
        ORDR,
        ///OnTheGo Profile
        OTGP,
        ///Patient Histories
        PAHS,
        ///Measurements
        PAME,
        ///Patient Compilations
        PCMP,
        ///Histories
        PHST,
        ///Patient Measures
        PMEA,
        ///Next Of Kin
        PNOK,
        ///Provider Order Formats
        POFS,
        ///Post Codes
        POST,
        ///Profile Patients
        PPAT,
        ///People and Places
        PPPU,
        ///Prior Approvals
        PRAP,
        ///Bonus Codes
        PRBC,
        ///Procedure Codes
        PRCD,
        ///User and Role Preferences
        PREF,
        ///Patient Registrations
        PREG,
        ///Problems
        PROB,
        ///Procedures
        PROC,
        ///Travel Codes
        PRTC,
        ///Scaned Form Provider Order Format
        PSFS,
        ///Patient Groups
        PTGR,
        ///Queue Items
        QEIT,
        ///Calculator Indications File
        RCIF,
        ///CDO Rx Consumer Medicine Information
        RCMI,
        ///Result Drag Mappings
        RDMS,
        ///GPDat Screenings
        RECC,
        ///GPDat ImmunisationsI
        RECI,
        ///Care Plans
        RECL,
        ///GPDat Immunisations
        RECM,
        ///GPDat ScreeningsR
        RECQ,
        ///GPDat ImmunisationsR
        RECR,
        ///GPDat ScreeningsS
        RECS,
        ///Referrals
        REFL,
        ///References
        REFT,
        ///Regions
        REGN,
        ///Report Form Template
        REPF,
        ///CDO Rx Full Product Prescribing Information
        RFPI,
        ///Reference Series
        RFSR,
        ///Registry; Identifier Keys
        RKIK,
        ///Results
        RSLT,
        ///Rx for Mac
        RX4M,
        ///CDO Rx Database
        RXDB,
        ///Rx Dispense
        RXDS,
        ///CDO Rx Cross-References
        RXRF,
        ///SCCP Preferences File
        SCCP,
        ///Schedule Codes
        SCHL,
        ///Prior Scripts
        SCIP,
        ///SCCP message
        SCPM,
        ///GPDat Scripts
        SCRG,
        ///Scripts
        SCRI,
        ///SCCP response message
        SCRM,
        ///Shared Resource
        SHRC,
        ///Source Patients
        SPAT,
        ///Special Update
        SPEC,
        ///Supplier Data
        SPSI,
        ///Provider Services
        SRPS,
        ///Service Codes Without Prices
        SRVA,
        ///Service Codes
        SRVC,
        ///Service Code Prices
        SRVP,
        ///Service Set
        SRVS,
        ///Surgeries
        SURG,
        ///Patient Task
        TASK,
        ///Tables
        TBTR,
        ///Transport CDO Transaction
        TCTF,
        ///Termset
        TERM,
        ///Time zones
        TMZN,
        ///Travel Medicine
        TRMD,
        ///Additional Task Templates
        TSKT,
        ///Patient Text Pages
        TXPG,
        ///Typing Templates
        TYPT,
        ///Units and Measures
        UMEA,
        ///Review view
        VIEW,
        ///Visit Templates
        VTEM,
        ///WCB Form (Excel)
        WCBE,
        ///Web Services
        WSRV,
        ///Wait list
        WTLS
    }


    /// <summary>
    /// MAIN Specification class to define Profile specifications for making jaffa files.
    /// </summary>
    public class JaffaSpec : OrderedDictionary
    {
        /// <summary>
        /// Record type that leads the jaffa line.
        /// </summary>
        public string RecordType
        {
            get { return this["RecordType"].ToString(); }
            set { this["RecordType"] = value; }
        }

        /// <summary>
        /// The version of the record type. Currently not used to impact functionality.
        /// </summary>
        public string LineVersion
        {
            get { return this["LineVersion"].ToString(); }
            set { this["LineVersion"] = value; }
        }

        /// <summary>
        /// ctor
        /// </summary>
        public JaffaSpec()
        {
            throw new Exception("Must supply a specification in the constructor.");
        }

        /// <summary>
        /// Defines the jaffa fields based on type
        /// </summary>
        /// <param name="recordtype"></param>
        public JaffaSpec(JaffaRecordType recordtype)
        {
            switch (recordtype)
            {
                case JaffaRecordType.CNCT:    //Contacts
                    DefineFields(recordtype, 3, "RecordType", "LineVersion", "SourcePatID", "OriginalContactID", "DateOfContact", "TimeOfContact", "PlaceOfService", "ProviderOfService", "TypeCode", "Diagnosis",
                        "Service", "Note", "ExternalProvider", "GroupID", "Title", "Resolved", "ResolvedOn", "Duration", "Activity", "Location", "ChildProtection", "CaseService", "CefTemplate",
                        "SearchBy", "DtCreated", "NotAssignCaseService", "ParentContact", "CaseTitle", "CreatedBy", "Privacy", "NoteToText", "DeleteContactByContactID", "LinkedImagePath",
                        "LinkedImageSubject", "RefSysName", "RefSysNum", "IsDeleted", "GUID", "CaseGUID", "Section",
                        "SectionSysId", "LocationSysId", "TypeCodeSysId", "DiagnosisSysId", "MasterVersion", "MasterDateTime", "AuthProvider", "PlaceOfServiceGUID", "TypeCodeGUID",
                        "LocationGUID", "SectionGUID", "ProviderOfServiceGUID", "AuthProviderGUID", "CreatedByGUID", "ExternalProviderGUID", "DiagnosisGUID", "ServiceGUID", "ActivityGUID");
                    break;

                default:
                    throw new Exception("Specification not defined.");
            }
        }

        /// <summary>
        /// Creates the ordered dictionary of items in the order defined.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="ver"></param>
        /// <param name="flds"></param>
        public void DefineFields(JaffaRecordType type, int ver, params string[] flds)
        {
            foreach (string q in flds)
            {
                this.Add(q, "");
            }
            RecordType = type.ToString();
            LineVersion = ver.ToString();
        }

        /// <summary>
        /// Creates a tab delimited single line of text with all the fields and any values specified in the order they were defined.
        /// </summary>
        /// <returns></returns>
        public string ToJaffa()
        {
            IDictionaryEnumerator myEnumerator = this.GetEnumerator();
            string newstr = "";
            int i = 0;
            while (myEnumerator.MoveNext())
            {
                if (i++ > 0)
                {
                    newstr += "\t";    //TAB delimited
                }

                if (myEnumerator.Value != null)
                {
                    newstr += myEnumerator.Value;
                }
            }

            return newstr;
        }
    }
}
