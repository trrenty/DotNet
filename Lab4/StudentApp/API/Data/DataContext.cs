using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
  public class DataContext : DbContext
  {
    public DataContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Student> Students { get; set; }

    public DbSet<API.Entities.Product> Product { get; set; }
  }
}