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

    //GET api/v1/[controller]/items
    [HttpGet]
    [Route("items")]
    public async Task<IEnumerable<ProdutoModel>> GetAllProdutosAsync()
    {
        return await _produtoService.ExibirProdutosAsync();
    }

    [HttpGet]
    [Route("items/{id:int}")]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<ProdutoModel>> ProdutoPorIdAsync(int id)
    {
        ProdutoModel? produto = await _produtoService.ExibirProdutoPorIdAsync(id);

        if (produto is null) return NotFound(new { Message = $"Produto com id {id} não encontrado."});

        return produto;
    }

    //POST api/v1/[controller]/items
    [Route("items")]
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> CriarProdutoAsync([FromBody] CreateProdutoDto produtoDto)
    {
        try
        {
            ProdutoModel produto = _mapper.Map<ProdutoModel>(produtoDto);

            int Id = await _produtoService.CriarProdutoAsync(produto);

            return CreatedAtAction(
                nameof(ProdutoPorIdAsync), 
                new { Id }, 
                produtoDto);
        }
        catch (Exception error)
        {
            return BadRequest(error);
        }
    }

    public string CreateURI(int id, string nome)
    {
        return $"{id}/{nome}";
    }
}
