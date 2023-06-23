namespace catalog_api.Models.Data;
public class BancoContext : DbContext
{
    protected readonly IConfiguration Configuration;

    public BancoContext(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(Configuration.GetConnectionString("Database"), options =>
            options.EnableRetryOnFailure());
    }

    public DbSet<ProdutoModel> Produto { get; set; }

}
