using eCorp.KeyTrade.Core.Domain.Models.Accounts;
using eCorp.KeyTrade.Core.Domain.Models.Assets;
using eCorp.KeyTrade.Core.Domain.Models.Currencies;
using eCorp.KeyTrade.Core.Domain.Models.Orders;
using eCorp.KeyTrade.Core.Domain.Models.Products;
using Microsoft.EntityFrameworkCore;

namespace eCorp.KeyTrade.Infrastructure.DataAccess
{
    public class AppDbContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Asset> Assets { get; set; }
        public DbSet<AssetPrice> AssetPrices { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderType> OrderTypes { get; set; }
        public DbSet<Product> Products { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
            
        }
    }
}
