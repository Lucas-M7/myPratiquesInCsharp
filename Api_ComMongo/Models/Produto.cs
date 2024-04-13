using System.Text.Json.Serialization;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Api_ComMongo.Models;
public class Produto
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; } = null;

    [BsonElement("Nome")]
    [JsonPropertyName("Nome")]
    public string Nome { get; set; } = default!;
    public decimal Preco { get; set; } = default!;
}