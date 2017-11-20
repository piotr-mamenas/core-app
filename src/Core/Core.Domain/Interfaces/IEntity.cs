using MongoDB.Bson.Serialization.Attributes;

namespace eCorp.KeyTrade.Core.Domain.Interfaces
{
    public interface IEntity
    {
        [BsonId]
        string Id { get; set; }
    }
}