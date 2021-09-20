using AdmissionAPI.v1._0.Models;
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

        public DbSet<Question> Question { get; set; }
        public DbSet<Answer> Answer { get; set; }

        public DbSet<MajorStatus> MajorStatus { get; set; }
        public DbSet<MajorStatus> Major { get; set; }

        public DbSet<CounStatus> CounStatus { get; set; }
        public DbSet<Counselor> Counselor { get; set; }
        public DbSet<CounPhone> CounPhone { get; set; }

        public DbSet<StudentStatus> StudentStatus { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<StudentPhone> StudentPhone { get; set; }
        public DbSet<Wallet> Wallet { get; set; }

        public DbSet<TalkshowStatus> TalkshowStatus { get; set; }
        public DbSet<Talkshow> Talkshow { get; set; }

        public DbSet<UniMajor> UniMajor { get; set; }
        public DbSet<CounUniMajor> CounUniMajor { get; set; }
        public DbSet<TalkshowUniMajor> TalkshowUniMajor { get; set; }
        public DbSet<Slot> Slot { get; set; }

    }
}
