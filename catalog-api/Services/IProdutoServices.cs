namespace catalog_api.Services;
public interface IProdutoServices
{
    public Task<int> CriarProdutoAsync(ProdutoModel produto);

    public Task<List<ProdutoModel>> ExibirProdutosAsync();

    public Task<ProdutoModel?> ExibirProdutoPorIdAsync(int id);

    public Task AdicionarImagemAsync(int produtoId, ImagemModel imagem);

}
