namespace Blog.Data.Mappings;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

/*  
    @author Winpenning
    FluentMapping for the Category model <3
*/

/* the FluentMapping need to implement the 
   IEntityTypeConfiguration<T> interface
*/
public class CategoryMap : IEntityTypeConfiguration<Category>
{

    // Configure is a IEntityTypeConfiguration <T> method
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        // configure the table
        builder.ToTable("Category");

        // defines the primary key using a lambda function
        builder.HasKey(x=>x.Id);

        // the Id will be generated by the code every time we add a new Category
        builder.Property(x=>x.Id)
        .ValueGeneratedOnAdd()
        .UseIdentityColumn(); // Identity (1,1)

        builder.Property(x=>x.Name)
        .IsRequired()
        .HasColumnName("Name")
        .HasColumnType("NVARCHAR")
        .HasMaxLength(200);

        builder.Property(x=>x.Slug)
        .IsRequired()
        .HasColumnName("Slug")
        .HasColumnType("NVARCHAR")
        .HasMaxLength(80);

        // Index
        builder.HasIndex(x=>x.Slug, "IX_Category_Slug")
        .IsUnique();
    }
}