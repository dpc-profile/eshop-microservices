namespace catalog_api.Controllers;

[Route("api/v1/[controller]")]
[ApiController]
public class CatalogController : ControllerBase
{
    private static readonly List<ProdutoModel> produtoList = new();
    private static readonly List<ImagemModel> imagemList = new();

    [HttpGet]
    [Route("Ola")]
    public List<ProdutoModel> GetProdutos()
    {
        imagemList.Add(new ImagemModel()
        {
            Id = 1,
            ProdutoId = 1,
            Nome = "imagem placehold",
            ImagemBase64 = "wryyyyyy"
        });

        ProdutoModel produto = new()
        {
            Id = 1,
            Nome = "Arroz",
            Descricao = "Pacote de arroz",
            Preco = 10,
            Quantidade = 432,
            Imagens = imagemList
        };

        produtoList.Add(produto);
        
        return produtoList;
    }

    [HttpPost]
    public void CreateProduto([FromBody] ProdutoModel produto)
    {

    }
}
