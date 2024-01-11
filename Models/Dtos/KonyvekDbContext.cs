using Microsoft.EntityFrameworkCore;

namespace AdatbazisAPI.Models.Dtos
{
    public class KonyvekDbContext : DbContext
    {
        public KonyvekDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Konyv> konyvek { get; set; } = null!;
        public DbSet<Nemzetiseg> nemzetiseg { get; set; } = null!;
        public DbSet<Szerzo> szerzok { get; set; } = null!;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                string conn = "server=localhost; database=Blog; user=root; password=rootpwd";

                optionsBuilder.UseMySql(conn, ServerVersion.AutoDetect(conn));
            }
        }


    }
}
