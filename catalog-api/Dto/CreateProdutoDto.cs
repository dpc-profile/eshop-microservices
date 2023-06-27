namespace catalog_api.Dto;
public class CreateProdutoDto
{
    [Required(ErrorMessage = "Nome do produto necessário.")]
    public string? Nome { get; init; }

    [Required(ErrorMessage = "Descrição do produto necessário.")]
    public string? Descricao { get; init; }

    [Required(ErrorMessage = "categoria do produto necessário.")]
    public string? Categoria { get; init; }

    [Required(ErrorMessage = "Quantidade do produto necessário.")]
    public int Quantidade { get; init; }

    [Column(TypeName = "decimal(18,2)")]
    [Required(ErrorMessage = "Preço do produto necessário.")]
    public decimal Preco { get; init; }

    public int? DescontoPorcentagem { get; init; }
}
