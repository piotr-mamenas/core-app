using System;
using eCorp.KeyTrade.Core.Domain.Interfaces;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace eCorp.KeyTrade.Core.Domain.Aggregates
{
    [Serializable]
    [BsonIgnoreExtraElements(Inherited = true)]
    public abstract class Entity : IEntity
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public virtual string Id { get; set; }
    }
}
