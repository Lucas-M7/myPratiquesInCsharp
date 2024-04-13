using Api_ComMongo.Models;
using Api_ComMongo.Services;
using Microsoft.AspNetCore.Mvc;

namespace Api_ComMongo.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProdutosController : ControllerBase
{
    private readonly ProdutoServices _produtoServices;

    public ProdutosController(ProdutoServices produtoServices)
    {
        _produtoServices = produtoServices;
    }

    [HttpGet]
    public async Task<List<Produto>> GetProdutos() =>
        await _produtoServices.GetProdutosAsync();

    [HttpGet("{id}")]
    public async Task<Produto> GetProdutoId(string id) =>
        await _produtoServices.GetProdutosAsyncId(id);

    [HttpPost]
    public async Task<Produto> PostProdutos(Produto produto)
    {
        await _produtoServices.CreateAsync(produto);
        return produto;
    }

    [HttpPut("{id}")]
    public async Task<Produto> PutProduto(string id, Produto produto)
    {
        await _produtoServices.UpdateAsync(id, produto);
        return produto;
    }

    [HttpDelete("{id}")]
    public async Task DeleteProduto(string id) =>
        await _produtoServices.DeleteAsync(id);
}