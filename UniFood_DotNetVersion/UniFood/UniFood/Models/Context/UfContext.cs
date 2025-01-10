using Microsoft.EntityFrameworkCore;

namespace UniFood.Models.Context;

public class UfContext : DbContext
{
    public UfContext(DbContextOptions<UfContext> options) : base(options)
    {
        
    }
        
    public DbSet<Food> Foods { get; set; }
    public DbSet<Student> Students { get; set; }
    public DbSet<Reserve> Reserves { get; set; }
    public DbSet<StudentReserve> StudentReserves { get; set; }
    public DbSet<Transaction> Transactions { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<StudentReserve>()
            .HasKey(sr => new {sr.StudentId, sr.ReserveId});
        
        modelBuilder.Entity<StudentReserve>()
            .HasOne(sr => sr.Student)
            .WithMany(s => s.StudentReserves)
            .HasForeignKey(sr => sr.StudentId);

        modelBuilder.Entity<StudentReserve>()
            .HasOne(sr => sr.Reserve)
            .WithMany(r => r.ReservingStudents)
            .HasForeignKey(sr => sr.ReserveId);

    }
}