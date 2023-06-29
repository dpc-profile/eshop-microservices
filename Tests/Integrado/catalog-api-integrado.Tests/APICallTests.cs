using catalog_api;

namespace catalog_api_integrado.Tests;

public class APICallTests : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly WebApplicationFactory<Program> _factory;

    public APICallTests(WebApplicationFactory<Program> factory)
    {
        _factory = factory;
    }

    [Theory]
    [InlineData("/api/v1/Catalog/items")]
    public async Task Testar_Gets_Endpoints(string url)
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
}