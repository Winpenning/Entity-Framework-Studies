namespace Blog;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//@author Winpenning

[Table("User")]
public class User{
    // defines that the Id will be the Primary Key of the entity
    [Key]
    // the key will be automic generated in the database
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]  
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Email { get; set; }
    public string? PasswordHash { get; set; }
    public string? Bio { get; set; }
    public string? Image { get; set; }
    public string? Slug { get; set; }
}