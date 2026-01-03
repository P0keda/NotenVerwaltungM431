using Microsoft.EntityFrameworkCore;
using NotenVerwaltung.Backend.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace NotenVerwaltung.Backend.Repositories;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ChangeRequest>()
            .Property(x => x.Status)
            .HasConversion<string>();
    }
    public DbSet<Teacher> Teachers { get; set; }
    public DbSet<Subject> Subjects { get; set; }
    public DbSet<Student> Students { get; set; }
    public DbSet<Prorector> Prorectors { get; set; }
    public DbSet<Grade> Grades { get; set; }
    public DbSet<ChangeRequest> changeRequests { get; set; }
}
