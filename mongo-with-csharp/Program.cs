using mongo.Infraestruture.Db;
using mongo_with_csharp.models;
using MongoDB.Bson;
using MongoDB.Driver;

var connectionString = "mongodb+srv://lucas015x:Dukinha0908@learnmongodb.vulun2p.mongodb.net/?retryWrites=true&w=majority&appName=LearnMongoDB";
var databaseName = "LearningMongoDB";
var collectionName = "Treinando";

var mongoConnection = new MongoConnect(connectionString, databaseName);
var collection = mongoConnection.GetCollection<Users>(collectionName);

#region InserirDocumento
var document = new Users
{
    Nome = "Lucas Mateus Da Silva",
    Idade = 18,
    Cidade = "Not Found"
};

collection.InsertOne(document);
#endregion


#region AtualizarDocumento
var filter = Builders<Users>.Filter.Eq(x => x.Nome, "Lucas Silva");
var update = Builders<Users>.Update
    .Set(x => x.Nome, "Lucas Mateus Da Silva")
    .Set(x => x.Idade, 19);

var result = collection.UpdateOne(filter, update);

Console.WriteLine($"Matched {result.MatchedCount} documents and modified {result.ModifiedCount} documents.");
#endregion