using Microsoft.EntityFrameworkCore;

namespace AdmissionAPI.Models
{
    public class AdmissionContext : DbContext
    {
        public AdmissionContext(DbContextOptions<AdmissionContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"Data Source=ANHNPP\ANHNPP;Initial Catalog=AdmissionDB;Integrated Security=True");
        //}

        public DbSet<UniStatus> UniStatus { get; set; }
        public DbSet<University> University { get; set; }
        public DbSet<UniAddress> UniAddress { get; set; }

    }
}
