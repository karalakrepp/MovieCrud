using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Concretes;

public class Context :  DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {


        optionsBuilder.UseNpgsql("Server=localhost;Port=5433;Database=MovieCrudDotnet;;Username=postgres;Password=12345678");

    }
    public DbSet <Movie> Moviess { get; set; }


}
