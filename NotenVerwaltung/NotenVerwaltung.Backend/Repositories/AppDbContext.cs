using Microsoft.EntityFrameworkCore;
using NotenVerwaltung.Backend.Models;

namespace NotenVerwaltung.Backend.Repositories;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Teacher> Teachers { get; set; }
}
