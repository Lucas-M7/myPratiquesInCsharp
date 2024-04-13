namespace Api_ComMongo.Models;
public class ProdutoDataBaseSettings
{
    public string ConnectionString { get; set; } = default!;
    public string DatabaseName { get; set; } = default!;
    public string ProdutoCollectionName { get; set; } = default!;
}