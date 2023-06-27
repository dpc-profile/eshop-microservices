using System.Text.Json.Serialization;

namespace catalog_api.Dto;
public class CreateProdutoDto
{
    [Required(ErrorMessage = "Nome do produto necessário.")]
    [JsonPropertyName("Nome")]
    public string? Nome { get; init; }

    [Required(ErrorMessage = "Descrição do produto necessário.")]
    [JsonPropertyName("Descricao")]
    public string? Descricao { get; init; }

    [Required(ErrorMessage = "categoria do produto necessário.")]
    [JsonPropertyName("Categoria")]
    public string? Categoria { get; init; }

    [Required(ErrorMessage = "Imagem do produto necessário.")]
    [JsonPropertyName("Imagens")]
    public List<ImagemModel>? Imagens { get; init; }

    [Required(ErrorMessage = "Quantidade do produto necessário.")]
    [JsonPropertyName("Quantidade")]
    public int Quantidade { get; init; }

    [Column(TypeName = "decimal(18,2)")]
    [Required(ErrorMessage = "Preço do produto necessário.")]
    [JsonPropertyName("Preco")]
    public decimal Preco { get; init; }


    [JsonPropertyName("DescontoPorcentagem")]
    public int? DescontoPorcentagem { get; init; }
}
