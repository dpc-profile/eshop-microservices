namespace catalog_api.Repository;
public class ProdutoRepository : IProdutoRepository
{
    private readonly BancoContext _bancoContext;

    public ProdutoRepository(BancoContext bancoContext){
        _bancoContext = bancoContext;
    }

    public async Task<int> AdicionarAsync(ProdutoModel produto)
    {
        try
        {
            await _bancoContext.Produto.AddAsync(produto);
            await _bancoContext.SaveChangesAsync();

            return produto.Id;
        }
        catch (Exception)
        {
            throw new Exception("Erro ao adicionar o produto no banco de dados");
        }
    }

    public async Task<ProdutoModel?> BuscarProdutoPorIdAsync(int id)
    {
        return await _bancoContext.Produto.FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task<IEnumerable<ProdutoModel>> BuscarProdutosAsync()
    {
        return await _bancoContext.Produto.ToListAsync();
    }

}
