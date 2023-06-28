namespace catalog_api.Repository;
public interface IProdutoRepository
{
    public Task<int> AdicionarAsync(ProdutoModel produto);
    public Task<List<ProdutoModel>> BuscarProdutosAsync();
    public Task<ProdutoModel?> BuscarProdutoPorIdAsync(int id);
}
