using Newtonsoft.Json;

namespace catalog_api.Controllers;

[Route("api/v1/[controller]")]
[ApiController]
public class CatalogController : ControllerBase
{
    private readonly IProdutoServices _produtoService;
    private readonly IMapper _mapper;

    public CatalogController(IProdutoServices produtoService, IMapper mapper)
    {
        _produtoService = produtoService;
        _mapper = mapper;
    }

    [HttpGet]
    [Route("items")]
    public async Task<IEnumerable<ProdutoModel>> GetAllProdutosAsync()
    {
        return await _produtoService.ExibirProdutosAsync();
    }

    //POST api/v1/[controller]/items
    [Route("items")]
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    public async Task<IActionResult> CriarProdutoAsync([FromBody] CreateProdutoDto produtoDto)
    {
        try
        {
            // Popular um objeto do tipo ProdutoModel com as informações de produto
            ProdutoModel produto = _mapper.Map<ProdutoModel>(produtoDto);

            // Chamar CriarProdutoAsync de ProdutoServices
            // await _produtoService.CriarProdutoAsync(produto);

            // Cria a URI

            // Passa a URI para o return CreatedAtAction
            return Ok(produto.Nome);
        }
        catch (Exception error)
        {
            return BadRequest(error);
        }
    }
}
