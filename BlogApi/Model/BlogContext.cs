using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;
namespace BlogApi.Model
{
    public class BlogContext : DbContext
    {
        public BlogContext(DbContextOptions<BlogContext> options)
           : base(options)
        {
        }

        public DbSet<Blog> Blogs { get; set; } = null!;
    }
}


