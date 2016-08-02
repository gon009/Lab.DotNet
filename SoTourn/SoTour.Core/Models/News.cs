using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SoTour.Core.Models
{
    public partial class News
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        [Column(TypeName = "text")]
        public string Story { get; set; }

        public DateTime Date { get; set; }

        [StringLength(50)]
        public string Author { get; set; }
    }
}
