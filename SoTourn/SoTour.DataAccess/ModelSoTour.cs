using SoTour.Core.Models;

namespace SoTour.DataAccess
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModelSoTour : DbContext
    {
        public ModelSoTour()
            : base("name=ModelSoTour")
        {
        }

        public virtual DbSet<News> News { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<News>()
                .Property(e => e.Story)
                .IsUnicode(false);
        }
    }
}
