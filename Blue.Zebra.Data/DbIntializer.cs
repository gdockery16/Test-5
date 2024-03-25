using Blue.Zebra.Domain.Catalog;
using Microsoft.EntityFrameworkCore;

namespace Blue.Zebra.Data
{
public static class DbInitializer
{
    public static void INitializer(ModelBuilder builder)
    {
        builder.Entity<Item>().HasData(
            new Item("Shirt", "Ohio State shirt", "Nike", 29.99m)
            {
                Id = 1
            },
            new Item("Shorts", "Ohio State shorts", "Nike", 44.99m)
            {
                Id =2
            }
        );
    }
}
}