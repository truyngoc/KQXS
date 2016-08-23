using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace TestString
{
    public class XSMBContext : DbContext
    {
        public XSMBContext()
            : base("XSMBContext")
        { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }

        public DbSet<KetQuaMB> KetQuaMB { get; set; }

        public DbSet<KetQuaMB_Flat> KetQuaMB_Flat { get; set; }
    }
}
