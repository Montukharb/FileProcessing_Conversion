using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using ModuleComposition;
using Persistence.Composition;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddAppDbContextDependencyInjection((_, options) =>
{
    //Configure the service in the options you receive.
    options.UseSqlServer(GetConnectionString(builder));
});

builder.Services.ModuleCompositionServices();

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

app.UseDefaultFiles();
app.MapStaticAssets();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapFallbackToFile("/index.html");

app.Run();



static string GetConnectionString(WebApplicationBuilder builder)
{
    var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

    if(!connectionString.IsNullOrEmpty())
    {
        return connectionString;
    }
    throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
}
public partial class Program { }