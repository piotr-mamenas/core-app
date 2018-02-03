using System;
using eCorp.KeyTrade.Infrastructure.DataAccess.Interfaces;
using MongoDB.Bson.Serialization.Attributes;

namespace eCorp.KeyTrade.Infrastructure.DataAccess.Repository
{
    public class Document : IDocument
    {
        /// <summary>
        /// The document constructor
        /// </summary>
        public Document()
        {
            Id = Guid.NewGuid();
            AddedAtUtc = DateTime.UtcNow;
        }

        /// <summary>
        /// The Id of the document
        /// </summary>
        [BsonId]
        public Guid Id { get; set; }

        /// <summary>
        /// The datetime in UTC at which the document was added.
        /// </summary>
        public DateTime AddedAtUtc { get; set; }

        /// <summary>
        /// The version of the schema of the document
        /// </summary>
        public int Version { get; set; }
    }
}
