namespace catalog_api.Models;

[Table("Imagens")]
public class ImagemModel
{
    public string? Id { get; set;}
    public int? ProdutoId { get; set;}
    public string? Nome { get; set;}
    public string? ImagemBase64{ get; set;}
}
