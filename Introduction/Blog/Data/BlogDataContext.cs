namespace Blog.Data;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore;

// data context for the application with the Entity Framework
public class BlogDataContext : DbContext{
    public DbSet<Category> Category { get; set; }
    public DbSet<Post> Post { get; set; }
    // public DbSet<PostTag> PostTag { get; set; }
    public DbSet<Role> Role { get; set; }
    public DbSet<Tag> Tag { get; set; }
    public DbSet<User> User { get; set; }
    // public DbSet<UserRole> UserRole { get; set; }

    protected override void OnConfiguring
    (DbContextOptionsBuilder options)
        => options.UseSqlServer("Server=localhost,1433;Database=balta;User ID=sa;Password=1q2w3e4r@#$");
    
}