using System.Runtime.CompilerServices;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Crud_comMongo.Services;

public class CrudMongo
{
    public async Task CriarUsuario(IMongoCollection<BsonDocument> collection)
    {
        var documento = new BsonDocument
        {
            {"nome", "Anderson Silva"},
            {"idade", 47},
            {"email", "Silva@email.com"}
        };

        await collection.InsertOneAsync(documento);
        Console.WriteLine("Documento criado com sucesso!");
    }

    public async Task LerDocumentos(IMongoCollection<BsonDocument> collection)
    {
        var documentos = await collection.Find(new BsonDocument()).ToListAsync();
        foreach (var documento in documentos)
        {
            Console.WriteLine(documento);
        }
    }

    public async Task AtualizarDocumento(IMongoCollection<BsonDocument> collection)
    {
        var filtrar = Builders<BsonDocument>.Filter.Eq("nome", "Ana Maria");
        var atualizar = Builders<BsonDocument>.Update.Set("nome", "Lucas Mateus")
            .Set("idade", 18)
            .Set("email", "Lucas@email.com");
        await collection.UpdateOneAsync(filtrar, atualizar);
        Console.WriteLine("Documento atualizado com sucesso!");
    }

    public async Task DeletarDocumento(IMongoCollection<BsonDocument> collection)
    {
        var filtrar = Builders<BsonDocument>.Filter.Eq("nome", "Ana Maria");
        await collection.DeleteOneAsync(filtrar);
        Console.WriteLine("Documento deletado com sucesso!");
    }
}