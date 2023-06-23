namespace catalog_api.Repository;
public interface IProdutoRepository
{
    public void Adicionar(ProdutoModel Produto);
    public void Atualizar(ProdutoModel Produto);
    public void Apagar(ProdutoModel Produto);
    public List<ProdutoSimplificado> ListarXProdutos(int quantProdutos);

}
