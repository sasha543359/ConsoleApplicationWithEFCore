using Microsoft.EntityFrameworkCore;

namespace ConsoleApplicationWithEFCore;

internal class AppContext : DbContext
{
    public AppContext()
    {
        Database.EnsureCreated();
    }

    public DbSet<Person> Persons { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=San4o\\SQLEXPRESS;Database=NewDataBase;trusted_connection=True;TrustServerCertificate=True;");
    }
}