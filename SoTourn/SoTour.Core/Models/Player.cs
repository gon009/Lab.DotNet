using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SoTour.Core
{
    [Table("Player")]
    public partial class Player
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100), DisplayName("Name")]
        public string Name { get; set; }

        public int Age { get; set; }

        [Required]
        [StringLength(50)]
        public string Nationality { get; set; }

        [Required]
        [StringLength(50)]
        public string Position { get; set; }

        public int IdClub { get; set; }

        public virtual Club Club { get; set; }
    }
}
