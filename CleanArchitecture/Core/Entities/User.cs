namespace Core.Entities;

public sealed class User : BaseEntity
{
    public string? Email { get; private set; }
    public string? Name { get; private set; }
}
