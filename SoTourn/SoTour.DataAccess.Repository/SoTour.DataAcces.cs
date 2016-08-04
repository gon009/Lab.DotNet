using SoTour.Core.Models;

namespace SoTour.DataAccess.Repository
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class SoTourDataAcces : DbContext
    {
        public SoTourDataAcces()
            : base("name=RepoModel2")
        {
        }

        public virtual DbSet<team_points> team_points { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<team_points>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<team_points>()
                .Property(e => e.Points)
                .IsFixedLength();
        }
    }
}
