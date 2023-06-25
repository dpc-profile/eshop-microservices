namespace catalog_api.Models;
public class ProdutoSimplificado
{
    public int Id { get; set; }

    public string? Nome { get; set; }
    public string? Categoria { get; set; }

    public ImagemModel? ImagemMiniatura { get; set; }

    public int Quantidade { get; set; }

    public decimal Preco { get; set; }

    public decimal? PrecoDesconto { get; set; }
    public double? DescontoPorcentagem { get; set; }
}
