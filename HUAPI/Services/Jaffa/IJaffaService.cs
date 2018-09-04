
namespace HUAPICore.Services.Jaffa
{
    /// <summary>
    /// 
    /// </summary>
    public interface IJaffaService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="aptid"></param>
        void CreateEncounterFromAppointmentID(long aptid);
    }
}