using Microsoft.EntityFrameworkCore;

namespace BakeryErp.Infrastructure.Persistence;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    // DbSets will go here later
}