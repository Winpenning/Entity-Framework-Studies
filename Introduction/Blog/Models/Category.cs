namespace Blog;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

//@author Winpenning

[Table("Category")]
public class Category{
    // defines that the Id will be the Primary Key of the entity
    [Key]
    // the key will be automic generated in the database
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]  
    public int Id { get; set; }

    // the Name is not null
    [Required] 
    [MinLength(3)]
    [MaxLength(80)]
    [Column("Name", TypeName ="NVARCHAR")]
    public string? Name { get; set; }

    public string? Slug { get; set; }
    
    public IList<Post> Posts { get; set; }

}