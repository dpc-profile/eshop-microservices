namespace catalog_api.Models;

[Table("Produto")]
public class ProdutoModel
{
    [Key]
    public int Id { get; init; }

    [Required(ErrorMessage = "Nome do produto necessário.")]
    public string? Nome { get; init; }

    [Required(ErrorMessage = "Descrição do produto necessário.")]
    public string? Descricao { get; init; }

    [Required(ErrorMessage = "categoria do produto necessário.")]
    public string? Categoria { get; init; }

    [Required(ErrorMessage = "Imagem do produto necessário.")]
    public List<ImagemModel>? Imagens { get; init; }

    [Required(ErrorMessage = "Quantidade do produto necessário.")]
    public int Quantidade { get; init; }

    [Column(TypeName = "decimal(18,2)")]
    [Required(ErrorMessage = "Preço do produto necessário.")]
    public decimal Preco { get; init; }

    [Column(TypeName = "decimal(18,2)")]
    public decimal? PrecoDesconto { get; init; }
    public double? DescontoPorcentagem { get; init; }

    public ProdutoSimplificado ProdutoSimplificado() => new()
    {
        Id = this.Id,
        Nome = this.Nome,
        Categoria = this.Categoria,
        ImagemMiniatura = this.Imagens?.FirstOrDefault(),
        Quantidade = this.Quantidade,
        Preco = this.Preco,
        PrecoDesconto = this.PrecoDesconto,
        DescontoPorcentagem = this.DescontoPorcentagem
    };
}
