namespace catalog_api.Services.Interfaces;
public interface IProdutoServices
{
    public Task CriarProdutoAsync(ProdutoModel produto);

    public Task<List<ProdutoModel>> ExibirProdutosAsync();

}
