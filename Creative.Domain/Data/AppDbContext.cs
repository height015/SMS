using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Creative.Domain.Data;

public class AppDbContext : IdentityDbContext<AppUserObj>
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
    }

    public DbSet<AttendanceObj> Attendance { get; set; }

    public DbSet<CourseObj> Course { get; set; }

    public DbSet<GradeObj> Grade { get; set; }

    public DbSet<ParentsObj> Parents { get; set; }

    public DbSet<StudentsObj> Students { get; set; }

    public DbSet<UniversityObj> Universitys { get; set; }




    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

       
        modelBuilder.Entity<AttendanceObj>().ToTable("Attendance");
        modelBuilder.Entity<CourseObj>().ToTable("Course");
        modelBuilder.Entity<GradeObj>().ToTable("Grade");
        modelBuilder.Entity<ParentsObj>().ToTable("Parents");
        modelBuilder.Entity<StudentsObj>().ToTable("Students");
        modelBuilder.Entity<UniversityObj>().ToTable("University");
    }

}


