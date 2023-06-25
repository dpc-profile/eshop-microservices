namespace catalog_api.Models;

[Table("Imagens")]
public class ImagemModel
{
    [Key]
    public int Id { get; init;}

    [ForeignKey("Produto")]
    public int? ProdutoId { get; init;}

    [Required]
    public string? Nome { get; init;}

    [Required]
    public string? ImagemBase64{ get; init;}
}
