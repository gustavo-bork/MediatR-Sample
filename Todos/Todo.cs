public record Todo(string Title, DateOnly? DueBy = null, bool IsComplete = false)
{
    private static int id = 1;
    public int Id { get; set; } = id++;
    
    public static List<Todo> sampleTodos = [
        new("Passear com o cachorro"),
        new("Lavar a louça", DateOnly.FromDateTime(DateTime.Now)),
        new("Colocar as roupas na máquina de lavar", DateOnly.FromDateTime(DateTime.Now.AddDays(1))),
        new("Limpar o banheiro"),
        new("Jogar o lixo fora", DateOnly.FromDateTime(DateTime.Now.AddDays(2)))
    ];
}