using Profile7ClassLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HUAPICore.Interfaces
{
    /// <summary>
    /// Profile DAL interface
    /// </summary>
    public interface IProfileDAL : IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Appointment GetAppointment(long id);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool AppointmentExists(long id);

        List<ConcurrentUsersLog> GetConcurrentUsers(DateTime dt);
        ConcurrentUsersLog GetConcurrentUsersLatest();
        object GetUserLoggedInInfo(long pppuid);
        object GetUserByCode(string usercode);
        object GetUserByEmail(string email);
        int DisableUser(string usercode);
        int EnableUser(string usercode);
        int GetNewClientsCount(DateTime dt);
        int GetNewAppointmentsCount(DateTime dt);
        void AppointmentIsNotified(long appointmentId);
        List<CustomFormDef> GetListOfAllForms();
        Task<int> GenerateScrapeFormQueries(string formname);
        void ScrapeCustomForms(string formname);
        List<Patientproblem> GetAllAlerts(long ptntid = 0);
        bool IsDemographicsValid(long ptntid);
    }
}
