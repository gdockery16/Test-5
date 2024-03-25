using Blue.Zebra.Domain.Catalog;
using Microsoft.EntityFrameworkCore;

namespace Blue.Zebra.Data
{
    public class StoreContext : DbContext
    {
    public StoreContext(DbContextOptions<StoreContext> options)
    : base(options)
{ }
public DbSet<Item> Items { get; set; }
}
}


