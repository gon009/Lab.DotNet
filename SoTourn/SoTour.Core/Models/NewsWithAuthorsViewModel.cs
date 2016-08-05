using System;

namespace SoTour.Core.Models
{
    public class NewsWithAuthorsViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Name { get; set; }
    }
}