namespace Blog;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Category")]
public class Category{
    [Key]
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Slug { get; set; }
}