using Microsoft.EntityFrameworkCore;
using NotenVerwaltung.Backend.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace NotenVerwaltung.Backend.Repositories;

/// <summary>
/// class for Db models
/// </summary>
/// <seealso cref="Microsoft.EntityFrameworkCore.DbContext" />
public class AppDbContext : DbContext
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AppDbContext"/> class.
    /// </summary>
    /// <param name="options">The options.</param>
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ChangeRequest>()
            .Property(x => x.Status)
            .HasConversion<string>();
    }

    /// <summary>
    /// Gets or sets the teachers.
    /// </summary>
    /// <value>
    /// The teachers.
    /// </value>
    public DbSet<Teacher> Teachers { get; set; }

    /// <summary>
    /// Gets or sets the subjects.
    /// </summary>
    /// <value>
    /// The subjects.
    /// </value>
    public DbSet<Subject> Subjects { get; set; }

    /// <summary>
    /// Gets or sets the students.
    /// </summary>
    /// <value>
    /// The students.
    /// </value>
    public DbSet<Student> Students { get; set; }

    /// <summary>
    /// Gets or sets the prorectors.
    /// </summary>
    /// <value>
    /// The prorectors.
    /// </value>
    public DbSet<Prorector> Prorectors { get; set; }

    /// <summary>
    /// Gets or sets the grades.
    /// </summary>
    /// <value>
    /// The grades.
    /// </value>
    public DbSet<Grade> Grades { get; set; }

    /// <summary>
    /// Gets or sets the change requests.
    /// </summary>
    /// <value>
    /// The change requests.
    /// </value>
    public DbSet<ChangeRequest> changeRequests { get; set; }
}
