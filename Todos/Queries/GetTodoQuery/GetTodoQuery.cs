namespace MediatR_Sample;

public record GetTodoQuery(int Id) : IRequest<Todo>;