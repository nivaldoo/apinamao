using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/", () =>
{
    return Results.Ok("funciona");
});

app.MapPost("/", ([FromBody] string nome) =>
{
    return Results.Ok($"funciona {nome}");
});

app.Run();