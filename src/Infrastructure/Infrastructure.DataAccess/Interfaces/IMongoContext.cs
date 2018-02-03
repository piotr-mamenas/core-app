using MongoDB.Driver;

namespace eCorp.KeyTrade.Infrastructure.DataAccess.Interfaces
{
    public interface IMongoContext
    {
        /// <summary>
        /// The IMongoClient from the official MongoDb driver
        /// </summary>
        IMongoClient Client { get; }

        /// <summary>
        /// The IMongoDatabase from the official Mongodb driver
        /// </summary>
        IMongoDatabase Database { get; }

        /// <summary>
        /// The private GetCollection method
        /// </summary>
        /// <typeparam name="TDocument"></typeparam>
        IMongoCollection<TDocument> GetCollection<TDocument>();

        /// <summary>
        /// Drops a collection, use very carefully.
        /// </summary>
        /// <typeparam name="TDocument"></typeparam>
        void DropCollection<TDocument>();

        /// <summary>
        /// Sets the Guid representation of the MongoDb Driver.
        /// </summary>
        /// <param name="guidRepresentation">The new value of the GuidRepresentation</param>
        void SetGuidRepresentation(MongoDB.Bson.GuidRepresentation guidRepresentation);
    }
}