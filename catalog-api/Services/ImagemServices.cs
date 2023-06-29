namespace catalog_api.Services;
public class ImagemServices : IImagemServices
{
    private readonly IImagemRepository _imagemRepository;

    public ImagemServices(IImagemRepository imagemRepository)
    {
        _imagemRepository = imagemRepository;
    }

    public async Task AdicionarImagemAsync(ImagemModel imagem)
    {
        await _imagemRepository.AdicionarImagemAsync(imagem);
    }
}
