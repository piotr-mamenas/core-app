using MongoDB.Bson;
using MongoDB.Bson.IO;
using NUnit.Framework;

namespace eCorp.KeyTrade.Infrastructure.DataAccessTests
{
    [TestFixture]
    public class DbContextTests
    {
        [SetUp]
        public void Initial()
        {
            JsonWriterSettings.Defaults.Indent = true;
        }

        [Test]
        public void InitialTest()
        {
            var document = new BsonDocument();
        }
    }
}
