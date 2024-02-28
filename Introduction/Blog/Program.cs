using System.Linq;
using Blog.Data;
using System.Data;
using Microsoft.EntityFrameworkCore;
using Blog;

/*  
    @author Winpenning
    Progaman class and the main method
*/

class Program
{
    static void Main(string[] args)
    {
        using var context = new BlogDataContext();
        /*int esc = int.Parse(Console.ReadLine());
        switch (esc)
        {
            case 1:
                var User = new User
                {
                    Name = "Paulo Henrique Ziemer dos Santos",
                    Slug = "1",
                    Email = "1",
                    Bio = "Your future lover",
                    Image = "ImagePath",
                    PasswordHash = "123456789"
                };

                var Category = new Category
                {
                    Name = "Backend",
                    Slug = "1"
                };

                var Post = new Post
                {
                    Author = User,
                    Category = Category,
                    Body = "<p>Hello world<p>",
                    Slug = "Studing the Entity Framework Core1",
                    Summary = "text",
                    Title = "Starting with Entity Framework Core",
                    CreateDate = DateTime.Now,
                    LastUpdateDate = DateTime.Now
                };
                // this is awesome <3
                context.Post.Add(Post);
                context.SaveChanges();
                break;
            // select query
            case 2:
                var Posts = context
                .Post
                .AsNoTracking()
                //.Where(x=> x.AuthorId == 5)
                .Include(x => x.Author)
                .Include(x => x.Category)
                .OrderByDescending(x => x.LastUpdateDate)
                .ToList();

                foreach (var pxost in Posts){

                    Console.WriteLine($"Title: {pxost.Title}\n Author: {pxost.Author?.Name} at {pxost.Category.Name}");
                }
                break;
            // update query
            case 3:
                var post = context
                .Post
                .Include(x=>x.Author)
                .Include(x=>x.Category)
                .OrderByDescending(x=>x.LastUpdateDate)
                .FirstOrDefault();

                post.Author.Name = "Genghis Khan";

                context.Post.Update(post);
                context.SaveChanges();
                break;

            case 4:
                context.User.Add(new User
                {
                    Bio =" a ",
                    Email = "a@a.com",
                    Image = "a",
                    Name = "Paulito",
                    PasswordHash = "12345",
                    Slug = "paulo"
                });
                context.SaveChanges();
                break;
        }*/

        /* var User = context.User.FirstOrDefault(x => x.Id == 1);
        var Post = new Post
        {
            Author = User,
            Body = "Some generic text for example options",
            Category = new Category
            {
                Name = "Category.Name.System.Java.Lang",
                Slug = "Java.Best.Laguage.Ever"
            },
            CreateDate = System.DateTime.Now,
            Slug = "User post",
            Summary = "ABCDEFGHIJKLMNOPQRSTUVWXYZ",
            Title = "First Article"
        };
        context.Post.Add(Post);
        context.SaveChanges();
    }*/
    }
}