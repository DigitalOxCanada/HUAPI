using HUAPIClassLibrary;
using HUAPICore.Data;
using HUAPICore.Interfaces;
using HUAPICore.Models;
using Microsoft.Extensions.Options;
using System.Linq;


namespace HUAPICore.Services
{
    /// <summary>
    /// 
    /// </summary>
    public class FWLinkService : IFWLinkService
    {
        private IOptions<CustomConfig> _customConfig;
        private HUAPIDBContext _context;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cfg"></param>
        public FWLinkService(IOptions<CustomConfig> cfg, HUAPIDBContext ctx)
        {
            _customConfig = cfg;
            _context = ctx;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public FWLink FindById(long id)
        {
            var link = (from p in _context.FWLink where p.Id == id select p).SingleOrDefault();
            return link;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public FWLink FindByUrl(string url)
        {
            var link = (from p in _context.FWLink where p.Url == url select p).FirstOrDefault();
            return link;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        public void Insert(FWLink item)
        {
            _context.Add(item);
            _context.SaveChanges();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        public void Update(FWLink item)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        public void Delete(long id)
        {

        }

    }
}