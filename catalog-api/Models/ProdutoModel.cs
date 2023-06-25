namespace catalog_api.Models;

[Table("Produto")]
public class ProdutoModel
{
    [Required]
    public int Id { get; init; }

    [Required]
    public string? Nome { get; init; }

    [Required]
    public string? Descricao { get; init; }

    [Required]
    public List<ImagemModel>? Imagens { get; init; }

    [Required]
    public int Quantidade { get; init; }

    [Required]
    public decimal Preco { get; init; }

    public double? PrecoDesconto { get; init; }
    public double? DescontoPorcentagem { get; init; }

    public ProdutoSimplificado ProdutoSimplificado() => new()
    {
        Id = this.Id,
        Nome = this.Nome,
        ImagemMiniatura = this.Imagens?.FirstOrDefault(),
        Quantidade = this.Quantidade,
        Preco = this.Preco,
        PrecoDesconto = this.PrecoDesconto,
        DescontoPorcentagem = this.DescontoPorcentagem
    };
}
