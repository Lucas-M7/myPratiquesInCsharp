using MongoDB.Driver;

namespace mongo.Infraestruture.Db;
public class MongoConnect
{
    private readonly IMongoDatabase _database;

    public MongoConnect(string connectionString, string databaseName)
    {
        var client = new MongoClient(connectionString);
        _database = client.GetDatabase(databaseName);
    }

    public IMongoCollection<T> GetCollection<T>(string collectionName)
    {
        return _database.GetCollection<T>(collectionName);
    }
}