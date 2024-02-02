namespace LectionServer.Contracts;

public record BookRequest
{
    public required string Author { get; init; }
    public required string Name { get; init; }
    public required string ImageUrl { get; init; }
}