using Microsoft.EntityFrameworkCore;

namespace ETF_Orders_Domain_API
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
        }

        public DbSet<OrdersItem> OrdersItems { get; set; } = default!;
    }
}