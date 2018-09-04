using HUAPIClassLibrary;

namespace HUAPICore.Interfaces
{
    /// <summary>
    /// 
    /// </summary>
    public interface IFWLinkService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        FWLink FindById(long id);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        FWLink FindByUrl(string url);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        void Insert(FWLink item);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        void Update(FWLink item);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        void Delete(long id);
    }
}
