using eCorp.KeyTrade.Infrastructure.DataAccess.Interfaces;
using MongoDB.Driver;

namespace eCorp.KeyTrade.Infrastructure.DataAccess
{
    /// <summary>
    /// The MongoDb context
    /// </summary>
    public class MongoContext : IMongoContext
    {
        /// <summary>
        /// The IMongoClient from the official MongoDb driver
        /// </summary>
        public IMongoClient Client { get; }

        /// <summary>
        /// The IMongoDatabase from the official Mongodb driver
        /// </summary>
        public IMongoDatabase Database { get; }

        static MongoContext()
        {
            // Avoid legacy UUID representation: use Binary 0x04 subtype.
            MongoDefaults.GuidRepresentation = MongoDB.Bson.GuidRepresentation.Standard;
        }

        /// <summary>
        /// Sets the Guid representation of the MongoDb Driver.
        /// </summary>
        /// <param name="guidRepresentation">The new value of the GuidRepresentation</param>
        public void SetGuidRepresentation(MongoDB.Bson.GuidRepresentation guidRepresentation)
        {
            MongoDefaults.GuidRepresentation = guidRepresentation;
        }

        /// <summary>
        /// The constructor of the MongoContext, it needs a an object implementing <see cref="IMongoDatabase"/>.
        /// </summary>
        /// <param name="mongoDatabase">An object implementing IMongoDatabase</param>
        public MongoContext(IMongoDatabase mongoDatabase)
        {
            Database = mongoDatabase;
            Client = Database.Client;
        }

        /// <summary>
        /// The constructor of the MongoContext, it needs a connection string and a database name. 
        /// </summary>
        /// <param name="connectionString">The connections string.</param>
        /// <param name="databaseName">The name of your database.</param>
        public MongoContext(string connectionString, string databaseName)
        {
            Client = new MongoClient(connectionString);
            Database = Client.GetDatabase(databaseName);
        }

        /// <summary>
        /// The private GetCollection method
        /// </summary>
        /// <typeparam name="TDocument">The type representing a Document.</typeparam>
        /// <returns></returns>
        public IMongoCollection<TDocument> GetCollection<TDocument>()
        {
            return Database.GetCollection<TDocument>(Pluralize<TDocument>());
        }

        /// <summary>
        /// Drops a collection, use very carefully.
        /// </summary>
        /// <typeparam name="TDocument">The type representing a Document.</typeparam>
        public void DropCollection<TDocument>()
        {
            Database.DropCollection(Pluralize<TDocument>());
        }

        /// <summary>
        /// Very naively pluralizes a TDocument type name.
        /// </summary>
        /// <typeparam name="TDocument">The type representing a Document.</typeparam>
        /// <returns></returns>
        private static string Pluralize<TDocument>()
        {
            return (typeof(TDocument).Name.Pluralize()).Camelize();
        }
    }
}
