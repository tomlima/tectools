using Tectools.Application.Interfaces;
using Tectools.Application.Services;
using Microsoft.EntityFrameworkCore;
using Tectools.Infrastructure.Interfaces;
using Tectools.Infrastructure.Repositories;


var builder = WebApplication.CreateBuilder(args);

// Db Context 
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseMySQL(connectionString));

// Add services to the container.
builder.Services.AddControllers(); // Register controllers

// Add OpenAPI (Swagger) support
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Register Application services
builder.Services.AddScoped<IComponentService, ComponentService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();

// Register Repositories
builder.Services.AddScoped<IComponentRepository, ComponentRepository>();
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger(); // Enable Swagger in development
    app.UseSwaggerUI(); // Use Swagger UI to interact with the API
}

app.UseHttpsRedirection();

app.MapGet("/components", async (IComponentService componentService) =>
{
    string sparqlQuery = @"
            SELECT ?cpu ?cpuLabel WHERE {
                ?cpu wdt:P31 wd:Q1394176.  # CPU instance
                SERVICE wikibase:label { bd:serviceParam wikibase:language '[AUTO_LANGUAGE],en'. }
            } LIMIT 10";
    var components = await componentService.RetrieveComponents(sparqlQuery);
    return Results.Ok(components);
});

// Add middleware to handle API requests
app.MapControllers(); // Map all controller routes

app.Run();