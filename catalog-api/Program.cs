namespace catalog_api;

public class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        string? ConnectionString = builder.Configuration.GetConnectionString("Database");

        builder.Services.AddDbContext<BancoContext>(
            options => options.UseSqlServer(ConnectionString)
        );

        builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

        // Add services to the container.
        builder.Services.AddControllers();

        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        builder.Services.AddScoped<IProdutoRepository, ProdutoRepository>();
        builder.Services.AddScoped<IProdutoServices, ProdutoServices>();
        builder.Services.AddScoped<IImagemRepository, ImagemRepository>();
        builder.Services.AddScoped<IImagemServices, ImagemServices>();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}