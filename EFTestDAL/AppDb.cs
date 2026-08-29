using Microsoft.EntityFrameworkCore;

namespace EFTestDAL;

public class AppDb : DbContext
{
    public DbSet<Entity.Customer> Customers { get; set; }
    public DbSet<Entity.Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(General.Info.DatabaseConnectionString);
        //
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //
        // ----------- Customer Table
        //
        modelBuilder.Entity<Entity.Customer>(entity =>
        {
            entity.ToTable("Customer")
                    .HasKey(x => x.CustId).HasName("PK_Customer");
            entity.Property(e => e.CustId)
                    .HasMaxLength(6)
                    .IsUnicode(false);                           //CHCAR(6)
            entity.Property(e => e.CustName)
                    .HasMaxLength(50).IsUnicode(true);          //NCHAR(50)
            entity.Property(e => e.Address)
                .HasMaxLength(200).IsUnicode(true);            //NCHAR(200)
        });
        //
        // -- Product Table
        //
        modelBuilder.Entity<Entity.Product>(entity =>
        {
            entity.ToTable("Product")
                    .HasKey(x => x.ProdId)
                    .HasName("PK_Product");
            entity.Property(e => e.ProdId)
                    .HasMaxLength(6)
                    .IsUnicode(false);                           //CHCAR(6)
            entity.Property(e => e.ProdName)
                    .HasMaxLength(50)
                    .IsUnicode(true);                           //CHCAR(6)
            entity.Property(e => e.CatId)
                    .HasMaxLength(6)
                    .IsUnicode(false);                           //CHCAR(6)
        }
        );
    }
}
