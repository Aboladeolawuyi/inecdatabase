using Microsoft.EntityFrameworkCore;
public partial class AppContext : DbContext
{
    public DbSet<votes> votes { get; set; }



    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        //For PostgreSQL:
        options.UseNpgsql("Server=localhost;Database=votesDB;userid=postgres;password=Peace_3124");
        //options.UseSqlServer("your_sqlserver_connection_string_here");
        //options.UseMySql("your_mysql_connection_string_here", ServerVersion.AutoDetect("your_mysql_version_here"));
    }
}
