using Microsoft.EntityFrameworkCore;
using Traversal.EntityLayer.Concrete;

namespace Traversal.DataAccesLayer.Concrete
{
    public class TraversalDBContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server = 127.0.0.1; database=TraversalDB;integrated security=true; TrustServerCertificate=True");
        }

        public DbSet<About> Abouts { get; set; }
        public DbSet<About2> Abouts2 { get; set; }
        public DbSet<Contect> Contects { get; set; }
        public DbSet<Destination> Destinations { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Guide> Guides { get; set; }
        public DbSet<Newsletter> Newsletters { get; set; }
        public DbSet<SubAbout> SubAbouts { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }


    }
}
