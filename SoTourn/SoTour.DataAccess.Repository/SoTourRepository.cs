using System.Linq;
using SoTour.Core.Contracts;

namespace SoTour.DataAccess.Repository
{
    public class SoTourRepository : IRepository
    {
        private SoTourDataAcces _context;

        public SoTourRepository()
        {
            _context = new SoTourDataAcces();
        }
        public IQueryable<T> All<T>() where T : class
        {
            return _context.Set<T>();
        }

        public void GetAllTeamsIncludedMatches<T>()
        {
            throw new System.NotImplementedException();
        }
    }
}