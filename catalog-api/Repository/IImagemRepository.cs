namespace catalog_api.Repository;
public interface IImagemRepository
{
    public Task AdicionarImagemAsync(ImagemModel imagem);
}
