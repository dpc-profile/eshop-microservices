namespace catalog_api.Models;

[Table("Imagens")]
public class ImagemModel
{
    [Required]
    public int? Id { get; set;}

    [Required]
    public int? ProdutoId { get; set;}

    [Required]
    public string? Nome { get; set;}

    [Required]
    public string? ImagemBase64{ get; set;}
}
