using HUAPIClassLibrary;
using HUAPICore.Data;
using HUAPICore.Interfaces;
using HUAPICore.Models;
using Hangfire;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Profile7ClassLibrary;
using Profile7ClassLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HUAPICore.Services
{
    /// <summary>
    /// EMR Data layer based on accessing Profile SQL database.
    /// </summary>
    public class SQLProfileDAL : IProfileDAL
    {
        private readonly ILogger<SQLProfileDAL> _logger;
        private readonly IOptions<CustomConfig> _cfg;
        private readonly HUAPIDBContext _huapidbcontext;
        private readonly ProfileDBContext _profiledbcontext;
        private readonly ProfileStageDBDataContext _profilestagedbcontext;
        private string sourceDBName;
        private string stageDBName;

        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="profilecontext"></param>
        /// <param name="huapidbcontext"></param>
        /// <param name="stagecontext"></param>
        /// <param name="cfg"></param>
        /// <param name="logger"></param>
        public SQLProfileDAL(ProfileDBContext profilecontext, HUAPIDBContext huapidbcontext, ProfileStageDBDataContext stagecontext, IOptions<CustomConfig> cfg, ILogger<SQLProfileDAL> logger)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Restart();

            _logger = logger;
            _cfg = cfg;
            _huapidbcontext = huapidbcontext;
            _profiledbcontext = profilecontext;
            _profilestagedbcontext = stagecontext;
            sourceDBName = profilecontext.Database.GetDbConnection().Database;
            stageDBName = stagecontext.Database.GetDbConnection().Database;

            stopwatch.Stop();
            _logger.LogDebug($"profile db data context time required for the first query: {stopwatch.ElapsedMilliseconds / 1000} seconds.");
        }


        public void Dispose()
        {

        }


        /// <summary>
        /// Retrieve an appointment by its internal apnt id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Appointment GetAppointment(long id)
        {
            //we include Patient and BCase objects in the query.
            //TODO add a simple flag to return just Appointment object
            Appointment apt = _profiledbcontext.Appointment.Include(p => p.Ptnt).Include(p => p.ApntCase).Where(p => p.ApntId == id).AsNoTracking().SingleOrDefault();

            return apt;
        }

        /// <summary>
        /// Determine if a specified appointment exists.
        /// </summary>
        /// <param name="id">table key id field value</param>
        /// <returns>boolean</returns>
        public bool AppointmentExists(long id)
        {
            return _profiledbcontext.Appointment.AsNoTracking().Any(e => e.ApntId == id);
        }


        /// <summary>
        /// Get a count of appointments on a specific day
        /// </summary>
        /// <param name="dt">Date</param>
        /// <returns>int count</returns>
        public int GetNewAppointmentsCount(DateTime dt)
        {
            var cnt = _profiledbcontext.Appointment.Where(x => x.ApntCreatedOn.Value.Date == dt.Date).AsNoTracking().Count();

            return cnt;
        }

        /// <summary>
        /// Get a count of clients created on a specific day
        /// </summary>
        /// <param name="dt">Date</param>
        /// <returns>int count</returns>
        public int GetNewClientsCount(DateTime dt)
        {
            var cnt = _profiledbcontext.Patient.Where(x => x.PtntDeletedid == 0 && x.Created.Date == dt.Date).AsNoTracking().Count();

            return cnt;
        }

        /// <summary>
        /// Get a list of alerts (patient problems)
        /// </summary>
        /// <returns>List of Patient Problems</returns>
        public List<Patientproblem> GetAllAlerts(long ptntid = 0)
        {
            //if patient id is specified then we get alerts to only that patient
            if (ptntid != 0)
            {
                return _profiledbcontext.Patientproblem.Where(x => x.PaprTypeid == 7 && x.PaprDeletedid == 0 && x.PtntId == ptntid).AsNoTracking().ToList();
            }

            //get all alerts
            return _profiledbcontext.Patientproblem.Where(x => x.PaprTypeid == 7 && x.PaprDeletedid == 0).AsNoTracking().ToList();
        }



        /// <summary>
        /// Gets a list of ConcurrentUsersLog entries past a specified date.
        /// This is good for drawing a graph and showing trend over time.
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public List<ConcurrentUsersLog> GetConcurrentUsers(DateTime dt)
        {
            var users = _profiledbcontext.ConcurrentUsersLog.Where(x => x.CulDate.Date == dt.Date).OrderByDescending(s => s.Oid).ToList();

            return users;
            //string sqlquery = $@"SELECT [CUL_DATE],[CUL_NEXT_DATE],[CUL_USERS],[CUL_SESSIONS]  FROM [dbo].[CONCURRENT_USERS_LOG]
            //            where convert(date, CUL_DATE) = convert(date, '{dt.ToShortDateString()}') order by oid desc";
        }

        /// <summary>
        /// Gets the latest 1 entry from ConcurrentUsersLog table.
        /// This is so you can show the current user load.
        /// </summary>
        /// <returns></returns>
        public ConcurrentUsersLog GetConcurrentUsersLatest()
        {
            var user = _profiledbcontext.ConcurrentUsersLog.OrderByDescending(s => s.Oid).FirstOrDefault();

            return user;
            //string sqlquery = @"SELECT TOP 1 [CUL_DATE],[CUL_NEXT_DATE],[CUL_USERS],[CUL_SESSIONS]  FROM [dbo].[CONCURRENT_USERS_LOG] order by oid desc";
        }

        /// <summary>
        /// Searches the audit table for the specified user/provider by their id and returns the last entry.
        /// </summary>
        /// <param name="pppuid">internal pppu id of the user</param>
        /// <returns>Profile Audit object</returns>
        public object GetUserLoggedInInfo(long pppuid)
        {
            var info = _profiledbcontext.Audit.Where(x => x.AudtPppuId == pppuid).OrderByDescending(s => s.AudtId).Take(1);

            return info;
            //var sqlquery = $"SELECT TOP 1 * FROM AUDIT_ WHERE AUDT_PPPU_ID = ${pppuid} order by AUDT_ID desc";
        }

        /// <summary>
        /// Finds a user by their user code and returns the user object.
        /// </summary>
        /// <param name="usercode">string user code</param>
        /// <returns>Profile User(pppu) object</returns>
        public object GetUserByCode(string usercode)
        {
            var user = _profiledbcontext.Pppu.Where(x => x.PppuCode == usercode && x.PppuDeletedid == 0 && x.PartitionId == 3).SingleOrDefault();

            return user;
        }

        /// <summary>
        /// Performs an update to the user record changing their status to Enabled
        /// </summary>
        /// <param name="usercode">string user code</param>
        /// <returns># of records updated</returns>
        public int EnableUser(string usercode)
        {
            if (GetUserByCode(usercode) is Pppu user)
            {
                user.PppuStatus = 1;
                _profiledbcontext.Update(user);
                var ret = _profiledbcontext.SaveChanges();
                return ret;
            }

            return 0;
            //string sqlquery = $@"UPDATE [PPPU] SET PPPU_STATUS = 1 where pppu_code = '{usercode}' and pppu_deletedid = 0";
        }

        /// <summary>
        /// Performs an update to the user record changing their status to Disabled
        /// </summary>
        /// <param name="usercode">string user code</param>
        /// <returns># of records updated</returns>
        public int DisableUser(string usercode)
        {
            if (GetUserByCode(usercode) is Pppu user)
            {
                user.PppuStatus = 3;
                _profiledbcontext.Update(user);
                var ret = _profiledbcontext.SaveChanges();
                return ret;
            }

            return 0;
            //string sqlquery = $@"UPDATE [PPPU] SET PPPU_STATUS = 3 where pppu_code = '{usercode}' and pppu_deletedid = 0";
        }


        /// <summary>
        /// Find a user by their sid. Useful if entries are tied to AD by their SID
        /// </summary>
        /// <param name="sid"></param>
        /// <returns></returns>
        public object GetUserBySID(string sid)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get a user by their email address.  Some scenarios have the same email address associated which could cause problems.
        /// </summary>
        /// <param name="email">users email</param>
        /// <returns>Profile user(pppu) object</returns>
        public object GetUserByEmail(string email)
        {
            //in case there is apostrophes in the email
            email = email.Replace("'", "''");

            var user = _profiledbcontext.Pppu.Where(x => x.PppuEmail == email && x.PppuDeletedid == 0).SingleOrDefault();

            return user;
            //var sqlquery = $"SELECT top 1 * FROM PPPU WHERE PPPU_DELETEDID = 0 and PPPU_EMAIL = '{email}'";
        }



        /// <summary>
        /// Sets the Apnt_is_notified flag to true
        /// </summary>
        /// <param name="appointmentId"></param>
        public void AppointmentIsNotified(long appointmentId)
        {
            var apt = (from p in _profiledbcontext.Appointment where p.ApntId == appointmentId select p).SingleOrDefault();
            if (apt != null)
            {
                apt.ApntIsNotified = (short)1;
                _profiledbcontext.Appointment.Update(apt);
                _profiledbcontext.SaveChanges();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool TestUserGroupExists()
        {
            var it = _profiledbcontext.ProfilePatientGroup.Where(x => x.Name == "Test Clients");
            if (it == null)
            {
                return false;
            }

            return Convert.ToBoolean(it.Count());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string GetVersionInfo()
        {
            //            var it = _ptc.DatabaseInfo.ToList();

            //return it;
            return "unknown";
        }



        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<CustomFormDef> GetListOfAllForms()
        {
            //var forms = (from term in _profiledbcontext.CdoTermsetTerm
            //             join transdata in _profiledbcontext.CdoTransdata on term.Oid equals transdata.Term
            //             where transdata.Versionmax > 1000000 && transdata.Collection == null
            //             select new CustomFormDef() { Description = term.Description, Created = term.Created, Code = term.Code }).ToList<CustomFormDef>();

            var forms = _profiledbcontext.Set<CustomFormDef>().FromSql("dbo.huapiGetAllCustomForms").ToList<CustomFormDef>();

            return forms;
        }


        private int RecursiveCheckNameExists(List<FormTransData> AllCols, string desc, int cntr)
        {
            var nametocheck = desc;
            if (cntr > 0)
            {
                nametocheck = $"{desc}_{cntr}";
            }

            if (AllCols.Exists(p => p.DESCRIPTION == nametocheck))
            {
                return RecursiveCheckNameExists(AllCols, desc, ++cntr);
            }
            return cntr;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="formname"></param>
        public async Task<int> GenerateScrapeFormQueries(string formname)
        {
            //var form = from p in _profiledbcontext.CdoTermsetTerm
            //           join pm in _profiledbcontext.CdoTransdata on p.Oid equals pm.Term
            //           where pm.Versionmax > 1000000 && pm.Collection == null

            //           select new { OID = pm.Oid, TRANS = pm.Trans };

            //            string q = $@"          
            //                SELECT *
            //                FROM CDO_TRANSDATA
            //                WHERE (CDO_TRANSDATA.VERSIONMAX > 1000000) and CDO_TRANSDATA.COLLECTION is null
            //                and dbo.GetTextByTag(CDO_TRANSDATA.TEXTS, 'TI') = ''  and dbo.GETTEXTBYTAG(CDO_TRANSDATA.TEXTS, 'NM') = '{formname}'
            //            ";

            //            q = $@"
            //select cdt.COLLECTION, cdt.DT_MODIFIED, cdt.OID, ctt.DESCRIPTION, ctt.CODE  from CDO_TRANSDATA cdt inner join cdo_termset_term ctt on ctt.oid = cdt.term WHERE trans = (
            //SELECT      top 1 trans
            //FROM CDO_TRANSDATA 
            //WHERE       
            //(CDO_TRANSDATA.VERSIONMAX > 1000000) and CDO_TRANSDATA.COLLECTION is null
            //and dbo.GetTextByTag(cdo_transdata.TEXTS, 'TI') = '' and dbo.GETTEXTBYTAG(cdo_transdata.TEXTS, 'NM') = 'Client Summary Form' --'IMM Selection TEST FORM'
            //) and VERSIONMAX > 1000000
            //";

            //var forminfo = _profiledbcontext.CdoTransdata.FromSql(q).AsNoTracking().SingleOrDefault();

            //var forminfo = _profiledbcontext.Database.ExecuteSqlCommand("exec huapiGetFormTransData @formname", formname );


            // get list of HRIs that make up the form by name
            //_profiledbcontext.ChangeTracker.AutoDetectChangesEnabled = false;
            //_profiledbcontext.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;

            List<FormTransData> AllCols = new List<FormTransData>();

            using (var command = _profiledbcontext.Database.GetDbConnection().CreateCommand())
            {
                command.CommandText = "huapiGetFormTransData";
                var formnameParam = new SqlParameter("@FormName", SqlDbType.VarChar);
                formnameParam.Value = formname;
                command.Parameters.Add(formnameParam);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                _profiledbcontext.Database.OpenConnection();
                using (var result = command.ExecuteReader())
                {
                    while (result.Read())
                    {
                        FormTransData ftd = new FormTransData();
                        ftd.COLLECTION = 0;
                        if (!result.IsDBNull(result.GetOrdinal("COLLECTION")))
                        {
                            ftd.COLLECTION = result.GetInt64(result.GetOrdinal("COLLECTION"));
                        }
                        ftd.DESCRIPTION = result.GetString(result.GetOrdinal("DESCRIPTION"));
                        ftd.CID = result.GetInt64(result.GetOrdinal("CID"));
                        ftd.CODE = result.GetString(result.GetOrdinal("CODE"));
                        ftd.DT_MODIFIED = result.GetDateTime(result.GetOrdinal("DT_MODIFIED"));
                        ftd.OID = result.GetInt64(result.GetOrdinal("OID"));
                        ftd.CONCEPT = result.GetInt64(result.GetOrdinal("CONCEPT"));

                        var cntr = RecursiveCheckNameExists(AllCols, ftd.DESCRIPTION, 0);
                        if (cntr > 0)
                        {
                            ftd.DESCRIPTION = $"{ftd.DESCRIPTION}_{cntr}";
                        }

                        AllCols.Add(ftd);   //TODO change to kvp so we deal with duplicate field names
                    }
                }
            }

            //lets get the root of the HRI values which is the form collection itself.
            FormTransData roothri = (from p in AllCols where p.COLLECTION == 0 select p).SingleOrDefault();
            if (roothri == null)
            {
                throw new Exception("The root HRI collection couldn't be found. This shouldn't happen.");
            }

            //TODO cleans the roothri.DESCRIPTION in case it has symbols and such

            StringBuilder fields = new StringBuilder();
            StringBuilder scrapefields = new StringBuilder();
            scrapefields.Append($"INSERT INTO [{stageDBName}].[dbo].[{formname}] SELECT Patient_2.PTNT_PATIENTCODE PAT_ID, Patient_4.DTDISPLAY thedate");

            //go through rest of HRIs to build create and scrape queries for the HRI fields.
            foreach (var item in AllCols.Where(p => p.COLLECTION != 0))
            {
                //create the create table from this list.
                string desc = item.DESCRIPTION.Replace(' ', '_').Replace(',', '_').Replace('(', '_').Replace(')', '_');
                switch (item.CID)
                {
                    case 100511:    //text
                        fields.Append($",[{desc}] [varchar](255) NULL");
                        scrapefields.Append($",(select TOP 1 LEFT([{sourceDBName}].[dbo].GetTextByTag(td0.TEXTS, 'TX'),255) from [{sourceDBName}].[dbo].cdo_transdata td0 where td0.trans = TheForm_1.trans and td0.versionmax > 1000000 and td0.concept = {item.CONCEPT} ) [{desc}] ");
                        break;
                    case 100842:    //lookup
                        fields.Append($",[{desc}] [varchar](255) NULL");
                        scrapefields.Append($",(select TOP 1 [{sourceDBName}].[dbo].GetTextByTag(td0.TEXTS, 'TX') from [{sourceDBName}].[dbo].cdo_transdata td0 where td0.trans = TheForm_1.trans and td0.versionmax > 1000000 and  td0.concept = {item.CONCEPT} ) [{desc}] ");
                        break;
                    case 100512:    //memo
                        fields.Append($",[{desc}] [varchar](1024) NULL");
                        scrapefields.Append($",(select TOP 1 LEFT([{sourceDBName}].[dbo].GetTextByTag(td0.TEXTS, 'TX*'),255) from [{sourceDBName}].[dbo].cdo_transdata td0 where td0.trans = TheForm_1.trans and td0.versionmax > 1000000 and  td0.concept = {item.CONCEPT} ) [{desc}] ");
                        break;
                    case 100517:    //date
                        fields.Append($",[{desc}] [datetime] NULL");
                        scrapefields.Append($", (select TOP 1 td0.DT1 from [{sourceDBName}].[dbo].cdo_transdata td0 where td0.trans = TheForm_1.trans and td0.versionmax > 1000000 and  td0.concept = {item.CONCEPT}  ) [{desc}] ");
                        break;
                    default:
                        fields.Append($",[{desc}] [varchar](255) NULL");
                        scrapefields.Append($",(select TOP 1 [{sourceDBName}].[dbo].GetTextByTag(td0.TEXTS, 'TX') from [{sourceDBName}].[dbo].cdo_transdata td0 where td0.trans = TheForm_1.trans and td0.versionmax > 1000000 and  td0.concept = {item.CONCEPT} ) [{desc}] ");
                        break;
                }

            }

            //construct the create table query
            string createstr = $@"CREATE TABLE [dbo].[{formname}](
                [patid][varchar](50) NOT NULL,
                [dtmodified] [datetime] NOT NULL
                {fields.ToString()}
                ) ON[PRIMARY]";

            //construct the drop table query
            string dropstr = $@"DROP TABLE [dbo].[{formname}]";

            //construct the scrape table query
            scrapefields.Append($@"FROM [{sourceDBName}].[dbo].CDO_TRANS Form__Registered__3     inner join [{sourceDBName}].[dbo].CDO_TRANSDATA TheForm_1 on (Form__Registered__3.OID = TheForm_1.TRANS) left outer join [{sourceDBName}].[dbo].CDO_TRANS Patient_4 on (TheForm_1.TRANS=Patient_4.OID) and (Patient_4.Deleted > CAST('01-JAN-3000' AS datetime)) left outer join [{sourceDBName}].[dbo].CDO_EHCR EHCR__5 on (Patient_4.EHCR=EHCR__5.OID) left outer join [{sourceDBName}].[dbo].CDO_PERSON CDO_Person__6 on (EHCR__5.PATIENT=CDO_Person__6.OID) left outer join [{sourceDBName}].[dbo].PATIENT Patient_2 on (CDO_Person__6.REAL_ID=Patient_2.PTNT_ID) and (/*INT_IND_OFF*/ Patient_2.PTNT_DELETEDID < 1 )WHERE ( ( (Form__Registered__3.CID = 100400 or Form__Registered__3.CID = 100401) and Form__Registered__3.Deleted >= CAST('01-JAN-3000' AS datetime) AND Form__Registered__3.FILING_CATEGORY = 7)  and ( TheForm_1.VERSIONMAX > 1000000 and TheForm_1.CID = 100502 and TheForm_1.collection is null and TheForm_1.concept = {roothri.CONCEPT} AND not exists (select 1 from [{sourceDBName}].[dbo].CDO_TRANS TRANSREF1CHECK where TheForm_1.TRANS = TRANSREF1CHECK.OID and TRANSREF1CHECK.REF1 = 13) AND (EXISTS (SELECT 1 FROM [{sourceDBName}].[dbo].CDO_TRANS C_T  WHERE C_T.OID = TheForm_1.TRANS )))  and (CDO_Person__6.CID = 100105) )");

            ScrapeQuery sq = new ScrapeQuery("ScrapeQuery", formname, "General", DateTime.Now, false, dropstr, createstr, scrapefields.ToString(), 1000);

            _huapidbcontext.Add<ScrapeQuery>(sq);
            await _huapidbcontext.SaveChangesAsync();

            //now insert the SQ into the HUAPI database and then we can call an api to schedule the scraping to occur.

            //select CDO_TRANSDATA.*, CDO_TERMSET_TERM.*
            //from CDO_TRANSDATA inner join cdo_termset_term on cdo_transdata.term = cdo_termset_term.oid
            //where cdo_transdata.trans = @trans and cdo_transdata.versionmax > 1000000
            //order by ORD
            return 0;
        }

        [DisableConcurrentExecution(3600)]  //1hr
        public void ScrapeCustomForms(string formname)
        {
            //safety check
            if (string.IsNullOrEmpty(formname.Trim()))
            {
                return;
            }

            ////scraping_is_running = true;
            //if (!scraping_is_running)
            //{
            //    scraping_is_running = true;

            List<ScrapeQuery> queries = new List<ScrapeQuery>();

            if (formname.Equals("all"))
            {
                queries = (from p in _huapidbcontext.ScrapeQuery where p.IsActive == true orderby p.Order, p.FormName select p).ToList();
            }
            else
            {
                queries = (from p in _huapidbcontext.ScrapeQuery where p.IsActive == true && p.FormName == formname select p).ToList();
            }

            //foreach(var l in list)
            //{
            //    _logger.LogDebug(l.FormName);
            //}

            _logger.LogInformation($"Scraping custom forms [{queries.Count}]");

            //BackgroundWorker bw = new BackgroundWorker
            //{
            //    // this allows our worker to report progress during work
            //    WorkerReportsProgress = true
            //};

            //// what to do in the background thread
            //bw.DoWork += new DoWorkEventHandler(
            //        delegate (object o, DoWorkEventArgs args)
            //        {
            //            BackgroundWorker b = o as BackgroundWorker;

            //                        List<ScrapeQuery> list = args.Argument as List<ScrapeQuery>;
            List<ScrapeQuery> list = queries as List<ScrapeQuery>;
            int total = list.Count;
            int processed = 0;
            foreach (var item in list)
            {
                var sw = Stopwatch.StartNew();
                var started = DateTime.Now;

                _logger.LogDebug($"Scraping Profile Form {item.FormName}");

                using (SqlConnection connection = new SqlConnection(_profilestagedbcontext.Database.GetDbConnection().ConnectionString))
                {
                    SqlCommand DropCmd = new SqlCommand(item.DropQ, connection);
                    DropCmd.CommandTimeout = 300;  //5 minutes
                    SqlCommand CreateCmd = new SqlCommand(item.CreateQ, connection);
                    CreateCmd.CommandTimeout = 300;  //5 minutes
                    SqlCommand SelectCmd = new SqlCommand(item.SelectQ, connection);
                    SelectCmd.CommandTimeout = 3600;  //60 minutes

                    connection.Open();

                    try
                    {
                        _logger.LogDebug($"...executing Drop");
                        var retDrop = DropCmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        _logger.LogError($"SQL Error: {ex.Message}");
                    }

                    try
                    {
                        _logger.LogDebug($"...executing Create");
                        var retCreate = CreateCmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        _logger.LogError($"SQL Error: {ex.Message}");
                    }


                    try
                    {
                        _logger.LogDebug($"...executing Select");
                        var retSelect = SelectCmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        _logger.LogError($"SQL Error: {ex.Message}");
                    }

                    connection.Close();
                }
                //}
                processed++;
                //                            b.ReportProgress((int)(((float)100 / (float)total) * processed));    //get total in percentage per item * how many processed = the % processed
                sw.Stop();
                //                            Task t = new Task(() => AllControllers.Metric_TrackDuration($"Scrape {item.FormName}", started, sw.Elapsed, customConfig));
                //                            t.Start();
            }
            // do some simple processing for 10 seconds
            //for (int i = 1; i <= 10; i++)
            //{
            //    // report the progress in percent
            //    b.ReportProgress(i * 10);
            //    Thread.Sleep(1000);
            //}

            //                    });

            //                // what to do when progress changed (update the progress bar for example)
            //                bw.ProgressChanged += new ProgressChangedEventHandler(
            //                    delegate (object o, ProgressChangedEventArgs args)
            //                    {
            //                        _logger.LogInformation($"Scraping Profile @ {args.ProgressPercentage}%");
            //                    });

            //                // what to do when worker completes its task (notify the user)
            //                bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(
            //                    delegate (object o, RunWorkerCompletedEventArgs args)
            //                    {
            //                        _logger.LogInformation("Scraping Profile custom forms completed.");
            ////                        scraping_is_running = false;
            //                    });

            //                bw.RunWorkerAsync(queries);

            //    Hashtable ht = new Hashtable();
            //    ht.Add("Action", "Processing Forms");
            //    ht.Add("Forms", from q in queries select q.FormName);

            //    return Ok(JsonConvert.SerializeObject(ht, Formatting.Indented));
            //}
            //else
            //{
            //    return Ok("{\"Action\":\"Non Taken\", \"Reason\":\"Scraping already in progress\"}");
            //}

            //return Ok();


        }


        //public object GetFormsToScrape()
        //{
        //    MongoClient mc = new MongoClient(mongoServerAddress);
        //    IMongoDatabase db = mc.GetDatabase(_customConfig.Value.HUAPI.database);
        //    var collection = db.GetCollection<ProfileScrapeQuery>("ProfileStage");

        //    var queries = collection.Find("{}").Sort("{ \"Order\": 1 }").Project<ProfileScrapeQuery>(Builders<ProfileScrapeQuery>.Projection.Exclude(p => p.SQL).Exclude(p => p.DELTASQL)).ToList();

        //    return queries;
        //}

        //public object ProfileScrapeForm(string formName)
        //{
        //    //isScraping == true;
        //    if (!IsScraping)
        //    {
        //        IsScraping = true;

        //        //TODO get table(s) queries to execute
        //        MongoClient mc = new MongoClient(mongoServerAddress);
        //        IMongoDatabase db = mc.GetDatabase(_customConfig.Value.HUAPI.database);
        //        var collection = db.GetCollection<ProfileScrapeQuery>("ProfileStage");
        //        //string specific = $", {{\"FormName\": /.*{FormName}.*/i }}";
        //        string specific = $", {{\"FormName\": \"{formName}\" }}";
        //        //    $"{{ Members: /.*{username}.*/i }}"

        //        if (formName.ToLower().Equals("all"))
        //        {
        //            specific = "";
        //        }

        //        List<ProfileScrapeQuery> queries = collection.Find("{ $and: [{\"DocType\": \"ScrapeQuery\"}, {\"Active\" : true }" + specific + " ]  }").Sort("{ \"Order\": 1 }").ToList(); //.Project("{\"Demographics\": 1}").ToList();

        //        //_logger.LogInformation($"Scraping Forms [{queries.Count}]");


        //        BackgroundWorker bw = new BackgroundWorker();

        //        // this allows our worker to report progress during work
        //        bw.WorkerReportsProgress = true;

        //        // what to do in the background thread
        //        bw.DoWork += new DoWorkEventHandler(
        //            delegate (object o, DoWorkEventArgs args)
        //            {
        //                BackgroundWorker b = o as BackgroundWorker;
        //                List<ProfileScrapeQuery> list = args.Argument as List<ProfileScrapeQuery>;
        //                int total = list.Count;
        //                int processed = 0;
        //                foreach (var item in list)
        //                {
        //                    var sw = _sysRepo.MetricTracker();
        //                    //var sw = Stopwatch.StartNew();
        //                    //var started = DateTime.Now;

        //                    //_logger.LogDebug($"Scraping Profile Form {item.FormName}");
        //                    foreach (var sql in item.SQL)
        //                    {
        //                        //perform sql execution and wait for it to finish
        //                        //update progress
        //                        //move on

        //                        using (SqlConnection connection = new SqlConnection(ProfileProductionConnectionString))
        //                        {
        //                            SqlCommand command = new SqlCommand(sql.sql, connection);
        //                            command.CommandTimeout = 1800;  //30 minutes
        //                            connection.Open();
        //                            //_logger.LogDebug($"...executing {sql.action}");
        //                            try
        //                            {
        //                                var ret = command.ExecuteNonQuery();
        //                                Thread.Sleep(250);  //just delay to let things settle down on network
        //                            }
        //                            catch (Exception ex)
        //                            {
        //                                //_logger.LogError($"SQL Error: {ex.Message}");
        //                            }
        //                            connection.Close();
        //                        }
        //                    }
        //                    processed++;
        //                    b.ReportProgress((int)(((float)100 / (float)total) * processed));    //get total in percentage per item * how many processed = the % processed
        //                    _sysRepo.MetricTracker($"Scrape {item.FormName}", sw);

        //                    //sw.Stop();
        //                    //Task t = new Task(() => _sysRepo.Metric_TrackDuration($"Scrape {item.FormName}", started, sw.Elapsed));
        //                    //t.Start();
        //                    Thread.Sleep(100);  //this way the process changed message appears before looping to next item and it's message showing up ahead.
        //                }
        //                // do some simple processing for 10 seconds
        //                //for (int i = 1; i <= 10; i++)
        //                //{
        //                //    // report the progress in percent
        //                //    b.ReportProgress(i * 10);
        //                //    Thread.Sleep(1000);
        //                //}

        //            });

        //        // what to do when progress changed (update the progress bar for example)
        //        bw.ProgressChanged += new ProgressChangedEventHandler(
        //            delegate (object o, ProgressChangedEventArgs args)
        //            {
        //                //_logger.LogInformation($"Scraping Profile @ {args.ProgressPercentage}%");
        //            });

        //        // what to do when worker completes its task (notify the user)
        //        bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(
        //            delegate (object o, RunWorkerCompletedEventArgs args)
        //            {
        //                //_logger.LogInformation("Scraping Profile completed.");
        //                IsScraping = false;
        //            });

        //        bw.RunWorkerAsync(queries);

        //        Hashtable ht = new Hashtable();
        //        ht.Add("Action", "Processing Forms");
        //        ht.Add("Forms", from q in queries select q.FormName);

        //        return ht;
        //    }
        //    else
        //    {
        //        return new { Action = "Non Taken", Reason = "Scraping already in progress" };
        //    }
        //}

        //public List<Pppu> GetEmployeesOfManager(string mgrname)
        //{
            
        //    //List<Pppu> list = _profiledbcontext.Pppu

        //    return list;
        //}

        
        public List<Appointmentaudit> GetAppointmentAudits()
        {
            return _profiledbcontext.Appointmentaudit.AsNoTracking().ToList();
        }

        public List<Audit> GetAudits()
        {
            return _profiledbcontext.Audit.AsNoTracking().ToList();
        }

        public List<CaseAudit> GetCaseAudits()
        {
            return _profiledbcontext.CaseAudit.AsNoTracking().ToList();
        }

        public List<CaseAuditDetails> GetCaseAuditDetails()
        {
            return _profiledbcontext.CaseAuditDetails.AsNoTracking().ToList();
        }

        public List<PatientAudit> GetPatientAudits()
        {
            return _profiledbcontext.PatientAudit.AsNoTracking().ToList();
        }


        private string BuildPattern()
        {
            var pattern = "^" +                                                       // beginning of string
                            "(?<HouseNumber>\\d+)" +                                  // 1 or more digits
                            "(?:\\s+(?<StreetPrefix>" + GetStreetPrefixes() + "))?" + // whitespace + valid prefix (optional)
                            "(?:\\s+(?<StreetName>.*?))" +                            // whitespace + anything
                            "(?:" +                                                   // group (optional) {
                            "(?:\\s+(?<StreetType>" + GetStreetTypes() + "))?" +       //   whitespace + valid street type
                            "(?:\\s+(?<StreetSuffix>" + GetStreetSuffixes() + "))?" +  //   whitespace + valid street suffix (optional)
                            "(?:\\s+(?<Apt>(" + GetAptTypes() + ")\\s(\\w{1,3}|\\d{1,3})))?" +
                            "(?:\\s+(?<POBox>(PO BOX\\s\\d{1,6})))?" +
                            "(?:\\s+(?<RR>(RR\\s\\d{1,3})))?" +
                            ")?" +                                                    // }
                            "$";                                                      // end of string

            return pattern;
        }

        private string GetStreetPrefixes()
        {
            return "TE|NW|HW|RD|E|MA|EI|NO|AU|SE|GR|OL|W|MM|OM|SW|ME|HA|JO|OV|S|OH|NE|K|N";
        }

        private string GetStreetTypes()
        {
            return StreetCodesList;
            //return "TE|STCT|DR|SPSGS|PARK|GRV|CRK|XING|BR|PINE|CTS|TRL|VI|RD|PIKE|MA|LO|TER|UN|CIR|WALK|CO|RUN|FRD|LDG|ML|AVE|NO|PA|SQ|BLVD|VLGS|VLY|GR|LN|HOUSE|VLG|OL|STA|CH|ROW|EXT|JC|BLDG|FLD|CT|HTS|MOTEL|PKWY|COOP|ACRES|ESTS|SCH|HL|CORD|ST|CLB|FLDS|PT|STPL|MDWS|APTS|ME|LOOP|SMT|RDG|UNIV|PLZ|MDW|EXPY|WALL|TR|FLS|HBR|TRFY|BCH|CRST|CI|PKY|OV|RNCH|CV|DIV|WA|S|WAY|I|CTR|VIS|PL|ANX|BL|ST TER|DM|STHY|RR|MNR";
        }

        private  string GetStreetSuffixes()
        {
            return "NW|E|SE|W|SW|S|NE|N";
        }

        private  string GetAptTypes()
        {
            return "APT|UNIT|SUITE";
        }

        private string StreetCodesList;

        public bool IsDemographicsValid(long ptntid)
        {
            var streettypes = _huapidbcontext.StreetTypes.ToList();
            if(streettypes.Count<1)
            {
                throw new Exception("Street Types are missing.");
            }

            //make | delimeted string used for RegEx matching
            StreetCodesList = string.Join("|", (from p in streettypes select p.Code).ToArray());
            var pat = _profiledbcontext.Patient.Where(p => p.PtntId == ptntid && p.PtntDeletedid == 0 && p.PartitionId == 3).SingleOrDefault();
            if(pat == null)
            {
                throw new Exception($"Patient {ptntid} couldn't be found.");
            }

            if (string.IsNullOrEmpty(pat.PtntStreet1)) return false;
            if (string.IsNullOrWhiteSpace(pat.PtntStreet1.Trim())) return false;

            var result = ParseAddress(pat.PtntStreet1.Trim());
            if (result == null) return false;
            if (string.IsNullOrEmpty(result.HouseNumber) || string.IsNullOrEmpty(result.StreetType) || string.IsNullOrEmpty(result.HouseNumber))
            {
                return false;
            }
            if(!string.IsNullOrEmpty(result.StreetName))
            {
                return true;
            }
            return false;
        }

        public StreetAddress ParseAddress(string address)
        {
            if (string.IsNullOrEmpty(address))
                return null;

            StreetAddress result;
            var input = address.ToUpper();

            var re = new Regex(BuildPattern());
            if (re.IsMatch(input))
            {
                var m = re.Match(input);
                result = new StreetAddress
                {
                    HouseNumber = m.Groups["HouseNumber"].Value,
                    StreetPrefix = m.Groups["StreetPrefix"].Value,
                    StreetName = m.Groups["StreetName"].Value,
                    StreetType = m.Groups["StreetType"].Value,
                    StreetSuffix = m.Groups["StreetSuffix"].Value,
                    Apt = m.Groups["Apt"].Value,
                    POBox = m.Groups["POBox"].Value,
                    RR = m.Groups["RR"].Value,
                };
            }
            else
            {
                result = new StreetAddress
                {
                    StreetName = input,
                };
            }
            return result;
        }
    }
}
