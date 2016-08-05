using System.Collections.Generic;
using SoTour.Core.Models;

namespace SoTour.Core.Contracts
{
    public interface INewsRepository
    {
        IEnumerable<NewsWithAuthorsViewModel> GetNews();
    }
}