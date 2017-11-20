using eCorp.KeyTrade.Core.Domain.Aggregates.Accounts;
using eCorp.KeyTrade.Core.Domain.Aggregates.Assets;
using eCorp.KeyTrade.Core.Domain.Aggregates.Currencies;
using eCorp.KeyTrade.Core.Domain.Aggregates.Orders;
using eCorp.KeyTrade.Core.Domain.Aggregates.Products;
using MongoDB.Driver;

namespace eCorp.KeyTrade.Infrastructure.DataAccess
{
    public class DbContext
    {
        public IMongoDatabase Database;

        public DbContext()
        {
            var client = new MongoClient("mongodb://localhost");
            Database = client.GetDatabase("KeyTradeDB");
        }
        
        public IMongoCollection<Account> Accounts => Database.GetCollection<Account>("accounts");
        public IMongoCollection<Asset> Assets => Database.GetCollection<Asset>("assets");
        public IMongoCollection<AssetPrice> AssetPrices => Database.GetCollection<AssetPrice>("assetprices");
        public IMongoCollection<Currency> Currencies => Database.GetCollection<Currency>("currencies");
        public IMongoCollection<Order> Orders => Database.GetCollection<Order>("orders");
        public IMongoCollection<OrderType> OrderTypes => Database.GetCollection<OrderType>("ordertypes");
        public IMongoCollection<Product> Products => Database.GetCollection<Product>("products");
    }
}
