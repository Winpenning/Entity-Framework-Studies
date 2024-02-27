namespace Blog;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Post")]
public class Post
{
    // defines that the Id will be the Primary Key of the entity
    [Key]
    // the key will be automic generated in the database
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [ForeignKey("CategoryId")]
    public int CategoryId { get; set; }
    // Defines the Category item like an navigation propety
    public Category Category { get; set; }
    
    [ForeignKey("AuthorId")]
    public int AuthorId { get; set; }
    public User Author { get; set; }
    public string? Title { get; set; }
    public string? Summary { get; set; }
    public string? Body { get; set; }
    public string? Slug { get; set; }
    public DateTime CreateDate { get; set; }
    public DateTime LastUpdateDate { get; set; }
}