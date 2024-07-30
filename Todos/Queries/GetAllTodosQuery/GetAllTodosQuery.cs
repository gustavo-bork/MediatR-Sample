using System.Text.Json.Serialization;

namespace MediatR_Sample;

[JsonSerializable(typeof(GetAllTodosQuery))]
public record GetAllTodosQuery : IRequest<List<Todo>>;