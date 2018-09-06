using HUAPIClassLibrary;
using HUAPICore.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;

namespace HUAPICore.Services
{
    ///helper names for returning error codes
    public class LoggingEvents
    {
        /// getting a list of objects
        public const int ListItems = 1001;
        /// getting a single object
        public const int GetItem = 1002;
        /// creating a single object
        public const int InsertItem = 1003;
        /// putting a single object
        public const int UpdateItem = 1004;
        /// removing a single object
        public const int DeleteItem = 1005;

        /// getting a single object that wasn't found
        public const int GetItemNotFound = 4000;
        /// putting a single object that wasn't found
        public const int UpdateItemNotFound = 4001;
    }

    /// <summary>
    /// Service for database driven services
    /// </summary>
    public class SettingsService : ISettings
    {
        /// dictionary kvp of the settings.
        //public Dictionary<string, string> _settings { get; set; }
        private IConfiguration Configuration { get; }
        private readonly HUAPIDBContext _huapidbcontext;

        /// ARSSettings dictionary of kvp
        public Dictionary<string, string> Settings { get; set; }

        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="config"></param>
        public SettingsService(IConfiguration config)
        {
            Configuration = config;

            var options = new DbContextOptionsBuilder<HUAPIDBContext>();
            options.UseSqlServer(Configuration.GetConnectionString("HUAPIDB"));
            _huapidbcontext = new HUAPIDBContext(options.Options);
        }

        /// <summary>
        /// read settings from database and store as dictionary kvp
        /// </summary>
        public void ReadSettings()
        {
            Settings = (from p in _huapidbcontext.HUAPISettings select new { p.Name, p.Value }).AsEnumerable().ToDictionary(kvp => kvp.Name, kvp => kvp.Value);
        }

        /// <summary>
        /// write the settings back to the database
        /// </summary>
        /// <returns></returns>
        public void SaveSettings()
        {
            _huapidbcontext.Update(Settings);
            _huapidbcontext.SaveChanges();
        }

        /// <summary>
        /// Make changes to a custom setting.
        /// </summary>
        /// <param name="setting"></param>
        /// <returns></returns>
        public bool UpdateSetting(CustomSetting setting)
        {
            var dbSetting = (from p in _huapidbcontext.HUAPISettings where p.Name == setting.Name select p).SingleOrDefault();

            if (dbSetting == null)
            {
                return false;
            }

            dbSetting.Value = setting.Value;    //update the single record read from the database and write it back
            _huapidbcontext.HUAPISettings.Update(dbSetting);
            _huapidbcontext.SaveChanges();

            Settings[setting.Name] = setting.Value;  //update value in memory instead of reading from database again (dangerous??)

            return true;
        }


        /// <summary>
        /// dispose must exist to be interface compliant
        /// </summary>
        public void Dispose()
        {

        }
    }
}
