namespace catalog_api.Controllers;

[Route("api/v1/[controller]")]
[ApiController]
public class CatalogController : ControllerBase
{
    private readonly IProdutoServices _produtoService;
    private readonly IImagemServices _imagemServices;

    private readonly IMapper _mapper;

    public CatalogController(IMapper mapper, IProdutoServices produtoService, IImagemServices imagemServices)
    {
        _mapper = mapper;
        _produtoService = produtoService;
        _imagemServices = imagemServices;
    }

    //GET api/v1/[controller]/items
    [HttpGet]
    [Route("items")]
    public async Task<IEnumerable<ProdutoModel>> GetAllProdutosAsync()
    {
        return await _produtoService.ExibirProdutosAsync();
    }

    [HttpGet]
    [Route("items/{id}")]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> ProdutoPorIdAsync(int id)
    {
        ProdutoModel? produto = await _produtoService.ExibirProdutoPorIdAsync(id);

        if (produto is null) return NotFound(new { Message = $"Produto com id {id} não encontrado."});

        return Ok(produto);
    }

    //POST api/v1/[controller]/items
    [HttpPost]
    [Route("items")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> CriarProdutoAsync([FromBody] CreateProdutoDto produtoDto)
    {
        try
        {
            ProdutoModel produto = _mapper.Map<ProdutoModel>(produtoDto);

            int id = await _produtoService.CriarProdutoAsync(produto);

            // Essa URI é temporária, até ser definido essa parte
            string uri = CreateURI(tipo: "produto", id, produtoDto.Nome);
            
            return Created(uri, produtoDto);
        }
        catch (Exception error)
        {
            return BadRequest(error);
        }
    }

    [HttpPost]
    [Route("items/{id}/imagem")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> AdicionarImagemAsync([FromBody] ImagemDto imagemDto, int id)
    {
        try
        {
            ProdutoModel? produto = await _produtoService.ExibirProdutoPorIdAsync(id);
            if (produto is null) return NotFound(new { Message = $"Produto com id {id} não encontrado."});
    
            ImagemModel imagem = _mapper.Map<ImagemModel>(imagemDto);
            imagem.ProdutoId = id;
       
            // Gravar a imagem no database
            await _imagemServices.AdicionarImagemAsync(imagem);

            string uri = CreateURI(tipo: "imagem", id, imagemDto.Nome);
            return Created(uri, imagemDto);

        }
        catch (Exception error)
        {
            return BadRequest(error);
        }
    }

    [NonAction]
    public string CreateURI(string tipo, int id, string? nome)
    {
        string newName = nome.Replace(oldChar: ' ', newChar: '-');
        return $"{tipo}/{id}/{newName}";
    }
}
