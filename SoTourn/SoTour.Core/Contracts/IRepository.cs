using System.Linq;

namespace SoTour.Core.Contracts
{
    public interface IRepository
    {
        IQueryable<T> All<T>() where T : class;
        IQueryable<T> GetAllTeamsIncludedMatches<T>();
    }
}