using Microsoft.EntityFrameworkCore;

public class EntityContext : DbContext
{
    public DbSet<Post> Posts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDb;Initial Catalog=midori");
    }
}

public class Post
{
    public int PostId { get; set; }
    public required string Content { get; set; }
}