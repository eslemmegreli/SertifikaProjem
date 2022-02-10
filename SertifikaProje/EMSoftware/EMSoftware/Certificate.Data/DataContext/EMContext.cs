using Certificate.Data;
using System.Data.Entity;

namespace Certificate.Data.DataContext
{
    public class EMContext : DbContext
    {
        public EMContext()
            : base("EMContext")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<EMContext>(null);
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<TblCertificate> TblCertificates { get; set; }
        
    }
}
