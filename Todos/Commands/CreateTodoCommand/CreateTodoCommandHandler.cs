namespace MediatR_Sample;

public class CreateTodoCommandHandler : IRequestHandler<CreateTodoCommand, Todo>
{
    public Task<Todo> Handle(CreateTodoCommand request, CancellationToken cancellationToken) 
    {
        Todo.sampleTodos.Add(request);
        
        return Task.FromResult(Todo.sampleTodos.LastOrDefault());
    }
}
