namespace catalog_api.Models.Data;
public class BancoContext : DbContext
{
    public BancoContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<ProdutoModel> Produto { get; set; }

}
