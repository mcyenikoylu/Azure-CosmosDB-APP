using Microsoft.EntityFrameworkCore;

namespace license.cosmosdb;

public class DBContext : DbContext
{
    public DbSet<Apps>? AppsDbSet { get; set; }
    public DbSet<Customers>? CustomersDbSet { get; set; }
    public DbSet<Employees>? EmployeesDbSet { get; set; }
    public DbSet<Licenses>? LicensesDbSet { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder.UseCosmos(
            "https://myapp-license-db.documents.azure.com:443/",
            "pvLGdvW1PYgSQmGijbn3OeX6KWy9Un0tkWHQzjfYfAtqcamJ6KJkGVAb5AEPXDsPEYS1UPpfXMZJACDbgXHHwg==",
            "myapp-license-db"
        ));
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Employees>()
        .ToContainer("Employees")
        .HasPartitionKey(a => a.EmployeeId);

        modelBuilder.Entity<Customers>()
        .ToContainer("Customers")
        .HasPartitionKey(s => s.CustomerId);

        modelBuilder.Entity<Apps>()
        .ToContainer("Apps")
        .HasPartitionKey(e => e.AppId);

        modelBuilder.Entity<Apps>().OwnsMany(m => m.LicensesList);
    }
}