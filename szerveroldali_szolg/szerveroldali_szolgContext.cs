using Microsoft.EntityFrameworkCore;

public class szerveroldali_szolgContext(DbContextOptions<szerveroldali_szolgContext> options) : DbContext(options)
{
    public DbSet<szerveroldali_szolg.Models.Movie> Movie { get; set; } = default!;
}
