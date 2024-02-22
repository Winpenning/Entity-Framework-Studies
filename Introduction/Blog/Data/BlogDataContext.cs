namespace Blog.Data;
using Microsoft.EntityFrameworkCore;

// data context for the application with the Entity Framework
public class BlogDataContext : DbContext{
    public DbSet<Category> Category { get; set; }
    public DbSet<Post> Post { get; set; }
    public DbSet<PostTag> PostTag { get; set; }
    public DbSet<Role> Role { get; set; }
    public DbSet<Tag> Tag { get; set; }
    public DbSet<User> User { get; set; }
    public DbSet<UserRole> UserRole { get; set; }

}