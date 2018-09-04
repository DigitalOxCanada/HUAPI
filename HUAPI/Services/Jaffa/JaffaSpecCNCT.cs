using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HUAPICore.Services.Jaffa
{
    /// <summary>
    /// Jaffa Spec for Contacts
    /// </summary>
    public class JaffaSpecCNCT : JaffaSpec
    {
        /// <summary>
        /// Ctor, call the base with the type
        /// </summary>
        public JaffaSpecCNCT() : base(JaffaRecordType.CNCT)
        {
        }

        /// <summary>
        /// this is the SourceRef field on the Patient table.
        /// The PtntPatientCode needs to be copied over to SourceRef field for this to associate to a patient properly.
        /// </summary>
        public string SourcePatID
        {
            get { return this["SourcePatID"].ToString(); }
            set { this["SourcePatID"] = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string OriginalContactID
        {
            get { return this["OriginalContactID"].ToString(); }
            set { this["OriginalContactID"] = value; }
        }

        /// <summary>
        /// Format dd/MM/yyyy
        /// </summary>
        public string DateOfContact
        {
            get { return this["DateOfContact"].ToString(); }
            set { this["DateOfContact"] = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string TimeOfContact
        {
            get { return this["TimeOfContact"].ToString(); }
            set { this["TimeOfContact"] = value; }
        }

        /// <summary>
        /// [Type:PPPU]	[LinkedTo:PPPU]
        /// Valid options: POS
        /// </summary>
        public string PlaceOfService
        {
            get { return this["PlaceOfService"].ToString(); }
            set { this["PlaceOfService"] = value; }
        }

        /// <summary>
        /// [Type:PPPU]	[LinkedTo:PPPU]
        /// Valid options: ADMIN
        /// </summary>
        public string ProviderOfService
        {
            get { return this["ProviderOfService"].ToString(); }
            set { this["ProviderOfService"] = value; }
        }

        /// <summary>
        /// [Type:ShortCode]	[LinkedTo:ShortCode]
        /// </summary>
        public string TypeCode
        {
            get { return this["TypeCode"].ToString(); }
            set { this["TypeCode"] = value; }
        }

        /// <summary>
        /// [Type:DiseaseCode]	[LinkedTo:DiseaseCode]
        /// </summary>
        public string Diagnosis
        {
            get { return this["Diagnosis"].ToString(); }
            set { this["Diagnosis"] = value; }
        }

        /// <summary>
        /// [Type:ServiceCode]	[LinkedTo:ServiceCode]
        /// </summary>
        public string Service
        {
            get { return this["Service"].ToString(); }
            set { this["Service"] = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Note
        {
            get { return this["Note"].ToString(); }
            set { this["Note"] = value; }
        }

        /// <summary>
        /// [Type:PPPU]	[LinkedTo:PPPU]
        /// </summary>
        public string ExternalProvider
        {
            get { return this["ExternalProvider"].ToString(); }
            set { this["ExternalProvider"] = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string GroupID
        {
            get { return this["GroupID"].ToString(); }
            set { this["GroupID"] = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Title
        {
            get { return this["Title"].ToString(); }
            set { this["Title"] = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Resolved
        {
            get { return this["Resolved"].ToString(); }
            set { this["Resolved"] = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string ResolvedOn
        {
            get { return this["ResolvedOn"].ToString(); }
            set { this["ResolvedOn"] = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Duration
        {
            get { return this["Duration"].ToString(); }
            set { this["Duration"] = value; }
        }

        /// <summary>
        /// [Type:ServiceCode]	[LinkedTo:ServiceCode]
        /// </summary>
        public string Activity
        {
            get { return this["Activity"].ToString(); }
            set { this["Activity"] = value; }
        }

        /// <summary>
        /// [Type:ShortCode]	[LinkedTo:ShortCode]
        /// </summary>
        public string Location
        {
            get { return this["Location"].ToString(); }
            set { this["Location"] = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string ChildProtection
        {
            get { return this["ChildProtection"].ToString(); }
            set { this["ChildProtection"] = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string CaseService
        {
            get { return this["CaseService"].ToString(); }
            set { this["CaseService"] = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string CefTemplate
        {
            get { return this["CefTemplate"].ToString(); }
            set { this["CefTemplate"] = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string SearchBy
        {
            get { return this["SearchBy"].ToString(); }
            set { this["SearchBy"] = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string DtCreated
        {
            get { return this["DtCreated"].ToString(); }
            set { this["DtCreated"] = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string NotAssignCaseService
        {
            get { return this["NotAssignCaseService"].ToString(); }
            set { this["NotAssignCaseService"] = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string ParentContact
        {
            get { return this["ParentContact"].ToString(); }
            set { this["ParentContact"] = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string CaseTitle
        {
            get { return this["CaseTitle"].ToString(); }
            set { this["CaseTitle"] = value; }
        }

        /// <summary>
        /// [Type:PPPU]	[LinkedTo:PPPU]
        /// </summary>
        public string CreatedBy
        {
            get { return this["CreatedBy"].ToString(); }
            set { this["CreatedBy"] = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Privacy
        {
            get { return this["Privacy"].ToString(); }
            set { this["Privacy"] = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string NoteToText
        {
            get { return this["NoteToText"].ToString(); }
            set { this["NoteToText"] = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string DeleteContactByContactID
        {
            get { return this["DeleteContactByContactID"].ToString(); }
            set { this["DeleteContactByContactID"] = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string LinkedImagePath
        {
            get { return this["LinkedImagePath"].ToString(); }
            set { this["LinkedImagePath"] = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string LinkedImageSubject
        {
            get { return this["LinkedImageSubject"].ToString(); }
            set { this["LinkedImageSubject"] = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string RefSysName
        {
            get { return this["RefSysName"].ToString(); }
            set { this["RefSysName"] = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string RefSysNum
        {
            get { return this["RefSysNum"].ToString(); }
            set { this["RefSysNum"] = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string IsDeleted
        {
            get { return this["IsDeleted"].ToString(); }
            set { this["IsDeleted"] = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string GUID
        {
            get { return this["GUID"].ToString(); }
            set { this["GUID"] = value; }
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string CaseGUID
        {
            get { return this["CaseGUID"].ToString(); }
            set { this["CaseGUID"] = value; }
        }

        /// <summary>
        /// [Type:ShortCode]	[LinkedTo:ShortCode]
        /// </summary>
        public string Section
        {
            get { return this["Section"].ToString(); }
            set { this["Section"] = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string SectionSysId
        {
            get { return this["SectionSysId"].ToString(); }
            set { this["SectionSysId"] = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string LocationSysId
        {
            get { return this["LocationSysId"].ToString(); }
            set { this["LocationSysId"] = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string TypeCodeSysId
        {
            get { return this["TypeCodeSysId"].ToString(); }
            set { this["TypeCodeSysId"] = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string DiagnosisSysId
        {
            get { return this["DiagnosisSysId"].ToString(); }
            set { this["DiagnosisSysId"] = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string MasterVersion
        {
            get { return this["MasterVersion"].ToString(); }
            set { this["MasterVersion"] = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string MasterDateTime
        {
            get { return this["MasterDateTime"].ToString(); }
            set { this["MasterDateTime"] = value; }
        }

        /// <summary>
        /// [Type:PPPU]	[LinkedTo:PPPU]
        /// </summary>
        public string AuthProvider
        {
            get { return this["AuthProvider"].ToString(); }
            set { this["AuthProvider"] = value; }
        }

        /// <summary>
        /// [Type:GUID]	[LinkedTo:GUID]
        /// </summary>
        public string PlaceOfServiceGUID
        {
            get { return this["PlaceOfServiceGUID"].ToString(); }
            set { this["PlaceOfServiceGUID"] = value; }
        }

        /// <summary>
        /// [Type:GUID]	[LinkedTo:GUID]
        /// </summary>
        public string TypeCodeGUID
        {
            get { return this["TypeCodeGUID"].ToString(); }
            set { this["TypeCodeGUID"] = value; }
        }

        /// <summary>
        /// [Type:GUID]	[LinkedTo:GUID]
        /// </summary>
        public string LocationGUID
        {
            get { return this["LocationGUID"].ToString(); }
            set { this["LocationGUID"] = value; }
        }

        /// <summary>
        /// [Type:GUID]	[LinkedTo:GUID]
        /// </summary>
        public string SectionGUID
        {
            get { return this["SectionGUID"].ToString(); }
            set { this["SectionGUID"] = value; }
        }

        /// <summary>
        /// [Type:GUID]	[LinkedTo:GUID]
        /// </summary>
        public string ProviderOfServiceGUID
        {
            get { return this["ProviderOfServiceGUID"].ToString(); }
            set { this["ProviderOfServiceGUID"] = value; }
        }

        /// <summary>
        /// [Type:GUID]	[LinkedTo:GUID]
        /// </summary>
        public string AuthProviderGUID
        {
            get { return this["AuthProviderGUID"].ToString(); }
            set { this["AuthProviderGUID"] = value; }
        }

        /// <summary>
        /// [Type:GUID]	[LinkedTo:GUID]
        /// </summary>
        public string CreatedByGUID
        {
            get { return this["CreatedByGUID"].ToString(); }
            set { this["CreatedByGUID"] = value; }
        }

        /// <summary>
        /// [Type:GUID]	[LinkedTo:GUID]
        /// </summary>
        public string ExternalProviderGUID
        {
            get { return this["ExternalProviderGUID"].ToString(); }
            set { this["ExternalProviderGUID"] = value; }
        }

        /// <summary>
        /// [Type:GUID]	[LinkedTo:GUID]
        /// </summary>
        public string DiagnosisGUID
        {
            get { return this["DiagnosisGUID"].ToString(); }
            set { this["DiagnosisGUID"] = value; }
        }

        /// <summary>
        /// [Type:GUID]	[LinkedTo:GUID]
        /// </summary>
        public string ServiceGUID
        {
            get { return this["ServiceGUID"].ToString(); }
            set { this["ServiceGUID"] = value; }
        }

        /// <summary>
        /// [Type:GUID]	[LinkedTo:GUID]
        /// </summary>
        public string ActivityGUID
        {
            get { return this["ActivityGUID"].ToString(); }
            set { this["ActivityGUID"] = value; }
        }


    }

}
