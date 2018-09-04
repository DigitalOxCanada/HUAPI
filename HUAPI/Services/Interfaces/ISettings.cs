using HUAPIClassLibrary;
using HUAPICore.Models;
using System;
using System.Collections.Generic;

namespace HUAPICore.Interfaces
{
    /// <summary>
    /// Settings interface
    /// </summary>
    public interface ISettings : IDisposable
    {
        /// read
        void ReadSettings();
        /// write
        void SaveSettings();

        /// internal settings dictionary
        Dictionary<string, string> Settings { get; set; }

        /// <summary>
        /// Updates the setting in memory and writes it back to the database
        /// </summary>
        /// <param name="setting">kvp</param>
        /// <returns>success or failure boolean</returns>
        bool UpdateSetting(CustomSetting setting);
    }
}
