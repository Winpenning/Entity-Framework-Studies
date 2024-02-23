using System.Diagnostics;
using Blog;
using System.Linq;
using Blog.Data;
using System.Data;
using Microsoft.EntityFrameworkCore;

/*  
    @author Winpenning
    Progaman class and the main method
*/

class Program
{
    static void Main(string[] args)
    {


        using (var context = new BlogDataContext())
        {
            int esc = int.Parse(Console.ReadLine());
            switch (esc)
            {
                
                // add the object to the database
                case 1:
                    // create the object
                    var newTag = new Tag { Name = "Programação de jogos", Slug = "desenvolvimento" };
                    
                    // add the object to the table
                    try {context.Tag.Add(newTag);}
                    catch(Exception e) {Console.WriteLine($"Error a: {e}");}

                    // make changes to the database
                    try {context.SaveChanges();}
                    catch(Exception e) {Console.WriteLine($"Error b: {e}");}
                    
                    break;
                
                // update the object to the database
                case 2:
                    // return the object to the variable using LINQ method
                    var updateTag = context.Tag.FirstOrDefault(x => x.Id== 21);
                    // set the changes
                    try {updateTag.Name = "Redes de computadores";}
                    catch(DataException e) {Console.WriteLine($"Error: {e}");}
                    catch(ArgumentNullException e){Console.WriteLine($"Error: {e}");}
                    // update on the memory database
                    try {context.Update(updateTag);}
                    catch(Exception e) {Console.WriteLine($"Error: {e}");}
                    // make changes to the database
                    try {context?.SaveChanges();}
                    catch(Exception e) {Console.WriteLine($"Error: {e}");}
                    break;
                
                // remove the object from the database
                case 3:

                    // return the object to the variable using LINQ method
                    var removeTag = context.Tag.FirstOrDefault(x => x.Id== 23);
                    // set the changes
                    try {context.Remove(removeTag);}
                    catch(Exception e) {Console.WriteLine($"Error: {e}");}
                   // make changes to the database
                    try {context.SaveChanges();}
                    catch(Exception e) {Console.WriteLine($"Error: {e}");}
                    break;

                // select in database
                case 4:
                    // return a tag dbSet (we don't want it)
                    //var tags = context.Tag; -> this don't execute the query

                    //this execute the query (ToList must be in the end of the command)
                    var tags = context
                    .Tag
                    .Where(x => x.Name == "ASP.NET4")
                    .AsNoTracking() // disable the tracking for the query
                    .ToList(); // execute the query
                    
                    // print the list
                    foreach(var x in tags){Console.WriteLine($"{x.Id}: {x.Name}\n");}
                    break;  


               default:
                    break;
            }
        }
    }
}