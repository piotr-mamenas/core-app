using System;

namespace eCorp.KeyTrade.Infrastructure.DataAccess.Interfaces
{
    /// <summary>
    /// This class represents a basic document that can be stored in MongoDb.
    /// </summary>
    public interface IDocument
    {
        /// <summary>
        /// The Primary Key
        /// </summary>
        Guid Id { get; set; }

        /// <summary>
        /// A version number, to indicate the version of the schema.
        /// </summary>
        int Version { get; set; }
    }
}