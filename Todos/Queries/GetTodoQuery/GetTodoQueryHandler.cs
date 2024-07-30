
namespace MediatR_Sample;

public class GetTodoQueryHandler : IRequestHandler<GetTodoQuery, Todo>
{
    public async Task<Todo> Handle(GetTodoQuery request, CancellationToken cancellationToken) 
        => await Task.FromResult(Todo.sampleTodos.Find(todo => todo.Id == request.Id));
}
