namespace catalog_api.Profiles;
public class ProdutoProfile : Profile
{
    public ProdutoProfile()
    {
        CreateMap<CreateProdutoDto, ProdutoModel>();
        CreateMap<ImagemDto, ImagemModel>();
    }
}
