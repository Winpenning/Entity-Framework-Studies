namespace Blog;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Role")]
public class Role{
    [Key]
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Slug { get; set; }
    public IList<User> Users { get; set; }
}