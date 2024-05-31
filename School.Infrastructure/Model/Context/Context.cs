using Microsoft.EntityFrameworkCore;

class Context : DbContext
{
    public DbSet<Student> Tdb_Students { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("server=.\\SQL2019;database=SchollDb;trusted_connection=true;MultipleActiveResultSets=True;TrustServerCertificate=True");
    }
}