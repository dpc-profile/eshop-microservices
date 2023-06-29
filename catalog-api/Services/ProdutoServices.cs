namespace catalog_api.Services;

public class ProdutoServices : IProdutoServices
{
    private readonly IProdutoRepository _produtoRepository;

    public ProdutoServices(IProdutoRepository produtoRepository)
    {
        _produtoRepository = produtoRepository;
    }

    public async Task<int> CriarProdutoAsync(ProdutoModel produto)
    {
        return await _produtoRepository.AdicionarAsync(produto);
    }

    public async Task<IEnumerable<ProdutoModel>> ExibirProdutosAsync()
    {
        return await _produtoRepository.BuscarProdutosAsync();
    }

    public async Task<ProdutoModel?> ExibirProdutoPorIdAsync(int id)
    {
        return await _produtoRepository.BuscarProdutoPorIdAsync(id);
    }

}
