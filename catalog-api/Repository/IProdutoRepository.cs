namespace catalog_api.Repository;
public interface IProdutoRepository
{
    public Task AdicionarAsync(ProdutoModel produto);
    public Task<List<ProdutoModel>> BuscarProdutosAsync();

}
