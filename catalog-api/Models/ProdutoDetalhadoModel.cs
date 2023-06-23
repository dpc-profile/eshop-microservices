using System.ComponentModel.DataAnnotations.Schema;

namespace catalog_api.Models;

[Table("ProdutoDetalhado")]
public class ProdutoDetalhadoModel
{
    public int Id { get; set; }

    public string? Nome { get; set; }

    public string? Descricao { get; set; }

    public string? Imagem { get; set; }

    public int Quantidade { get; set; }

    public double Preco { get; set; }

    public double? PrecoDesconto { get; set; }
    public double? DescontoPorcentagem { get; set; }
}
