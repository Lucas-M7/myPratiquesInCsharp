using MongoDB.Driver;

namespace Project.Infraestrutura.Db;
public class MongoConnection
{
    private readonly  IMongoDatabase _database;

    public MongoConnection(string stringDeConexao, string nomeDoBanco)
    {
        var client = new MongoClient(stringDeConexao);
        _database = client.GetDatabase(nomeDoBanco);
    }

    public IMongoCollection<T> GetMongoCollection<T>(string nomeDaColecao)
    {
        return _database.GetCollection<T>(nomeDaColecao);
    }
}