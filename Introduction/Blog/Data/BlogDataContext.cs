using Blog.Data.Mappings;
using Blog.Models;

namespace Blog.Data;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore;

/*  
    @author Winpenning
    Class for the database connection and entities definition
*/
public class BlogDataContext : DbContext{
    public DbSet<Category> Category { get; set; }
    public DbSet<Post> Post { get; set; }
    public DbSet<User> User { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new CategoryMap());
        modelBuilder.ApplyConfiguration(new PostMap());
        modelBuilder.ApplyConfiguration(new UserMap());
    }
    // method for the database connections using the connection string
    protected override void OnConfiguring
    (DbContextOptionsBuilder options)
        =>options.UseSqlServer("Server=localhost,1433;Database=Blog;User ID=sa;Password=1q2w3e4r@#$");


}