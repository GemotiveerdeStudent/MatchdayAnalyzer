using MatchdayAnalyzer.Models.ClassModels;
using Microsoft.EntityFrameworkCore;

namespace MatchdayAnalyzer.Data
{
    public class MatchdayAnalyzerContext : DbContext
    {
        public DbSet<Attendance> Attendances { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Goal> Goals { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Season> Seasons { get; set; }
        public DbSet<Team> Teams { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
  /*        string connection = @"Data Source=.;Initial Catalog=MatchdayAnalyzer;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            optionsBuilder.UseSqlServer(connection); */
        }

        public MatchdayAnalyzerContext(DbContextOptions<MatchdayAnalyzerContext> contextOptions) : base(contextOptions)
        {

        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Specificerr
            modelBuilder.Entity<Attendance>();

            modelBuilder.Entity<Game>()
                .Property(x => x.DateTime);

            modelBuilder.Entity<Goal>()
                .Property(x => x.Id);

            modelBuilder.Entity<Player>()
                .Property(x => x.Id);

            modelBuilder.Entity<Season>()
                .Property(x => x.Id);

            modelBuilder.Entity<Team>()
                .Property(x => x.Id);

        }
    }
}

