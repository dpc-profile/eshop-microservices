namespace catalog_api.Repository;
public class ProdutoRepository : IProdutoRepository
{
    private readonly BancoContext _bancoContext;

    public ProdutoRepository(BancoContext bancoContext){
        _bancoContext = bancoContext;
    }

    public async Task AdicionarAsync(ProdutoModel produto)
    {
        try
        {
            await _bancoContext.AddAsync(produto);
            await _bancoContext.SaveChangesAsync();
        }
        catch (Exception)
        {
            throw new Exception("Erro ao adicionar o produto no banco de dados");
        }
    }

    public async Task<List<ProdutoModel>> BuscarProdutosAsync()
    {
        return await _bancoContext.Produto.ToListAsync();
    }
}
