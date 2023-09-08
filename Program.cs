using _WebAPIMongoDB.Data;
using _WebAPIMongoDB.Interface;
using _WebAPIMongoDB.Models;
using _WebAPIMongoDB.Service;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//builder.Services.AddScoped<IProductInterface, IProductService>();
builder.Services.Configure<ProductStoreDBSettings>(builder.Configuration.GetSection(nameof(ProductStoreDBSettings)));


builder.Services.AddSingleton<IProductSettings>(x => x.GetRequiredService<IOptions<ProductStoreDBSettings>>().Value);

builder.Services.AddSingleton<IMongoClient>(x => new MongoClient(builder.Configuration.GetValue<string>
    ("ProductStoreDBSettings:ConnectionString")));

builder.Services.AddScoped<IProductInterface, MongoDbRepository>();


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
