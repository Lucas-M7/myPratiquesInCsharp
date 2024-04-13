using Api_ComMongo.Models;
using Microsoft.Extensions.Options;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Api_ComMongo.Services;
public class ProdutoServices
{
    private readonly IMongoCollection<Produto> _collection;

    public ProdutoServices(IOptions<ProdutoDataBaseSettings> options)
    {
        var mongoClient = new MongoClient(options.Value.ConnectionString);
        var mongoDatabase = mongoClient.GetDatabase(options.Value.DatabaseName);

        _collection = mongoDatabase.GetCollection<Produto>
            (options.Value.ProdutoCollectionName);
    }

    public async Task<List<Produto>> GetProdutosAsync() =>
        await _collection.Find(x => true).ToListAsync();

    public async Task<Produto> GetProdutosAsyncId(string id) =>
        await _collection.Find(x => x.Id == id).FirstOrDefaultAsync();

    public async Task CreateAsync(Produto produto) =>
        await _collection.InsertOneAsync(produto);

    public async Task UpdateAsync(string id, Produto produto) =>
        await _collection.ReplaceOneAsync(x => x.Id == id, produto);

    public async Task DeleteAsync(string id) =>
        await _collection.DeleteOneAsync(x => x.Id == id);
}