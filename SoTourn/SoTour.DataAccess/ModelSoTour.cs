using System.Collections.Generic;
using SoTour.Core;

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

        public virtual DbSet<Author> Author { get; set; }
        public virtual DbSet<Club> Club { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<Player> Player { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Club>()
                .HasMany(e => e.Player)
                .WithRequired(e => e.Club)
                .HasForeignKey(e => e.IdClub)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<News>()
                .Property(e => e.Story)
                .IsUnicode(false);
        }

        public IEnumerable<News> GetNews()
        {
            //return News.Include(n=>n.Author.Name);
            return News;
        }

        public IEnumerable<Player> GetPlayer()
        {
            return Player;
        }


    }
}
