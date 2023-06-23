namespace catalog_api.Models;

[Table("Produto")]
public class ProdutoModel
{
    public int Id { get; init; }

    public string? Nome { get; init; }

    public string? Descricao { get; init; }

    public List<ImagemModel>? Imagens { get; init; }

    public int Quantidade { get; init; }

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
