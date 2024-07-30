using System.Text.Json.Serialization;
using MediatR_Sample;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateSlimBuilder(args);

builder.Services.ConfigureHttpJsonOptions(options =>
{
    options.SerializerOptions.TypeInfoResolverChain.Insert(0, AppJsonSerializerContext.Default);
});

builder.Services.AddMediatR(config => config.RegisterServicesFromAssemblyContaining<Program>());

var app = builder.Build();

var todos = app.MapGroup("/todos");

todos.MapGet("/", async (IMediator mediator) => 
{
    var todos = await mediator.Send(new GetAllTodosQuery());

    return Results.Ok(todos);
});

todos.MapGet("/{id}", async ([FromRoute] int id, IMediator mediator) => 
{
    Todo todo = await mediator.Send(new GetTodoQuery(id));

    return Results.Ok(todo);
});

todos.MapPost("/", async ([FromBody] CreateTodoCommand command, IMediator mediator) => 
{
    Todo newTodo = await mediator.Send(command);

    return Results.Ok(newTodo);
});

app.Run();

[JsonSerializable(typeof(Todo))]
[JsonSerializable(typeof(List<Todo>))]
[JsonSerializable(typeof(GetAllTodosQuery))]
[JsonSerializable(typeof(GetTodoQuery))]
[JsonSerializable(typeof(CreateTodoCommand))]
internal partial class AppJsonSerializerContext : JsonSerializerContext
{}