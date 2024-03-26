using AspNetPro.Blog.Models.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace AspNetPro.Blog.Infrastructure.Data;

public class BlogContext : DbContext
{
    public DbSet<Post> Posts {  get; set; }
    public BlogContext(DbContextOptions<BlogContext> dbContextOptions) : base(dbContextOptions)
    {

    }

    //private string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=aspnetpro-server;Integrated Security=True;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        var assembly = typeof(BlogContext).Assembly;
        modelBuilder.ApplyConfigurationsFromAssembly(assembly);

        base.OnModelCreating(modelBuilder);
    }
}
  