namespace MediatR_Sample;

public class GetAllTodosQueryHandler : IRequestHandler<GetAllTodosQuery, List<Todo>>
{
    public Task<List<Todo>> Handle(GetAllTodosQuery request, CancellationToken cancellationToken) 
        => Task.FromResult(Todo.sampleTodos);
}
