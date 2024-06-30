using Crud_comMongo.Services;
using MongoDB.Bson;
using MongoDB.Driver;

var stringDeConexao = new MongoClient("mongodb+srv://lucas015x:silv4x0908@mycrud.xrmgle1.mongodb.net/");
var bancoDeDados = stringDeConexao.GetDatabase("Crud");
var colecao = bancoDeDados.GetCollection<BsonDocument>("Usuarios");


CrudMongo documento = new();