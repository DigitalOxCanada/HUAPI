using HUAPIClassLibrary;
using HUAPICore.Interfaces;
using Microsoft.Extensions.Options;
using System.Linq;


namespace HUAPICore.Services
{
    /// <summary>
    /// Forwarding Links
    /// </summary>
    public class FWLinkService : IFWLinkService
    {
        private IOptions<CustomConfig> _customConfig;
        private HUAPIDBContext _context;

        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="cfg"></param>
        /// <param name="ctx"></param>
        public FWLinkService(IOptions<CustomConfig> cfg, HUAPIDBContext ctx)
        {
            _customConfig = cfg;
            _context = ctx;
        }

        /// <summary>
        /// Get a link by its id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public FWLink FindById(long id)
        {
            var link = (from p in _context.FWLink where p.Id == id select p).SingleOrDefault();
            return link;
        }

        /// <summary>
        /// Get a link by its url
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public FWLink FindByUrl(string url)
        {
            var link = (from p in _context.FWLink where p.Url == url select p).FirstOrDefault();
            return link;
        }

        /// <summary>
        /// Add a new link
        /// </summary>
        /// <param name="item"></param>
        public void Insert(FWLink item)
        {
            _context.Add(item);
            _context.SaveChanges();
        }

        /// <summary>
        /// Update a link
        /// </summary>
        /// <param name="item"></param>
        public void Update(FWLink item)
        {
            //TODO update an existing link
        }

        /// <summary>
        /// Delete a link
        /// </summary>
        /// <param name="id"></param>
        public void Delete(long id)
        {
            //TODO delete an existing link, *should we even have this?
        }

    }
}