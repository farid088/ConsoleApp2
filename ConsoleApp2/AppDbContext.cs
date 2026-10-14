using Microsoft.EntityFrameworkCore;
using System.Net.Sockets;

public class AppDbContext : DbContext
{
  
    protected override void OnConfiguring(
        DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer( @"Server=.\SQLEXPRESS;Database=F7;Trusted_Connection=True;TrustServerCertificate=True");
    }
    DbSet<Student> Students { get; set; }
    DbSet<Enrollment> Enrollments { get; set; }
    DbSet<Teacher> Teachers { get; set; }
    DbSet<Department> Departments { get; set; }
    DbSet<Course> Courses { get; set; }
}