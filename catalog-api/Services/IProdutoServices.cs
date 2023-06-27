namespace catalog_api.Services;
public interface IProdutoServices
{
    public Task CriarProdutoAsync(ProdutoModel produto);

    public Task<List<ProdutoModel>> ExibirProdutosAsync();

    public Task AdicionarImagemAsync();

}
