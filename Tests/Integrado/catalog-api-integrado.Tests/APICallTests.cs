namespace catalog_api_integrado.Tests;

public class APICallTests : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly WebApplicationFactory<Program> _factory;

    public APICallTests(WebApplicationFactory<Program> factory)
    {
        _factory = factory;
    }

    [Theory]
    [InlineData("/api/v1/Catalog/Ola")]
    public async Task Testar_CatalogGet(string url)
    {
        // Arrange
        var client = _factory.CreateClient();

        // Act
        var response = await client.GetAsync(url);

        // Assert
        response.EnsureSuccessStatusCode(); // Status Code 200-299
        
        Assert.Equal("application/json; charset=utf-8",
                     response.Content.Headers.ContentType?.ToString());
    }

    [Theory]
    [InlineData("/api/v1/Catalog/Ola")]
    public async Task Testar_CatalogGet_Content(string url)
    {
        // Arrange
        var client = _factory.CreateClient();

        // Act
        var response = await client.GetAsync(url);

        // Assert
        response.EnsureSuccessStatusCode(); // Status Code 200-299
        var content = await response.Content.ReadAsStringAsync();
        Assert.NotNull(content);
    }
}