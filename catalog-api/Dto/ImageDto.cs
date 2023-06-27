namespace catalog_api.Dto;
public class ImageDto
{
    [Required(ErrorMessage = "A imagem precisa de um nome")]
    public string? Nome { get; init;}

    [Required(ErrorMessage = "É necessário passar a imagem convertida para base64")]
    public string? ImagemBase64{ get; init;}

}
