using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Models
{
  public class AnimalShelterContext : DbContext
  {
    public DbSet<Animal> Items { get; set; }

    public AnimalShelterContext(DbContextOptions options) : base(options) { }
  }
}