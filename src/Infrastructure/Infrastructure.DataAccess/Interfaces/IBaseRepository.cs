using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace eCorp.KeyTrade.Infrastructure.DataAccess.Interfaces
{
    public interface IBaseRepository<TDocument> where TDocument : IDocument
    {
        /// <summary>
        /// The connection string.
        /// </summary>
        string ConnectionString { get; set; }
        /// <summary>
        /// The database name.
        /// </summary>
        string DatabaseName { get; set; }

        #region Create

        /// <summary>
        /// Asynchronously adds a document to the collection.
        /// </summary>
        /// <typeparam name="TDocument">The type representing a Document.</typeparam>
        /// <param name="document">The document you want to add.</param>
        Task AddOneAsync(TDocument document);

        /// <summary>
        /// Adds a document to the collection.
        /// Populates the Id and AddedAtUtc fields if necessary.
        /// </summary>
        /// <typeparam name="TDocument">The type representing a Document.</typeparam>
        /// <param name="document">The document you want to add.</param>
        void AddOne(TDocument document);

        /// <summary>
        /// Asynchronously adds a list of documents to the collection.
        /// Populates the Id and AddedAtUtc fields if necessary.
        /// </summary>
        /// <typeparam name="TDocument">The type representing a Document.</typeparam>
        /// <param name="documents">The document you want to add.</param>
        Task AddManyAsync(IEnumerable<TDocument> documents);

        /// <summary>
        /// Adds a list of documents to the collection.
        /// Populates the Id and AddedAtUtc fields if necessary.
        /// </summary>
        /// <typeparam name="TDocument">The type representing a Document.</typeparam>
        /// <param name="documents">The document you want to add.</param>
        void AddMany(IEnumerable<TDocument> documents);

        #endregion

        #region Read

        /// <summary>
        /// Asynchronously returns one document given its id.
        /// </summary>
        /// <param name="id">The Id of the document you want to get.</param>
        Task<TDocument> GetByIdAsync(Guid id);

        /// <summary>
        /// Returns one document given its id.
        /// </summary>
        /// <param name="id">The Id of the document you want to get.</param>
        TDocument GetById(Guid id);

        /// <summary>
        /// Asynchronously returns one document given an expression filter.
        /// </summary>
        /// <param name="filter">A LINQ expression filter.</param>
        Task<TDocument> GetOneAsync(Expression<Func<TDocument, bool>> filter);

        /// <summary>
        /// Returns one document given an expression filter.
        /// </summary>
        /// <param name="filter">A LINQ expression filter.</param>
        TDocument GetOne(Expression<Func<TDocument, bool>> filter);

        /// <summary>
        /// Asynchronously returns true if any of the document of the collection matches the filter condition.
        /// </summary>
        /// <param name="filter">A LINQ expression filter.</param>
        Task<bool> AnyAsync(Expression<Func<TDocument, bool>> filter);

        /// <summary>
        /// Returns true if any of the document of the collection matches the filter condition.
        /// </summary>
        /// <param name="filter">A LINQ expression filter.</param>
        bool Any(Expression<Func<TDocument, bool>> filter);

        /// <summary>
        /// Asynchronously returns a list of the documents matching the filter condition.
        /// </summary>
        /// <param name="filter">A LINQ expression filter.</param>
        Task<List<TDocument>> GetAllAsync(Expression<Func<TDocument, bool>> filter);

        /// <summary>
        /// Returns a list of the documents matching the filter condition.
        /// </summary>
        /// <param name="filter">A LINQ expression filter.</param>
        List<TDocument> GetAll(Expression<Func<TDocument, bool>> filter);

        /// <summary>
        /// Asynchronously counts how many documents match the filter condition.
        /// </summary>
        /// <param name="filter">A LINQ expression filter.</param>
        Task<long> CountAsync(Expression<Func<TDocument, bool>> filter);

        /// <summary>
        /// Counts how many documents match the filter condition.
        /// </summary>
        /// <param name="filter">A LINQ expression filter.</param>
        long Count(Expression<Func<TDocument, bool>> filter);

        #endregion

        #region Update

        /// <summary>
        /// Asynchronously Updates a document.
        /// </summary>
        /// <param name="modifiedDocument">The document with the modifications you want to persist.</param>
        Task<bool> UpdateOneAsync(TDocument modifiedDocument);

        /// <summary>
        /// Updates a document.
        /// </summary>
        /// <param name="modifiedDocument">The document with the modifications you want to persist.</param>
        bool UpdateOne(TDocument modifiedDocument);

        #endregion

        #region Delete

        /// <summary>
        /// Asynchronously deletes a document.
        /// </summary>
        /// <typeparam name="TDocument">The type representing a Document.</typeparam>
        /// <returns>The number of documents deleted.</returns>
        Task<long> DeleteOneAsync(TDocument document);

        /// <summary>
        /// Asynchronously deletes a document matching the condition of the LINQ expression filter.
        /// </summary>
        /// <param name="filter">A LINQ expression filter.</param>
        /// <returns>The number of documents deleted.</returns>
        Task<long> DeleteOneAsync(Expression<Func<TDocument, bool>> filter);

        /// <summary>
        /// Deletes a document.
        /// </summary>
        /// <param name="document">The document you want to delete.</param>
        /// <returns>The number of documents deleted.</returns>
        long DeleteOne(TDocument document);

        /// <summary>
        /// Deletes a document matching the condition of the LINQ expression filter.
        /// </summary>
        /// <param name="filter">A LINQ expression filter.</param>
        /// <returns>The number of documents deleted.</returns>
        long DeleteOne(Expression<Func<TDocument, bool>> filter);

        /// <summary>
        /// Asynchronously deletes the documents matching the condition of the LINQ expression filter.
        /// </summary>
        /// <param name="filter">A LINQ expression filter.</param>
        /// <returns>The number of documents deleted.</returns>
        Task<long> DeleteManyAsync(Expression<Func<TDocument, bool>> filter);

        /// <summary>
        /// Asynchronously deletes a list of documents.
        /// </summary>
        /// <param name="documents">The list of documents to delete.</param>
        /// <returns>The number of documents deleted.</returns>
        Task<long> DeleteManyAsync(IEnumerable<TDocument> documents);

        /// <summary>
        /// Deletes a list of documents.
        /// </summary>
        /// <param name="documents">The list of documents to delete.</param>
        /// <returns>The number of documents deleted.</returns>
        long DeleteMany(IEnumerable<TDocument> documents);

        /// <summary>
        /// Deletes the documents matching the condition of the LINQ expression filter.
        /// </summary>
        /// <param name="filter">A LINQ expression filter.</param>
        /// <returns>The number of documents deleted.</returns>
        long DeleteMany(Expression<Func<TDocument, bool>> filter);

        #endregion 
    }
}