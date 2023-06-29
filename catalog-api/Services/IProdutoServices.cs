namespace catalog_api.Services;
public interface IProdutoServices
{
    public Task<int> CriarProdutoAsync(ProdutoModel produto);

    public Task<IEnumerable<ProdutoModel>> ExibirProdutosAsync();

    public Task<ProdutoModel?> ExibirProdutoPorIdAsync(int id);
}
