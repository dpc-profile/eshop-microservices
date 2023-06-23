namespace catalog_api.Controllers;

[Route("api/v1/[controller]")]
[ApiController]
public class CatalogController: ControllerBase
{
    [HttpGet]
    [Route("Ola")]
    public string Get(){
        return "Ola VOCE!!!";
    }
}
