using Blog;
using Blog.Data;

class Program{
    static void main(string[] args){
        using (var context = new BlogDataContext()){
            var tag = new Tag { Name= "ASP.NET",Slug="aspnet" }
            
        }
    }
}