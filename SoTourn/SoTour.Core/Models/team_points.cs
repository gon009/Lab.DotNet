using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SoTour.Core.Models
{
    public partial class team_points
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string name { get; set; }

        public int? GPlayed { get; set; }

        public int? GWin { get; set; }

        public int? GLoss { get; set; }

        public int? GDefe { get; set; }

        public int? GFavor { get; set; }

        public int? GAga { get; set; }

        public int? GDiff { get; set; }

        [StringLength(10)]
        public string Points { get; set; }
    }
}
