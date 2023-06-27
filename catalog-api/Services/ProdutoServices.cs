using catalog_api.Repository;
using catalog_api.Services.Interfaces;

namespace catalog_api.Services;

public class ProdutoServices : IProdutoServices
{
    private readonly IProdutoRepository _produtoRepository;

    public ProdutoServices(IProdutoRepository produtoRepository)
    {
        _produtoRepository = produtoRepository;
    }

    public async Task CriarProdutoAsync(ProdutoModel produto)
    {
        await _produtoRepository.AdicionarAsync(produto);
    }

    public async Task<List<ProdutoModel>> ExibirProdutosAsync()
    {
        return await _produtoRepository.BuscarProdutosAsync();
    }
}
