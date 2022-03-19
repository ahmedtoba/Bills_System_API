using Microsoft.EntityFrameworkCore;

namespace Bills_System_API.Models
{
    public class BillsContext: DbContext
    {
        public virtual DbSet<Company> Companys { get; set; }
        public virtual DbSet<Species> Types { get; set; }
        public virtual DbSet<CompanyType> CompanyTypes  { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<Unit> Units { get; set; }
        public virtual DbSet<Invoice> Invoices { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<TotalBill> TotalBills { get; set; }

        public BillsContext(DbContextOptions<BillsContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CompanyType>()
                    .HasIndex(c => new {c.CompanyId, c.TypeId}).IsUnique();
            
        }


    }
}
