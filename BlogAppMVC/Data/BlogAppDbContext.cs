using BlogAppMVC.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace BlogAppMVC.Data
{
    public class BlogAppDbContext : DbContext
    {
        public BlogAppDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<Tag> Tags { get; set; }

    }
}
