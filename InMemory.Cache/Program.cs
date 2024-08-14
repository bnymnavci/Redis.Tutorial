using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.Swagger;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMvcCore()
        .AddApiExplorer();

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Your API", Version = "v1" });
});

builder.Services.AddTransient<ISwaggerProvider, SwaggerGenerator>();
builder.Services.AddMemoryCache();
//builder.Services.AddTransient<ISwaggerProvider, SwaggerUI>();
//builder.Services.ConfigureHttpJsonOptions(options =>
//{
//    options.SerializerOptions.TypeInfoResolverChain.Insert(0, AppJsonSerializerContext.Default);
//});
var app = builder.Build();

//var sampleTodos = new Todo[] {
//    new(1, "Walk the dog"),
//    new(2, "Do the dishes", DateOnly.FromDateTime(DateTime.Now)),
//    new(3, "Do the laundry", DateOnly.FromDateTime(DateTime.Now.AddDays(1))),
//    new(4, "Clean the bathroom"),
//    new(5, "Clean the car", DateOnly.FromDateTime(DateTime.Now.AddDays(2)))
//};


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Your API V1");
});
}

//var todosApi = app.MapGroup("/todos");
//todosApi.MapGet("/", () => sampleTodos);
//todosApi.MapGet("/{id}", (int id) =>
//    sampleTodos.FirstOrDefault(a => a.Id == id) is { } todo
//        ? Results.Ok(todo)
//        : Results.NotFound());

app.Run();

//public record Todo(int Id, string? Title, DateOnly? DueBy = null, bool IsComplete = false);

//[JsonSerializable(typeof(Todo[]))]
//internal partial class AppJsonSerializerContext : JsonSerializerContext
//{

//}
