using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using SoTour.Core.Contracts;
using SoTour.Core.Models;

namespace SoTour.DataAccess
{
    public class NewsRepository : Repository<News>, INewsRepository
    {
        public NewsRepository(DbContext dataContext) : base(dataContext)
        {
        }

        public IEnumerable<NewsWithAuthorsViewModel> GetNews()
        {
            var datasource = new SoTourEntities();
            return (from news in datasource.GetNews()
                    select new NewsWithAuthorsViewModel
                    {
                        Id = news.Id,
                        Title = news.Title,
                        Date = news.Date,
                        Name = news.Name
                    }).ToList();
            //IEnumerable<NewsWithAuthorsViewModel> data = newsRepository.GetAll();
        }
    }
}