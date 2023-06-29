namespace catalog_api.Repository;
public class ImagemRepository : IImagemRepository
{
    private readonly BancoContext _bancoContext;

    public ImagemRepository(BancoContext bancoContext){
        _bancoContext = bancoContext;
    }

    public async Task AdicionarImagemAsync(ImagemModel imagem)
    {
        try
        {
            await _bancoContext.Imagem.AddAsync(imagem);
            await _bancoContext.SaveChangesAsync();
        }
        catch (Exception)
        {
            throw new Exception("Erro ao adicionar a imagem do produto no banco de dados");
        }
    }
}
