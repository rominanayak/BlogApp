using System.Data.Entity;

namespace BlogApp.Models
{
    public class BlogDataContext : DbContext
    {
        public object Blog { get; internal set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}