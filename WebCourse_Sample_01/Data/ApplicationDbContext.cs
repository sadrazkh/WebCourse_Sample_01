using Microsoft.EntityFrameworkCore;
using WebCourse_Sample_01.Data.Entities;

namespace WebCourse_Sample_01.Data;

public class ApplicationDbContext : DbContext
{
    public DbSet<Post> Posts { get; set; }
    public DbSet<Comment> Comments { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Post>(post =>
        {
            post.HasKey(p => p.Id);
            post.Property(p => p.Created).HasDefaultValue(DateTime.UtcNow);

            post.HasMany(p => p.Comments)
                .WithOne(c => c.Post)
                .HasForeignKey(c => c.PostId);
        });

        modelBuilder.Entity<Comment>(comment =>
        {
            comment.HasKey(p => p.Id);
            comment.Property(c => c.CreatorDate).HasDefaultValue(DateTime.UtcNow);
        });

        base.OnModelCreating(modelBuilder);
    }
}