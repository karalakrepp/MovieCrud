using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Concretes;

public class Context :  DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {


        optionsBuilder.UseNpgsql("Server=host;Port=port;Database=dbname;;Username=yourusername;Password=yourpass");

    }
    public DbSet <Movie> Moviess { get; set; }


}
