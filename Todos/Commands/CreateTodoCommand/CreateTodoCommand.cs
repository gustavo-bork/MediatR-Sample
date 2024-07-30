namespace MediatR_Sample;

public record CreateTodoCommand : IRequest<Todo>
{
    public string Title { get; set; }
    public DateOnly? DueBy { get; set; }
    public bool IsComplete { get; set; }

    public static implicit operator Todo(CreateTodoCommand command)
        => new(command.Title, command.DueBy, command.IsComplete);
}
