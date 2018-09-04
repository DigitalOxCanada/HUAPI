using HUAPICore.Interfaces;
using Microsoft.Extensions.Configuration;
using Profile7ClassLibrary.Entities;
using System;
using System.Globalization;
using System.Text;

namespace HUAPICore.Services.Jaffa
{
    /// <summary>
    /// Jaffa service class to perform jaffa creation
    /// </summary>
    public class JaffaService : IJaffaService
    {
        private readonly IProfileDAL _profileDAL;
        private readonly IConfiguration _config;

        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="profileDAL"></param>
        /// <param name="config"></param>
        public JaffaService(IConfiguration config, IProfileDAL profileDAL)
        {
            _config = config;
            _profileDAL = profileDAL;
        }

        /// <summary>
        /// Create an encounter from appointment
        /// </summary>
        /// <param name="aptid"></param>
        public void CreateEncounterFromAppointmentID(long aptid)
        {
            StringBuilder sb = new StringBuilder();
            Appointment apt = _profileDAL.GetAppointment(aptid);
            if (apt != null)
            {
                //create the jaffa content
                JaffaSpecCNCT cnct = new JaffaSpecCNCT();
                cnct.SourcePatID = apt.Ptnt.PtntPatientcode;
                cnct.OriginalContactID = "0";   //0 index ??? 
                cnct.DateOfContact = DateToProfileDate(DateTime.Now);
                cnct.PlaceOfService = "POS"; //Convert.ToString(apt.PppuIdPos);
                cnct.ProviderOfService = "ADMIN"; //Convert.ToString(apt.PppuIdPos);
                cnct.TypeCode = "CONSULT";  //TODO change to unique code
                cnct.Note = "note here";
                cnct.Title = "title here";
                cnct.DtCreated = DateToProfileDate(DateTime.Now);
                cnct.CreatedBy = "ADMIN";   //admin
                cnct.NoteToText = "note to text";
                if (apt.ApntCase != null)
                {
                    cnct.CaseTitle = apt.ApntCase.CaseTitle;
                    cnct.CaseGUID = apt.ApntCase.ObjGuid;
                }
                //cnct.Section = "?";
                sb.AppendLine(cnct.ToJaffa());

                //save the jaffa file on the server import folder
                try
                {
                    System.IO.File.WriteAllText(System.IO.Path.Combine(_config["SystemConfig:ServerJaffaPath"], $"Apnt_{apt.ApntId}_{DateTime.Now.Ticks}.jfa"), sb.ToString());
                }
                catch (Exception ex)
                {

                }
            }

            //SPEC newcase = new SPEC("CASE");
            //newcase.Fields["TypeCode"] = table.profile_case_type;
            ////newcase.Fields["Title"] = string.Format("{0} Case", table.profile_case_type);

            //string prv_id = lastline.PRV_ID.Trim();
            //string user_id = lastline.user_id;
            //string newprv_id = CheckProvider(prv_id);
            //user_id = CheckUserID(user_id);

            //cnct.Fields["SourcePatID"] = lastline.PAT_ID.Trim();
            //cnct.Fields["OriginalContactID"] = lastline.contact_id.ToString();// cnctseqnum++.ToString();
            //cnct.Fields["DateOfContact"] = dateProfile;
            //cnct.Fields["PlaceOfService"] = "POS";     //which POS
            //cnct.Fields["ProviderOfService"] = newprv_id;
            //cnct.Fields["TypeCode"] = "CONSULT";   //type code?   default: CONSULT
            //cnct.Fields["Note"] = linesb.ToString();
            //cnct.Fields["Title"] = string.Format("Imported Encounter [{0}]", CAT_CD.Trim());
            //cnct.Fields["DtCreated"] = dateactionProfile;// dt.ToString("dd/MM/yyyy");
            //cnct.Fields["CaseTitle"] = newcase.Fields["Title"];
            //cnct.Fields["CreatedBy"] = user_id;
            //cnct.Fields["NoteToText"] = string.Format("Imported Encounter [{0}]", CAT_CD.Trim());
            //cnct.Fields["CaseGUID"] = newcase.Fields["GUID"];
            ////determine section
            //if (table.profile_section != null)
            //{
            //    cnct.Fields["Section"] = table.profile_section;
            //}
            //specs.Add(cnct);

        }


        public string UppercaseFirst(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            char[] a = s.ToCharArray();
            a[0] = char.ToUpper(a[0]);
            return new string(a);
        }

        public DateTime StringToDate(string var)
        {

            DateTime dt = DateTime.ParseExact(var, "yyyyMMdd", CultureInfo.InvariantCulture);
            return dt;
        }

        public string StringToProfileDateString(string var)
        {
            string s = DateTime.ParseExact(var, "yyyyMMdd", CultureInfo.InvariantCulture).ToString("dd/MM/yyyy");
            return s;
        }

        public string DateToProfileDate(DateTime var)
        {
            string s = var.ToString("dd/MM/yyyy");
            return s;
        }

    }
}
